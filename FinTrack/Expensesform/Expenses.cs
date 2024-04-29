using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinTrack.Expensesform
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            PopulateCategories();
            AttachEventHandlers();
        }

        private void PopulateCategories()
        {
            // Populate your comboBox1 with categories
            // Example:
            comboBox1.Items.AddRange(new string[] { "Food", "Utilities", "Rent" });
            // Set default value if needed
            comboBox1.SelectedIndex = 0;
        }

        private void AttachEventHandlers()
        {
            // Attach the Click event handler to the okaybtn
            okaybtn.Click += Okaybtn_Click;

            // If you have functionality for other buttons, attach their event handlers similarly
            // overviewbtn.Click += Overviewbtn_Click;
            // ... and so on for other buttons
        }

        private void Okaybtn_Click(object sender, EventArgs e)
        {
            // Logic to handle the click event for okaybtn
            SaveExpense();
        }

        private void SaveExpense()
        {
            // Assuming you want to collect the selected category, date, and amount
            string selectedCategory = comboBox1.SelectedItem.ToString();
            DateTime selectedDate = dateTimePicker1.Value;
            decimal amount = numericUpDown1.Value; // Use Value property for NumericUpDown

            // You would then save this data to your database or process it as required
            // This is a placeholder for the save logic
            MessageBox.Show($"Category: {selectedCategory}\nDate: {selectedDate.ToShortDateString()}\nAmount: €{amount}", "Expense Saved");

            // After saving, you might want to reset the form or give feedback to the user
            // Reset the numericUpDown1 value or update the UI as needed
            numericUpDown1.Value = numericUpDown1.Minimum; // Reset to minimum or a default value
        }

        // Implement event handlers for other buttons if needed
        // For example, navigation to different forms/pages
        private void Overviewbtn_Click(object sender, EventArgs e)
        {
            // Code to navigate to the Overview page
        }

        // ... additional event handlers for savpagebtn, expagebtn, and incomepagebtn
    }
}
