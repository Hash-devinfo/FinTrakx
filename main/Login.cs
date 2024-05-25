
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FinTrax
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\fintrax\FinTrax\FinTraxDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public static string User;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Both UserName and Password");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from UserTbl where UName= '" + UnameTb.Text + "' and UPass='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = UnameTb.Text;
                    Dashboard Obj = new Dashboard();
                    Obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
                Con.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
