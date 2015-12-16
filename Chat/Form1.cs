using System;
using System.IO;
using System.Net;
using System.Text;
using System.Media;
using System.Drawing;
using System.Diagnostics;
using System.Net.Sockets;
using System.Windows.Forms;
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

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        //copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyAction();
        }

        //paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteAction();
        }

        //save chat
        private void saveChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (diag.ShowDialog() == DialogResult.OK)
            {
                try {
                    using (StreamWriter stream = new StreamWriter(diag.FileName.ToString()))
                    {
                        for (int i = 0; i < textBox_Chat.Lines.Length; i++)
                        {
                            stream.WriteLine(textBox_Chat.Lines[i]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error saving chat");
                }
            }
        }

        //clear chat
        private void clearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the current chat log?\n\nThis will NOT clear the chat for the other client!", "Delete current chat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                textBox_Chat.Clear();
            }
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

        //open link
        private void textBox_Chat_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
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

                textBox_Chat.AppendText("Client: Connected to " + textBox_IP2.Text);
                toolStripStatusLabel1.Text = "Connected to: " + textBox_IP2.Text + ":" + textBox_Port2.Text;
                textBox_Chat.AppendText(Environment.NewLine + "Type in '/help' to view a list of available commands.");
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
                    textBox_Chat.AppendText(Environment.NewLine + "Client: Disconnected from the current session.");
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
                        textBox_Chat.AppendText(Environment.NewLine + "Available commands:");
                        textBox_Chat.AppendText(Environment.NewLine + "/help - Displays this text.");
                        textBox_Chat.AppendText(Environment.NewLine + "/ftp <path> - Sends a file to the connected friend.");
                        textBox_Chat.AppendText(Environment.NewLine + "/disconnect - Disconnect from the current friend.");
                        textBox_Chat.AppendText(Environment.NewLine + "/c <color> <message> - Sets a color for the current message.");
                    }

                    //command for sending files
                    else if (textBox_toSend.Text.Contains("/ftp"))
                    {
                        string path = textBox_toSend.Text.Split(' ')[1];
                        if (File.Exists(path))
                        {
                            socket.SendFile(path);
                            textBox_Chat.AppendText(Environment.NewLine + "Sending '" + path + "' to " + textBox_IP2.Text);
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

                    else if (textBox_toSend.Text.Contains("/c"))
                    {
                        string color = textBox_toSend.Text.Split(' ')[1];
                        string message = textBox_toSend.Text.Substring(textBox_toSend.Text.IndexOf(' ') + 1).Replace(color, "");
                        if (color == "" || message == "")
                        {
                            textBox_Chat.AppendText(Environment.NewLine + "Usage: /c <color> <message>");
                        }
                        else
                        {
                            Color c = Color.FromName(color);
                            AppendText(textBox_Chat, message, c);
                        }
                    }

                    //display error if unkown command
                    else
                    {
                        textBox_Chat.AppendText(Environment.NewLine + "Unkown command. Type in '/help' for a list of commands.");
                    }

                    textBox_toSend.Text = "";
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
                    textBox_Chat.AppendText(Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + " Sent: " + textBox_toSend.Text);
                    textBox_toSend.Text = "";
                }
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

        // this puts the recieved message into the listbox, i think; recieve message
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
                textBox_Chat.AppendText(Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + " Recieved: " + recievedMessage);

                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                SoundPlayer play = new SoundPlayer();
                play.SoundLocation = "Resources\\recieve.wav";
                play.Play();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //add the current ip from textbox_ip2 to bookmarks
        private void addCurrentToBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_IP2.Text)) MessageBox.Show("Please specify an address in the friend IP textbox.", "No address provided");
            else
            {
                Bookmarks book = new Bookmarks();
                book.Show();

                book.add(textBox_IP2.Text, true);
                MessageBox.Show("The current friend IP address has been added to the bookmark list.", "Added to bookmarks");
            }
        }

        //change text color
        public static void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + " Recieved: " + text);
            box.SelectionColor = box.ForeColor;
        }

        //copy paste
        void CopyAction()
        {
            Clipboard.SetText(textBox_Chat.SelectedText);
        }
        void PasteAction()
        {
            if (Clipboard.ContainsText())
                textBox_Chat.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
        }

        //autoscroll dole u textboxu
        private void textBox_Chat_TextChanged(object sender, EventArgs e)
        {
            textBox_Chat.SelectionStart = textBox_Chat.Text.Length;
            textBox_Chat.ScrollToCaret();
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
