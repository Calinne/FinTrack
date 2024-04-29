namespace FinTrack.Incomeform
{
    partial class Income
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
            overviewbtn = new Button();
            incomepagebtn = new Button();
            expagebtn = new Button();
            savpagebtn = new Button();
            mymonthlyincome = new Label();
            category = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            date = new Label();
            okaybtn = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // overviewbtn
            // 
            overviewbtn.AutoSize = true;
            overviewbtn.Location = new Point(99, 38);
            overviewbtn.Name = "overviewbtn";
            overviewbtn.Size = new Size(97, 37);
            overviewbtn.TabIndex = 0;
            overviewbtn.Text = "OVERVIEW";
            overviewbtn.UseVisualStyleBackColor = true;
            // 
            // incomepagebtn
            // 
            incomepagebtn.AutoSize = true;
            incomepagebtn.Location = new Point(193, 38);
            incomepagebtn.Name = "incomepagebtn";
            incomepagebtn.Size = new Size(97, 37);
            incomepagebtn.TabIndex = 1;
            incomepagebtn.Text = "INCOME";
            incomepagebtn.UseVisualStyleBackColor = true;
            // 
            // expagebtn
            // 
            expagebtn.AutoSize = true;
            expagebtn.Location = new Point(285, 38);
            expagebtn.Name = "expagebtn";
            expagebtn.Size = new Size(97, 37);
            expagebtn.TabIndex = 2;
            expagebtn.Text = "EXPENSES";
            expagebtn.UseVisualStyleBackColor = true;
            // 
            // savpagebtn
            // 
            savpagebtn.AutoSize = true;
            savpagebtn.Location = new Point(379, 38);
            savpagebtn.Name = "savpagebtn";
            savpagebtn.Size = new Size(97, 37);
            savpagebtn.TabIndex = 3;
            savpagebtn.Text = "SAVINGS";
            savpagebtn.UseVisualStyleBackColor = true;
            // 
            // mymonthlyincome
            // 
            mymonthlyincome.AutoSize = true;
            mymonthlyincome.Location = new Point(99, 116);
            mymonthlyincome.Name = "mymonthlyincome";
            mymonthlyincome.Size = new Size(162, 20);
            mymonthlyincome.TabIndex = 4;
            mymonthlyincome.Text = "MY MONTHLY INCOME";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(99, 275);
            category.Name = "category";
            category.Size = new Size(81, 20);
            category.TabIndex = 6;
            category.Text = "CATEGORY";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(285, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 28);
            comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(226, 396);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(99, 401);
            date.Name = "date";
            date.Size = new Size(45, 20);
            date.TabIndex = 9;
            date.Text = "DATE";
            // 
            // okaybtn
            // 
            okaybtn.Location = new Point(452, 523);
            okaybtn.Name = "okaybtn";
            okaybtn.Size = new Size(43, 29);
            okaybtn.TabIndex = 10;
            okaybtn.Text = "OK";
            okaybtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 161);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 19;
            label1.Text = "€";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(125, 159);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(97, 27);
            numericUpDown1.TabIndex = 18;
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 567);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(okaybtn);
            Controls.Add(date);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(category);
            Controls.Add(mymonthlyincome);
            Controls.Add(savpagebtn);
            Controls.Add(expagebtn);
            Controls.Add(incomepagebtn);
            Controls.Add(overviewbtn);
            Name = "Income";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button overviewbtn;
        private Button incomepagebtn;
        private Button expagebtn;
        private Button savpagebtn;
        private Label mymonthlyincome;
        private Label category;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label date;
        private Button okaybtn;
        private Label label1;
        private NumericUpDown numericUpDown1;
    }
}