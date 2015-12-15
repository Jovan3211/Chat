using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System;

namespace Chat
{
    public partial class Bookmarks : Form
    {
        string path;
        List<string> bookmarks = new List<string>();

        public Bookmarks()
        {
            InitializeComponent();
            refreshList();
        }

        //funkcija za refreshovanje liste
        private void refreshList()
        {
            path = "Resources\\bookmarks.txt";
            listBox1.Items.Clear();

            if (!File.Exists(path))
            {
                File.Create("Resources\\bookmarks.txt").Close();
            }
            else
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    bookmarks = File.ReadLines(path).ToList();
                }

                foreach (string ip in bookmarks)
                {
                    listBox1.Items.Add(ip);
                }
            }
        }

        //funkcija za dodavanje adrese u bookmarks
        public void add(string ip, bool closeAfter = false)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine(ip);
            }

            refreshList();
            if (closeAfter) Close();
        }

        //dodavanje u bookmarks
        private void button_add_Click(object sender, System.EventArgs e)
        {
            add(textBox_IP.Text);
        }

        //ne znam kako ovaj algoritam radi, al je jako seksi - uklanja iz bookmarksa
        private void button_remove_Click(object sender, System.EventArgs e)
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(path).Where(l => l != listBox1.SelectedItem.ToString());

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(path);
            File.Move(tempFile, path);

            refreshList();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Please select an IP from the list.", "No address selected");
            else
            {
                Form1 form = new Form1();
                form.textBox_IP2.Text = listBox1.SelectedItem.ToString();
                Close();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}