namespace PhoneBook
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.InfoGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.fn_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ln_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cell_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.com_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.InfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.toolStripSeparator1,
            this.SaveButton,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(392, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(78, 22);
            this.NewButton.Text = "New Data";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(51, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // InfoGroup
            // 
            this.InfoGroup.Controls.Add(this.com_textbox);
            this.InfoGroup.Controls.Add(this.label8);
            this.InfoGroup.Controls.Add(this.add_textbox);
            this.InfoGroup.Controls.Add(this.label7);
            this.InfoGroup.Controls.Add(this.email_textbox);
            this.InfoGroup.Controls.Add(this.label6);
            this.InfoGroup.Controls.Add(this.cell_textbox);
            this.InfoGroup.Controls.Add(this.label5);
            this.InfoGroup.Controls.Add(this.tel_textbox);
            this.InfoGroup.Controls.Add(this.label4);
            this.InfoGroup.Controls.Add(this.ln_textbox);
            this.InfoGroup.Controls.Add(this.label3);
            this.InfoGroup.Controls.Add(this.fn_textbox);
            this.InfoGroup.Controls.Add(this.label2);
            this.InfoGroup.Controls.Add(this.id_textbox);
            this.InfoGroup.Controls.Add(this.label1);
            this.InfoGroup.Location = new System.Drawing.Point(13, 63);
            this.InfoGroup.Name = "InfoGroup";
            this.InfoGroup.Size = new System.Drawing.Size(349, 334);
            this.InfoGroup.TabIndex = 1;
            this.InfoGroup.TabStop = false;
            this.InfoGroup.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(82, 40);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(210, 20);
            this.id_textbox.TabIndex = 1;
            // 
            // fn_textbox
            // 
            this.fn_textbox.Location = new System.Drawing.Point(82, 66);
            this.fn_textbox.Name = "fn_textbox";
            this.fn_textbox.Size = new System.Drawing.Size(210, 20);
            this.fn_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // ln_textbox
            // 
            this.ln_textbox.Location = new System.Drawing.Point(82, 92);
            this.ln_textbox.Name = "ln_textbox";
            this.ln_textbox.Size = new System.Drawing.Size(210, 20);
            this.ln_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // tel_textbox
            // 
            this.tel_textbox.Location = new System.Drawing.Point(82, 118);
            this.tel_textbox.Name = "tel_textbox";
            this.tel_textbox.Size = new System.Drawing.Size(210, 20);
            this.tel_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel";
            // 
            // cell_textbox
            // 
            this.cell_textbox.Location = new System.Drawing.Point(82, 144);
            this.cell_textbox.Name = "cell_textbox";
            this.cell_textbox.Size = new System.Drawing.Size(210, 20);
            this.cell_textbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cell";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(82, 170);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(210, 20);
            this.email_textbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // add_textbox
            // 
            this.add_textbox.Location = new System.Drawing.Point(82, 196);
            this.add_textbox.Name = "add_textbox";
            this.add_textbox.Size = new System.Drawing.Size(210, 20);
            this.add_textbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // com_textbox
            // 
            this.com_textbox.Location = new System.Drawing.Point(82, 222);
            this.com_textbox.Name = "com_textbox";
            this.com_textbox.Size = new System.Drawing.Size(210, 20);
            this.com_textbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(392, 441);
            this.Controls.Add(this.InfoGroup);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Data";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.InfoGroup.ResumeLayout(false);
            this.InfoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox InfoGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cell_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tel_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ln_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fn_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox com_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox add_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label6;
    }
}