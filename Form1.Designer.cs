namespace RegLoginC_
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtComPassword = new TextBox();
            label4 = new Label();
            CheckbxShowpas = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 176);
            label1.Location = new Point(37, 32);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 91);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(37, 111);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(37, 179);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 159);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComPassword.Location = new Point(37, 242);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '•';
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 222);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // CheckbxShowpas
            // 
            CheckbxShowpas.AutoSize = true;
            CheckbxShowpas.Cursor = Cursors.Hand;
            CheckbxShowpas.FlatStyle = FlatStyle.Flat;
            CheckbxShowpas.Location = new Point(134, 276);
            CheckbxShowpas.Name = "CheckbxShowpas";
            CheckbxShowpas.Size = new Size(119, 21);
            CheckbxShowpas.TabIndex = 7;
            CheckbxShowpas.Text = "Show Password";
            CheckbxShowpas.UseVisualStyleBackColor = true;
            CheckbxShowpas.CheckedChanged += CheckbxShowpas_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(37, 324);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(37, 365);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 415);
            label5.Name = "label5";
            label5.Size = new Size(163, 17);
            label5.TabIndex = 10;
            label5.Text = "Already Have an Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(95, 442);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 11;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CheckbxShowpas);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtComPassword;
        private Label label4;
        private CheckBox CheckbxShowpas;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
    }
}
