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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            this.Search(this.textBox1.Text);
        }
        private void Search(String id)
        {
            Action<Control.ControlCollection> func = null;
            string file = "..\\files\\";
            string p;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        p = file + id + "_" + (control as TextBox).Name + ".txt";
                        if (System.IO.File.Exists(p)) {
                            (control as TextBox).Text = System.IO.File.ReadAllText(p,Encoding.UTF8);
                        }
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
