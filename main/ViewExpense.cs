using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinTrax
{
    public partial class ViewExpense : Form
    {
        public ViewExpense()
        {
            InitializeComponent();
            DisplayExpense();

        }

        private void DisplayExpense()
        {



            Con.Open();

            String Query = "Select * from ExpenseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\fintrax\\FinTrax\\FinTraxDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void deleteexp_Click(object sender, EventArgs e)
        {
            if (ExpenseDGV.SelectedRows.Count > 0)
            {
                int selectedExpenseId = (int)ExpenseDGV.SelectedRows[0].Cells["ExpId"].Value;
                DeleteExpense(selectedExpenseId);
            }
            else
            {
                MessageBox.Show("Please select an expense to delete.");
            }
        }
        private void DeleteExpense(int expenseId)
        {
            try
            {
                Con.Open();

                string deleteQuery = "DELETE FROM ExpenseTbl WHERE ExpId = @ExpenseId";
                SqlCommand cmd = new SqlCommand(deleteQuery, Con);
                cmd.Parameters.AddWithValue("@ExpenseId", expenseId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Expense deleted successfully.");
                    // Refresh the DataGridView after deleting the expense
                    DisplayExpense();
                }
                else
                {
                    MessageBox.Show("No expense found with the given ID.");
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                Con.Close();
            }

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

        private void label5_Click(object sender, EventArgs e)
        {
            ViewIncome Obj = new ViewIncome();
            Obj.Show();
            this.Hide();
        }
    }
}
