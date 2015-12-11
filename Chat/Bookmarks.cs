using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Chat
{
    public partial class Bookmarks : Form
    {
        string path;
        string bookmark;
        List<string> bookmarks = new List<string>();

        public Bookmarks()
        {
            InitializeComponent();
            path = "Resources\\bookmarks.txt";
            if (!File.Exists(path))
            {
                File.Create("Resources\\bookmarks.txt");
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

        private void add(string ip)
        {
            if (ip == "")
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                    bookmark = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Please input an IP", "Error");
                }
            }
            else
            {
                listBox1.Items.Add(ip);
                bookmark = ip;
            }

            save();
        }

        private void remove()
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                bookmarks.Remove(listBox1.GetItemText(listBox1.SelectedItem));
            }
        }

        private void save()
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(bookmarks);
            }
        }

        private void button_add_Click(object sender, System.EventArgs e)
        {
            add("");
        }

        private void button_select_Click(object sender, System.EventArgs e)
        {
            Form1 form = new Form1();
            form.textBox_IP2_Value = listBox1.GetItemText(listBox1.SelectedItem);

            save();
            Close();
        }

        private void button_remove_Click(object sender, System.EventArgs e)
        {
            remove();
        }

        private void button_close_Click(object sender, System.EventArgs e)
        {
            save();
            Close();
        }
    }
}