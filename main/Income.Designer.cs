namespace FinTrax
{
    partial class Income
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income));
            pictureBox8 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SvaeBtn = new Button();
            IncDate = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            CatCb = new ComboBox();
            label11 = new Label();
            IncDescTb = new TextBox();
            label10 = new Label();
            IncAmtTb = new TextBox();
            label9 = new Label();
            IncNameTb = new TextBox();
            TotalIncLbl = new Label();
            label34 = new Label();
            label14 = new Label();
            panel11 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1027, 12);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(20, 23);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 70;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // SvaeBtn
            // 
            SvaeBtn.BackColor = Color.DeepSkyBlue;
            SvaeBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SvaeBtn.ForeColor = Color.Indigo;
            SvaeBtn.Location = new Point(652, 489);
            SvaeBtn.Name = "SvaeBtn";
            SvaeBtn.Size = new Size(136, 35);
            SvaeBtn.TabIndex = 68;
            SvaeBtn.Text = "Save Income";
            SvaeBtn.UseVisualStyleBackColor = false;
            SvaeBtn.Click += SvaeBtn_Click;
            // 
            // IncDate
            // 
            IncDate.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncDate.Format = DateTimePickerFormat.Short;
            IncDate.Location = new Point(769, 267);
            IncDate.Name = "IncDate";
            IncDate.Size = new Size(181, 27);
            IncDate.TabIndex = 67;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Brown;
            label13.Location = new Point(769, 235);
            label13.Name = "label13";
            label13.Size = new Size(45, 19);
            label13.TabIndex = 66;
            label13.Text = "Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Brown;
            label12.Location = new Point(769, 153);
            label12.Name = "label12";
            label12.Size = new Size(92, 19);
            label12.TabIndex = 65;
            label12.Text = "Categories";
            // 
            // CatCb
            // 
            CatCb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Salary", "Business", "Tips", "Others" });
            CatCb.Location = new Point(769, 185);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(181, 28);
            CatCb.TabIndex = 64;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Brown;
            label11.Location = new Point(631, 329);
            label11.Name = "label11";
            label11.Size = new Size(88, 19);
            label11.TabIndex = 63;
            label11.Text = "Discription";
            // 
            // IncDescTb
            // 
            IncDescTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncDescTb.Location = new Point(631, 361);
            IncDescTb.Multiline = true;
            IncDescTb.Name = "IncDescTb";
            IncDescTb.Size = new Size(181, 81);
            IncDescTb.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Brown;
            label10.Location = new Point(538, 235);
            label10.Name = "label10";
            label10.Size = new Size(71, 19);
            label10.TabIndex = 61;
            label10.Text = "Amount";
            // 
            // IncAmtTb
            // 
            IncAmtTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncAmtTb.Location = new Point(538, 267);
            IncAmtTb.Name = "IncAmtTb";
            IncAmtTb.Size = new Size(181, 27);
            IncAmtTb.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Brown;
            label9.Location = new Point(538, 153);
            label9.Name = "label9";
            label9.Size = new Size(122, 19);
            label9.TabIndex = 59;
            label9.Text = "Income Name";
            // 
            // IncNameTb
            // 
            IncNameTb.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncNameTb.Location = new Point(538, 185);
            IncNameTb.Name = "IncNameTb";
            IncNameTb.Size = new Size(181, 27);
            IncNameTb.TabIndex = 58;
            // 
            // TotalIncLbl
            // 
            TotalIncLbl.AutoSize = true;
            TotalIncLbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TotalIncLbl.ForeColor = Color.Black;
            TotalIncLbl.Location = new Point(46, 58);
            TotalIncLbl.Name = "TotalIncLbl";
            TotalIncLbl.Size = new Size(110, 19);
            TotalIncLbl.TabIndex = 9;
            TotalIncLbl.Text = "Amount in RS";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label34.ForeColor = Color.Brown;
            label34.Location = new Point(12, 9);
            label34.Name = "label34";
            label34.Size = new Size(129, 23);
            label34.TabIndex = 8;
            label34.Text = "Total Income";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Brown;
            label14.Location = new Point(626, 78);
            label14.Name = "label14";
            label14.Size = new Size(208, 32);
            label14.TabIndex = 69;
            label14.Text = "Income Details";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.InactiveCaption;
            panel11.Controls.Add(TotalIncLbl);
            panel11.Controls.Add(label34);
            panel11.Location = new Point(231, 350);
            panel11.Name = "panel11";
            panel11.Size = new Size(212, 92);
            panel11.TabIndex = 57;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(115, 518);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 13;
            label7.Text = "Logout";
            label7.Click += label7_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(71, 507);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 34);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(56, 381);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 11;
            label6.Text = "View Expanse";
            label6.Click += label6_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 370);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(56, 325);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 9;
            label5.Text = "View Income";
            label5.Click += label5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 314);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(56, 267);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 7;
            label4.Text = "Expense";
            label4.Click += label4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 256);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(56, 209);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 5;
            label3.Text = "Income";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(56, 149);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 3;
            label2.Text = "Dashboard";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(67, 32);
            label1.Name = "label1";
            label1.Size = new Size(108, 29);
            label1.TabIndex = 1;
            label1.Text = "Fintrax";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 561);
            panel1.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(256, 32);
            label8.Name = "label8";
            label8.Size = new Size(187, 25);
            label8.TabIndex = 56;
            label8.Text = "Persional Income";
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 561);
            Controls.Add(pictureBox8);
            Controls.Add(SvaeBtn);
            Controls.Add(IncDate);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(CatCb);
            Controls.Add(label11);
            Controls.Add(IncDescTb);
            Controls.Add(label10);
            Controls.Add(IncAmtTb);
            Controls.Add(label9);
            Controls.Add(IncNameTb);
            Controls.Add(label14);
            Controls.Add(panel11);
            Controls.Add(panel1);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Income";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button SvaeBtn;
        private DateTimePicker IncDate;
        private Label label13;
        private Label label12;
        private ComboBox CatCb;
        private Label label11;
        private TextBox IncDescTb;
        private Label label10;
        private TextBox IncAmtTb;
        private Label label9;
        private TextBox IncNameTb;
        private Label TotalIncLbl;
        private Label label34;
        private Label label14;
        private Panel panel11;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox7;
        private Label label6;
        private PictureBox pictureBox6;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private Label label8;
    }
}