using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinTrax.Tests
{
    [TestClass]
    public class LoginTests
    {
        private Login _login;

        [TestInitialize]
        public void Setup()
        {
            _login = new Login();
        }

        [TestMethod]
        public void LoginBtn_Click_WithMissingInformation_ShowMessageBox()
        {
            // Arrange
            _login.UnameTb.Text = "";
            _login.PasswordTb.Text = "";

            // Act
            _login.LoginBtn_Click(null, null);

            // Assert
            Assert.IsTrue(_login.HasShownMessageBox);
        }

        [TestMethod]
        public void LoginBtn_Click_WithIncorrectCredentials_ShowMessageBox()
        {
            // Arrange
            _login.UnameTb.Text = "nonexistent_user";
            _login.PasswordTb.Text = "wrong_password";

            // Act
            _login.LoginBtn_Click(null, null);

            // Assert
            Assert.IsTrue(_login.HasShownIncorrectCredentialsMessageBox);
        }
    }

    public class Login : Form
    {
        public TextBox UnameTb { get; set; } = new TextBox();
        public TextBox PasswordTb { get; set; } = new TextBox();
        public bool HasShownMessageBox { get; private set; }
        public bool HasShownIncorrectCredentialsMessageBox { get; private set; }

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                // Show message box for missing information
                HasShownMessageBox = true;
            }
            else
            {
                // Simulate database check for user credentials
                if (UnameTb.Text == "correct_user" && PasswordTb.Text == "correct_password")
                {
                    // Do something when login is successful
                }
                else
                {
                    // Show message box for incorrect credentials
                    HasShownIncorrectCredentialsMessageBox = true;
                }
            }
        }
    }
}
