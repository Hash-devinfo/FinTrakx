namespace FinTrax
{
    partial class ViewExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpense));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox8 = new PictureBox();
            panel1 = new Panel();
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label14 = new Label();
            ExpenseDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            deleteexp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpenseDGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1027, 12);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(20, 23);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 69;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
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
            panel1.TabIndex = 62;
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
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(56, 381);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 11;
            label6.Text = "View Expanse";
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
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(56, 209);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 5;
            label3.Text = "Income";
            label3.Click += label3_Click;
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Brown;
            label14.Location = new Point(547, 29);
            label14.Name = "label14";
            label14.Size = new Size(195, 32);
            label14.TabIndex = 67;
            label14.Text = "View Expense";
            // 
            // ExpenseDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ExpenseDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ExpenseDGV.BackgroundColor = Color.Gray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ExpenseDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ExpenseDGV.ColumnHeadersHeight = 4;
            ExpenseDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ExpenseDGV.DefaultCellStyle = dataGridViewCellStyle3;
            ExpenseDGV.GridColor = Color.FromArgb(231, 229, 255);
            ExpenseDGV.Location = new Point(215, 64);
            ExpenseDGV.Name = "ExpenseDGV";
            ExpenseDGV.RowHeadersVisible = false;
            ExpenseDGV.Size = new Size(838, 436);
            ExpenseDGV.TabIndex = 70;
            ExpenseDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ExpenseDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ExpenseDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ExpenseDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ExpenseDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ExpenseDGV.ThemeStyle.BackColor = Color.Gray;
            ExpenseDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ExpenseDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ExpenseDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ExpenseDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            ExpenseDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ExpenseDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ExpenseDGV.ThemeStyle.HeaderStyle.Height = 4;
            ExpenseDGV.ThemeStyle.ReadOnly = false;
            ExpenseDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ExpenseDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ExpenseDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ExpenseDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ExpenseDGV.ThemeStyle.RowsStyle.Height = 25;
            ExpenseDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ExpenseDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // deleteexp
            // 
            deleteexp.BackColor = Color.DeepSkyBlue;
            deleteexp.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            deleteexp.ForeColor = Color.Indigo;
            deleteexp.Location = new Point(927, 506);
            deleteexp.Name = "deleteexp";
            deleteexp.Size = new Size(120, 35);
            deleteexp.TabIndex = 71;
            deleteexp.Text = "Delete";
            deleteexp.UseVisualStyleBackColor = false;
            deleteexp.Click += deleteexp_Click;
            // 
            // ViewExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 561);
            Controls.Add(deleteexp);
            Controls.Add(ExpenseDGV);
            Controls.Add(pictureBox8);
            Controls.Add(panel1);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewExpense";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpenseDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox8;
        private Panel panel1;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView ExpenseDGV;
        private Button deleteexp;
    }
}