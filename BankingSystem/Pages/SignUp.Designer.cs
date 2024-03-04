namespace BankingSystem.Pages
{
    partial class SignUp
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
            cancelButton = new Label();
            loginLabel = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = true;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(929, 15);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(20, 23);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "X";
            cancelButton.Click += cancelButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(774, 386);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(46, 20);
            loginLabel.TabIndex = 7;
            loginLabel.TabStop = true;
            loginLabel.Text = "Login";
            loginLabel.LinkClicked += loginLabel_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 386);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 15;
            label4.Text = "already registered? ";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(666, 443);
            button1.Name = "button1";
            button1.Size = new Size(147, 41);
            button1.TabIndex = 8;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(510, 269);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(510, 220);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(716, 263);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(229, 34);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(716, 214);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "UserName";
            textBox1.Size = new Size(229, 34);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold);
            label1.Location = new Point(654, 50);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 9;
            label1.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(510, 171);
            label5.Name = "label5";
            label5.Size = new Size(61, 24);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(510, 122);
            label6.Name = "label6";
            label6.Size = new Size(103, 24);
            label6.TabIndex = 20;
            label6.Text = "Full Name";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(716, 165);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(229, 34);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(716, 116);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Full Name";
            textBox4.Size = new Size(229, 34);
            textBox4.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(510, 319);
            label7.Name = "label7";
            label7.Size = new Size(178, 24);
            label7.TabIndex = 23;
            label7.Text = "ConfirmPassword";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(716, 313);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Confirm Password";
            textBox5.Size = new Size(229, 34);
            textBox5.TabIndex = 6;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.banking_login_screen1;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(968, 509);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(cancelButton);
            Controls.Add(loginLabel);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cancelButton;
        private LinkLabel loginLabel;
        private Label label4;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
    }
}