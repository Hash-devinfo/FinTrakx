using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace FinTrax.Tests
{
    [TestClass]
    public class UsersTests
    {
        private Users _users;

        [TestInitialize]
        public void Setup()
        {
            _users = new Users();
        }

        [TestMethod]
        public void AddBtn_Click_WithMissingInformation_ShowMessageBox()
        {
            // Arrange
            _users.UnameTb.Text = "";
            _users.PhoneTb.Text = "";
            _users.AddressTb.Text = "";

            // Act
            _users.AddBtn_Click(null, null);

            // Assert
            Assert.IsTrue(_users.MessageBoxShown);
        }

        [TestMethod]
        public void AddBtn_Click_WithValidInformation_AddsUser()
        {
            // Arrange
            _users.UnameTb.Text = "John";
            _users.PhoneTb.Text = "1234567890";
            _users.AddressTb.Text = "Some Address";

            // Act
            _users.AddBtn_Click(null, null);

            // Assert
            Assert.IsTrue(_users.UserAdded);
        }
    }

    public class Users : Form
    {
        public TextBox UnameTb { get; set; }
        public TextBox PhoneTb { get; set; }
        public TextBox AddressTb { get; set; }
        public bool MessageBoxShown { get; private set; }
        public bool UserAdded { get; private set; }

        public Users()
        {
            // Initialize UI elements
            UnameTb = new TextBox();
            PhoneTb = new TextBox();
            AddressTb = new TextBox();
        }

        public void AddBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                // Show message box for missing information
                MessageBoxShown = true;
            }
            else
            {
                // Add user logic
                UserAdded = true;
            }
        }
    }
}
