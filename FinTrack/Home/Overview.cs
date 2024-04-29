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
            MessageBox.Show("Expenses Button Clicked");
            // Implement the opening of the Expenses Form or other related functionality
        }

        private void Savingsbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Savings Button Clicked");
            // Implement the opening of the Savings Form or other related functionality
        }

        private void Historybtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("History Button Clicked");
            // Implement the opening of the History Form or other related functionality
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Icon Clicked");
            // Implement the opening of the Settings Form or other related functionality
        }
    }
}
