
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
            settingsbtn.Click += Settings_Click;
            settingsbtn.Click += Settings_Click; // Changed the event handler name here
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
            FinTrack.Expensesform.Expenses expensesForm = new FinTrack.Expensesform.Expenses();
            expensesForm.Show();
        }

        private void Savingsbtn_Click(object sender, EventArgs e)
        {
            // Implement the opening of the Savings Form or other related functionality
            MessageBox.Show("Savings Button Clicked");
        }

        private void Historybtn_Click(object sender, EventArgs e)
        {
             History historyForm = new History(); // Instantiate the History form
            historyForm.Show();
        }

        private void Settings_Click(object sender, EventArgs e) // Changed the method name here
        {
            // Open Settings Form, adjusted for correct namespace
            FinTrack.NewFolder.Settings settingsForm = new FinTrack.NewFolder.Settings();
            settingsForm.Show();
        }
    }
}
