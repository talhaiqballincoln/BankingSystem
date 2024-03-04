namespace BankingSystem.Pages
{
    partial class HomeScreen
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            cancelButton = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            AccountNumber = new DataGridViewTextBoxColumn();
            AccountHolderName = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 553);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(59, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSeaGreen;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(0, 256);
            button5.Name = "button5";
            button5.Size = new Size(311, 51);
            button5.TabIndex = 4;
            button5.Text = "Loan Management";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSeaGreen;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(0, 313);
            button4.Name = "button4";
            button4.Size = new Size(311, 51);
            button4.TabIndex = 3;
            button4.Text = "Transactions";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 199);
            button1.Name = "button1";
            button1.Size = new Size(311, 51);
            button1.TabIndex = 0;
            button1.Text = "Account Management";
            button1.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = true;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(1005, 9);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(20, 23);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "X";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Location = new Point(325, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(700, 507);
            flowLayoutPanel1.TabIndex = 19;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(220, 28);
            label3.TabIndex = 2;
            label3.Text = "Account management";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(229, 3);
            button2.Name = "button2";
            button2.Size = new Size(232, 51);
            button2.TabIndex = 6;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AccountNumber, AccountHolderName, Balance });
            dataGridView1.Location = new Point(3, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(636, 393);
            dataGridView1.TabIndex = 3;
            // 
            // AccountNumber
            // 
            AccountNumber.HeaderText = "Account number";
            AccountNumber.MinimumWidth = 6;
            AccountNumber.Name = "AccountNumber";
            AccountNumber.ReadOnly = true;
            AccountNumber.Width = 125;
            // 
            // AccountHolderName
            // 
            AccountHolderName.HeaderText = "Account Holder Name";
            AccountHolderName.MinimumWidth = 6;
            AccountHolderName.Name = "AccountHolderName";
            AccountHolderName.ReadOnly = true;
            AccountHolderName.Width = 125;
            // 
            // Balance
            // 
            Balance.HeaderText = "Account Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            Balance.Width = 125;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 554);
            Controls.Add(cancelButton);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeScreen";
            Text = "HomeScreen";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Label cancelButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn AccountHolderName;
        private DataGridViewTextBoxColumn Balance;
    }
}