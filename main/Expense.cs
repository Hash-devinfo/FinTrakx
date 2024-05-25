using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinTrax
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
            GetToExp();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\fintrax\\FinTrax\\FinTraxDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public void Clear()
        {
            ExpNameTb.Text = "";
            ExpAmtTb.Text = "";
            ExpDescTb.Text = "";
            CatCb.SelectedIndex = 0;
        }
        public void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ExpNameTb.Text == "" || ExpAmtTb.Text == "" || ExpDescTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpenseTbl(ExpName,ExpAmt,ExpCat,ExpDate,ExpDesc,ExpUser)Values(@EN,@EA,@EC,@ED,@EDe,@EU)", Con);
                    cmd.Parameters.AddWithValue("@EN", ExpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", ExpAmtTb.Text);
                    cmd.Parameters.AddWithValue("@EC", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", ExpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EDe", ExpDescTb.Text);
                    cmd.Parameters.AddWithValue("@EU", Login.User);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense Addedd!!!");
                    Con.Close();
                    GetToExp();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        public void GetToExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TotalExpLbl.Text = "Rs= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch(Exception Ex)
            {
                Con.Close() ;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            ViewExpense Obj = new ViewExpense();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Income obj = new Income();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewIncome Obj = new ViewIncome();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}