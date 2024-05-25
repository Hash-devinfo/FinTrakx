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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetToInc();
            GetToExp();
            GetNumInc();
            GetNumExp();
            GetIncDate();
            GetExpDate();
            GetMaxInc();
            GetMaxExp();
            GetMinInc();
            GetMinExp();
            GetBalance();
            GetMaxExpCat();
            GetMaxIncCat();
        }

        private void IncLbl_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {
            ViewExpense Obj = new ViewExpense();
            Obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\fintrax\\FinTrax\\FinTraxDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        int Inc, Exp;
        private void GetToInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from Income_Tbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Inc = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotalIncLbl.Text = "Rs= " + dt.Rows[0][0].ToString();
                Con.Close();
            } 
            catch(Exception ex)
            {
                Con.Close() ;
            }
          
        }
        private void GetNumInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Income_Tbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumIncLbl.Text = "Total= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
             catch( Exception ex)
              {
                 Con.Close() ;
              } 
            
           
        }
        private void GetIncDate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncDate) from Income_Tbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateIncLbl.Text = "Date= " + dt.Rows[0][0].ToString();
                LastInclbl.Text = "Date= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
             catch(Exception ex)
            {
                Con.Close() ;
            }  

           
        }
        private void GetMaxInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncAmt) from Income_Tbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxInxLbl.Text = "Rs= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
             catch(Exception ex)
            {
                Con.Close() ;
            }   
            
        }
        private void GetMinInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Min(IncAmt) from Income_Tbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinIncLbl.Text = "Rs= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch( Exception ex)
            {
                Con.Close() ;
            }    
           
        }
        private void GetMaxIncCat()
        {
            try
            {
                Con.Open();
                String InnerQuery = "select Max(IncAmt) from Income_Tbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select IncCat from Income_Tbl where IncAmt='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestIncLbl.Text = "Name= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
             catch(Exception ex)
            {
                Con.Close();
            }  
            
            
        }
        private void GetToExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Exp = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotalExpLbl.Text = "Rs= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch(Exception ex)
            {
                Con.Close();
            }   
            
        }
        private void GetNumExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumExpLbl.Text = "Total= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch( Exception ex)
            {
                Con.Close();
            } 
        }
        private void GetExpDate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpDate) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ExpDateLbl.Text = "Date= " + dt.Rows[0][0].ToString();
                lastExplbl.Text = "Date= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch(Exception ex)
            {
                Con.Close();
            }  
        }
        private void GetMaxExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxExpLbl.Text = "Rs= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch ( Exception ex )
            {
                Con.Close();
            }
               
       
        }
        private void GetMinExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinExplbl.Text = "Rs= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch( Exception ex )
            {
                Con.Close();
            }   
        }
       
        private void GetMaxExpCat()
        {
            try
            {
                Con.Open();
                String InnerQuery = "select Max(ExpAmt) from ExpenseTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select ExpCat from ExpenseTbl where ExpAmt='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestExplbl.Text = "Name= " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch(Exception ex)
            {
                Con.Close();
            }    

        }
        private void GetBalance()
        {

            Double Bal = Inc - Exp;
            BalanceLbl.Text = "Rs= " + Bal;
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void LastInclbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
