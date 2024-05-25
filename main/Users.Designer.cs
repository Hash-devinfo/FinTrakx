namespace FinTrax
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            label4 = new Label();
            AddressTb = new TextBox();
            label3 = new Label();
            PhoneTb = new TextBox();
            DOB = new DateTimePicker();
            label13 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            AddBtn = new Button();
            label2 = new Label();
            PasswordTb = new TextBox();
            label9 = new Label();
            UnameTb = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(22, 278);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 86;
            label4.Text = "Address";
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTb.Location = new Point(22, 300);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(181, 53);
            AddressTb.TabIndex = 85;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(22, 174);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 84;
            label3.Text = "Phone";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.Location = new Point(22, 196);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(181, 27);
            PhoneTb.TabIndex = 83;
            // 
            // DOB
            // 
            DOB.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOB.Format = DateTimePickerFormat.Short;
            DOB.Location = new Point(22, 144);
            DOB.Name = "DOB";
            DOB.Size = new Size(181, 27);
            DOB.TabIndex = 82;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.RoyalBlue;
            label13.Location = new Point(22, 122);
            label13.Name = "label13";
            label13.Size = new Size(102, 19);
            label13.TabIndex = 81;
            label13.Text = "Date Of Birth";
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(22, 399);
            button2.Name = "button2";
            button2.Size = new Size(63, 26);
            button2.TabIndex = 80;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DeepSkyBlue;
            AddBtn.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Indigo;
            AddBtn.Location = new Point(202, 367);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(120, 35);
            AddBtn.TabIndex = 77;
            AddBtn.Text = "Register";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(22, 226);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 76;
            label2.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(22, 248);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(181, 27);
            PasswordTb.TabIndex = 75;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(22, 70);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 74;
            label9.Text = "User Name";
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.Location = new Point(22, 92);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(181, 27);
            UnameTb.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(65, 14);
            label1.Name = "label1";
            label1.Size = new Size(124, 34);
            label1.TabIndex = 72;
            label1.Text = "Fintrax";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 432);
            Controls.Add(label4);
            Controls.Add(AddressTb);
            Controls.Add(label3);
            Controls.Add(PhoneTb);
            Controls.Add(DOB);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(AddBtn);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(label9);
            Controls.Add(UnameTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox AddressTb;
        private Label label3;
        private TextBox PhoneTb;
        private DateTimePicker DOB;
        private Label label13;
        private Button button2;
        private PictureBox pictureBox1;
        private Button AddBtn;
        private Label label2;
        private TextBox PasswordTb;
        private Label label9;
        private TextBox UnameTb;
        private Label label1;
    }
}