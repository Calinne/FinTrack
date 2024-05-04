namespace FinTrack.Expensesform
{
    partial class Expenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            savpagebtn = new Button();
            expagebtn = new Button();
            incomepagebtn = new Button();
            overviewbtn = new Button();
            expenseslabel = new Label();
            date = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            category = new Label();
            okaybtn = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // savpagebtn
            // 
            savpagebtn.AutoSize = true;
            savpagebtn.Location = new Point(355, 47);
            savpagebtn.Name = "savpagebtn";
            savpagebtn.Size = new Size(97, 37);
            savpagebtn.TabIndex = 7;
            savpagebtn.Text = "SAVINGS";
            savpagebtn.UseVisualStyleBackColor = true;
            // 
            // expagebtn
            // 
            expagebtn.AutoSize = true;
            expagebtn.Location = new Point(261, 47);
            expagebtn.Name = "expagebtn";
            expagebtn.Size = new Size(97, 37);
            expagebtn.TabIndex = 6;
            expagebtn.Text = "EXPENSES";
            expagebtn.UseVisualStyleBackColor = true;
            // 
            // incomepagebtn
            // 
            incomepagebtn.AutoSize = true;
            incomepagebtn.Location = new Point(169, 47);
            incomepagebtn.Name = "incomepagebtn";
            incomepagebtn.Size = new Size(97, 37);
            incomepagebtn.TabIndex = 5;
            incomepagebtn.Text = "INCOME";
            incomepagebtn.UseVisualStyleBackColor = true;
            // 
            // overviewbtn
            // 
            overviewbtn.AutoSize = true;
            overviewbtn.Location = new Point(75, 47);
            overviewbtn.Name = "overviewbtn";
            overviewbtn.Size = new Size(97, 37);
            overviewbtn.TabIndex = 4;
            overviewbtn.Text = "OVERVIEW";
            overviewbtn.UseVisualStyleBackColor = true;
            // 
            // expenseslabel
            // 
            expenseslabel.AutoSize = true;
            expenseslabel.Location = new Point(75, 129);
            expenseslabel.Name = "expenseslabel";
            expenseslabel.Size = new Size(77, 20);
            expenseslabel.TabIndex = 8;
            expenseslabel.Text = "EXPENSES";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(75, 378);
            date.Name = "date";
            date.Size = new Size(45, 20);
            date.TabIndex = 13;
            date.Text = "DATE";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(202, 373);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(261, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 28);
            comboBox1.TabIndex = 11;
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(75, 252);
            category.Name = "category";
            category.Size = new Size(81, 20);
            category.TabIndex = 10;
            category.Text = "CATEGORY";
            // 
            // okaybtn
            // 
            okaybtn.Location = new Point(430, 480);
            okaybtn.Name = "okaybtn";
            okaybtn.Size = new Size(43, 29);
            okaybtn.TabIndex = 14;
            okaybtn.Text = "OK";
            okaybtn.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(100, 164);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(97, 27);
            numericUpDown1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 166);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 17;
            label1.Text = "€";
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 544);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(okaybtn);
            Controls.Add(date);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(category);
            Controls.Add(expenseslabel);
            Controls.Add(savpagebtn);
            Controls.Add(expagebtn);
            Controls.Add(incomepagebtn);
            Controls.Add(overviewbtn);
            Name = "Expenses";
            Text = "Expenses";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button savpagebtn;
        private Button expagebtn;
        private Button incomepagebtn;
        private Button overviewbtn;
        private Label expenseslabel;
        private Label date;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label category;
        private Button okaybtn;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}