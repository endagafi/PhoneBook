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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.SaveButton.Enabled = true;
            this.NewButton.Enabled = false;
            this.InfoGroup.Enabled = true;

            this.ClearTextBoxes();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.id_textbox.Text=="")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            this.SaveButton.Enabled = false;
            this.NewButton.Enabled = true;
            this.InfoGroup.Enabled = false;
            this.Save(this.id_textbox.Text);
            MessageBox.Show("Saved!");
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.InfoGroup.Enabled = false;
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void Save(String id)
        {
            Action<Control.ControlCollection> func = null;
            string file = "..\\files\\";
            string p;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        p= file + id + "_"+ (control as TextBox).Name + ".txt";
                        System.IO.File.WriteAllText(p, (control as TextBox).Text, Encoding.UTF8);
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
