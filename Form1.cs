using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    toolStripButton5_Click(sender, e);
                    break;
                case Keys.F3:
                    toolStripButton4_Click(sender, e);
                    break;
                case Keys.F4:
                    toolStripButton3_Click(sender, e);
                    break;
                case Keys.F5:
                    toolStripButton2_Click(sender, e);
                    break;
                case Keys.Escape:
                    toolStripButton1_Click(sender, e);
                    break;
            }
        }
    }
}
