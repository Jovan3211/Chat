using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using encryption = Chat.Encryption;

namespace Chat
{
    public partial class Form1 : Form
    {
        //declarations
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        public string textBox_IP2_Value
        {
            get { return textBox_IP2.Text; }
            set { textBox_IP2.Text = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get user ip
            textBox_IP1.Text = GetLocalIP();
            textBox_IP2.Text = GetLocalIP();

            //other
            toolStripStatusLabel1.Text = "Disconnected";

            if (socket.IsBound)
            {
                // Create the ToolTip and associate with the Form container.
                ToolTip toolTip1 = new ToolTip();

                // Set up the delays for the ToolTip.
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 100;
                toolTip1.ReshowDelay = 500;
                // Force the ToolTip text to be displayed whether or not the form is active.
                toolTip1.ShowAlways = true;

                // Set up the ToolTip text for the Button and Checkbox.
                toolTip1.SetToolTip(this.button_Connect, "The program must restart to be able to connect again. Pressing connect will relaunch the program.");
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void textBox_toSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                sendMessage();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Resources\\help.html");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        private void bookmarkListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookmarks form = new Bookmarks();
            form.Show();
        }

        //select a file to send.
        private void button_sendFile_Click(object sender, EventArgs e)
        {
            string path = "/ftp ";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path += Path.GetDirectoryName(openFileDialog1.FileName) + "\\" + Path.GetFileName(openFileDialog1.FileName);
                textBox_toSend.Text = path;
            }
        }

        //function to connect to an ip
        private void connect()
        {
            //if (string.IsNullOrWhiteSpace(textBox_IP1.Text) || string.IsNullOrWhiteSpace(textBox_IP2.Text) || string.IsNullOrWhiteSpace(textBox_Port1.Text) || string.IsNullOrWhiteSpace(textBox_Port2.Text))
            //{
            if (!socket.IsBound)
            {
                //binding socket
                try {
                    epLocal = new IPEndPoint(IPAddress.Parse(textBox_IP1.Text), Convert.ToInt32(textBox_Port1.Text));
                    socket.Bind(epLocal);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error binding socket");
                }
            }
            else if (!socket.Connected)
            {
                Application.Restart();
            }

            //connecting to remote IP
            try {
                epRemote = new IPEndPoint(IPAddress.Parse(textBox_IP2.Text), Convert.ToInt32(textBox_Port2.Text));
                socket.Connect(epRemote);

                //listening to the specific port
                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                listBox_chat.Items.Add("Client: Connected to " + textBox_IP2.Text);
                toolStripStatusLabel1.Text = "Connected to: " + textBox_IP2.Text + ":" + textBox_Port2.Text;
                listBox_chat.Items.Add("Type in '/help' to view a list of available commands.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error connecting to remote IP");
            }
        }

        //function to disconnect from an ip
        private void disconnect()
        {
            if (socket.Connected)
            {
                try
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    toolStripStatusLabel1.Text = "Disconnected";
                    listBox_chat.Items.Add("Client: Disconnected from the current session.");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else
            {
                MessageBox.Show("Not connected!");
            }
        }

        //function for sending the message
        private void sendMessage()
        {
            if (socket.Connected)
            {
                //checks if the input message is a command, if it is, execute it
                int index = textBox_toSend.Text.IndexOf("/");
                if (textBox_toSend.Text.Contains("/") && index == 0)
                {
                    //show all text commands
                    if (textBox_toSend.Text.Contains("/help"))
                    {
                        listBox_chat.Items.Add("Available commands:");
                        listBox_chat.Items.Add("/help - Displays this text.");
                        listBox_chat.Items.Add("/ftp <path> - Sends a file to the connected friend.");
                        listBox_chat.Items.Add("/disconnect - Disconnect from the current friend.");

                        textBox_toSend.Text = "";
                    }

                    //command for sending files
                    else if (textBox_toSend.Text.Contains("/ftp"))
                    {
                        string path = textBox_toSend.Text.Split(' ')[1];
                        if (File.Exists(path))
                        {
                            socket.SendFile(path);
                            listBox_chat.Items.Add("Sending '" + path + "' to " + textBox_IP2.Text);
                            textBox_toSend.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("The selected file does not exist!\n" + path, "Error sending file");
                        }
                    }

                    //command for disconnecting
                    else if (textBox_toSend.Text.Contains("/disconnect"))
                    {
                        disconnect();
                    }

                    //display error if unkown command
                    else
                    {
                        listBox_chat.Items.Add("Unkown command. Type in '/help' for a list of commands.");
                        textBox_toSend.Text = "";
                    }
                }
                else
                {
                    //send message normaly
                    //convert string message to byte[]
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    byte[] sendingMessage = new byte[1500];
                    sendingMessage = aEncoding.GetBytes(textBox_toSend.Text);

                    //sending message
                    socket.Send(sendingMessage);

                    //adding to listbox
                    listBox_chat.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " Sent: " + textBox_toSend.Text);
                    textBox_toSend.Text = "";
                }

                listBox_chat.SelectedIndex = listBox_chat.Items.Count - 1;
                listBox_chat.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Not connected!");
            }
        }

        //function for getting the local ip
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "127.0.0.1";
        }

        // this puts the recieved message into the listbox, i think
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] recievedData = new byte[1500];
                recievedData = (byte[])aResult.AsyncState;

                //converting byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string recievedMessage = aEncoding.GetString(recievedData);

                //adding message to listbox
                listBox_chat.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " Recieved: " + recievedMessage);

                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                listBox_chat.SelectedIndex = listBox_chat.Items.Count - 1;
                listBox_chat.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //key combinations
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                connect();
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                disconnect();
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                Bookmarks form = new Bookmarks();
                form.Show();
            }
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("Resources\\help.html");
            }
        }
    }
}
