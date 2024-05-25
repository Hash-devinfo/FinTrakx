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
    public partial class ViewIncome : Form
    {
        public ViewIncome()
        {
            InitializeComponent();
            DisplayIncomes();
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\fintrax\\FinTrax\\FinTraxDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void DisplayIncomes()
        {
            Con.Open();
            String Query = "Select * from Income_Tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];
            Con.Close();
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

        private void label3_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expense Obj = new Expense();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewExpense Obj = new ViewExpense();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void deleteinc_Click(object sender, EventArgs e)
        {
            if (IncomeDGV.SelectedRows.Count > 0)
            {
                int selectedIncomeId = (int)IncomeDGV.SelectedRows[0].Cells["IncId"].Value;
                DeleteIncome(selectedIncomeId);
            }
            else
            {
                MessageBox.Show("Please select an Income to delete.");
            }
        }
        private void DeleteIncome(int incomeId)
        {
            try
            {
                Con.Open();

                string deleteQuery = "DELETE FROM Income_Tbl WHERE IncId = @IncomeId";
                SqlCommand cmd = new SqlCommand(deleteQuery, Con);
                cmd.Parameters.AddWithValue("@IncomeId", incomeId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Income deleted successfully.");
                    // Refresh the DataGridView after deleting the expense
                    DisplayIncomes();
                }
                else
                {
                    MessageBox.Show("No Income found with the given ID.");
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                Con.Close();
            }

        }
    }
}
