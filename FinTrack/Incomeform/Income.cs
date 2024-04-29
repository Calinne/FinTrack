using System;
using System.Windows.Forms;

namespace FinTrack.Incomeform
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();

            // Attach event handlers to the buttons
            overviewbtn.Click += Overviewbtn_Click;
            incomepagebtn.Click += Incomepagebtn_Click;
            expagebtn.Click += Expagebtn_Click;
            savpagebtn.Click += Savpagebtn_Click;
            okaybtn.Click += Okaybtn_Click;

            // Initialize the ComboBox with default values
            comboBox1.Items.AddRange(new string[] { "Salary", "Investment", "Other" });
        }

        private void Overviewbtn_Click(object sender, EventArgs e)
        {
            // Open Overview Form
            var overviewForm = new FinTrack.Home.Overview();
            overviewForm.Show();
        }

        private void Incomepagebtn_Click(object sender, EventArgs e)
        {
            // Here, since we're already on the Income page, you might want to refresh the form or do nothing
            // If needed, you can implement the logic here
        }

        private void Expagebtn_Click(object sender, EventArgs e)
        {
            // Open Expenses Form
           /* ExpensesForm expForm = new ExpensesForm(); // Assuming you have a form named ExpensesForm
            expForm.Show();*/
        }

        private void Savpagebtn_Click(object sender, EventArgs e)
        {
            // Open Savings Form
           /* SavingsForm savForm = new SavingsForm(); // Assuming you have a form named SavingsForm
            savForm.Show();*/
        }

        private void Okaybtn_Click(object sender, EventArgs e)
        {
            // Logic to save data to database
            // For now, this is commented out as per your request

            /* 
            string category = comboBox1.SelectedItem.ToString();
            decimal amount;
            if (decimal.TryParse(textBox1.Text, out amount))
            {
                // Create an object to represent this income entry
                var incomeEntry = new IncomeEntry
                {
                    Amount = amount,
                    Category = category,
                    Date = dateTimePicker1.Value
                };

                // Save to database (this is pseudocode; replace with your actual database code)
                // Database.SaveIncome(incomeEntry);
            }
            else
            {
                MessageBox.Show("Please enter a valid income amount.");
            }
            */

            // Code to handle adding a new income category if it does not already exist in comboBox1
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Items.Add(comboBox1.Text);
                // Here, you would save the new category to a database or application settings
                // so it persists across sessions for the specific user
            }
        }

        // Add the rest of your methods and any additional code here
    }
}
