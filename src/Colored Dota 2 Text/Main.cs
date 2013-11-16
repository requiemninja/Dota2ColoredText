using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colored_Dota_2_Text
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string username = Environment.UserName;
            this.Text = username + " is using Colored Dota 2 Text";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox.SelectedIndex)
            {
                case 0:
                    textBox.AppendText("\u0006");
                    break;
                case 1:
                    textBox.AppendText("\u0014");
                    break;
                case 2:
                    textBox.AppendText("\u0019");
                    break;
                case 3:
                    textBox.AppendText("\u0010");
                    break;
                case 4:
                    textBox.AppendText("\u0018");
                    break;
                case 5:
                    textBox.AppendText("\f");
                    break;
                case 6:
                    textBox.AppendText("\u0017");
                    break;
                case 7:
                    textBox.AppendText("\u0015");
                    break;
                case 8:
                    textBox.AppendText("\u001a");
                    break;
                case 9:
                    textBox.AppendText("\u000e");
                    break;
                case 10:
                    textBox.AppendText("\u000f");
                    break;
                case 11:
                    textBox.AppendText("\u0011");
                    break;
                case 12:
                    textBox.AppendText("\u0016");
                    break;
                case 13:
                    textBox.AppendText("\u0012");
                    break;
                case 14:
                    textBox.AppendText("\u001c");
                    break;
                case 15:
                    textBox.AppendText("\t");
                    break;
                case 16:
                    textBox.AppendText("\u001d");
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.Text);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://zsource.org");
        }

        private void clearClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
