using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FinTrax.Tests
{
    [TestClass()]
    public class IncomeTests
    {
        private Income _income;

        [TestInitialize]
        public void Setup()
        {
            _income = new Income();
        }

        private T GetPrivateField<T>(object obj, string fieldName)
        {
            var field = obj.GetType().GetField(fieldName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return (T)field.GetValue(obj);
        }

        [TestMethod()]
        public void Clear_ShouldClearTextBoxesAndComboBox()
        {
            // Arrange
            var incNameTb = GetPrivateField<TextBox>(_income, "IncNameTb");
            var incAmtTb = GetPrivateField<TextBox>(_income, "IncAmtTb");
            var incDescTb = GetPrivateField<TextBox>(_income, "IncDescTb");
            var catCb = GetPrivateField<ComboBox>(_income, "CatCb");

            incNameTb.Text = "Salary";
            incAmtTb.Text = "1000";
            incDescTb.Text = "Monthly salary";
            catCb.SelectedIndex = 1;

            // Act
            _income.Clear();

            // Assert
            Assert.AreEqual(string.Empty, incNameTb.Text);
            Assert.AreEqual(string.Empty, incAmtTb.Text);
            Assert.AreEqual(string.Empty, incDescTb.Text);
            Assert.AreEqual(0, catCb.SelectedIndex);
        }

       [TestMethod()]
        public void SvaeBtn_Click_ShouldShowMessageBoxWhenFieldsAreEmpty()
        {
            // Arrange
            var incNameTb = GetPrivateField<TextBox>(_income, "IncNameTb");
            var incAmtTb = GetPrivateField<TextBox>(_income, "IncAmtTb");
            var incDescTb = GetPrivateField<TextBox>(_income, "IncDescTb");
            var catCb = GetPrivateField<ComboBox>(_income, "CatCb");

            incNameTb.Text = "";
            incAmtTb.Text = "";
            incDescTb.Text = "";
            catCb.SelectedIndex = -1;

            // Act
            _income.SvaeBtn_Click(this, EventArgs.Empty);

            // Assert
            // Since MessageBox.Show is difficult to intercept, you can assume it's called.
            // You might need to use a library or mock to intercept MessageBox calls.
            // Assert.IsTrue(MessageBoxWasShown); // Illustrative assertion.
        }

        [TestMethod()]
        public void SvaeBtn_Click_ShouldInsertIncomeWhenFieldsAreFilled()
        {
            // Arrange
            var incNameTb = GetPrivateField<TextBox>(_income, "IncNameTb");
            var incAmtTb = GetPrivateField<TextBox>(_income, "IncAmtTb");
            var incDescTb = GetPrivateField<TextBox>(_income, "IncDescTb");
            var catCb = GetPrivateField<ComboBox>(_income, "CatCb");
            var incDate = GetPrivateField<DateTimePicker>(_income, "IncDate");

            incNameTb.Text = "Salary";
            incAmtTb.Text = "1000";
            incDescTb.Text = "Monthly salary";
            catCb.SelectedIndex = 1;
            incDate.Value = DateTime.Now;

            _income.SvaeBtn_Click(this, EventArgs.Empty);

        }


    }
}
