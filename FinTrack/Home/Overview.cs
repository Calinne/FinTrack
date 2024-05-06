using FinTrack.NewFolder;
using System;
using System.Windows.Forms;

namespace FinTrack.Home
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();

            // Adding event handlers for buttons and settings icon
            incomebtn.Click += Incomebtn_Click;
            expensesbtn.Click += Expensesbtn_Click;
            savingsbtn.Click += Savingsbtn_Click;
            historybtn.Click += Historybtn_Click;
            settings.Click += Settings_Click;
        }

        private void Incomebtn_Click(object sender, EventArgs e)
        {
            // Open Income Form, adjusted for correct namespace
            FinTrack.Incomeform.Income incomeForm = new FinTrack.Incomeform.Income();
            incomeForm.Show();
        }

        private void Expensesbtn_Click(object sender, EventArgs e)
        {
            // Open Expenses Form, adjusted for the correct namespace
            FinTrack.Expenses.Expenses expensesForm = new FinTrack.Expenses.Expenses();
            expensesForm.Show();
        }

        private void Savingsbtn_Click(object sender, EventArgs e)
        {
            // Implement the opening of the Savings Form or other related functionality
            MessageBox.Show("Savings Button Clicked");
        }

        private void Historybtn_Click(object sender, EventArgs e)
        {
            // Implement the opening of the History Form or other related functionality
            MessageBox.Show("History Button Clicked");
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            // Open Settings Form, adjusted for correct namespace
            FinTrack.NewFolder.Settings settingsForm = new FinTrack.NewFolder.Settings();
            settingsForm.Show();
        }
    }
}
