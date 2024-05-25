namespace FinTrax
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            LoginBtn = new Button();
            label2 = new Label();
            PasswordTb = new TextBox();
            label9 = new Label();
            UnameTb = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(4, 364);
            button2.Name = "button2";
            button2.Size = new Size(106, 33);
            button2.TabIndex = 72;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(309, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DeepSkyBlue;
            LoginBtn.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.Indigo;
            LoginBtn.Location = new Point(104, 305);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(120, 35);
            LoginBtn.TabIndex = 69;
            LoginBtn.Text = "LogIn";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(83, 224);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 68;
            label2.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(83, 256);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(181, 27);
            PasswordTb.TabIndex = 67;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(83, 133);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 66;
            label9.Text = "User Name";
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.Location = new Point(83, 165);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(181, 27);
            UnameTb.TabIndex = 65;
            UnameTb.TextChanged += UnameTb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(83, 30);
            label1.Name = "label1";
            label1.Size = new Size(124, 34);
            label1.TabIndex = 64;
            label1.Text = "Fintrax";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 432);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(label9);
            Controls.Add(UnameTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button LoginBtn;
        private Label label2;
        private TextBox PasswordTb;
        private Label label9;
        private TextBox UnameTb;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}