namespace FinTrack.Home
{
    partial class Overview
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
            incomebtn = new Button();
            expensesbtn = new Button();
            savingsbtn = new Button();
            historybtn = new Button();
            userName = new Label();
            pictureBox1 = new PictureBox();
            welcometxt = new Label();
            myoverviewtxt = new Label();
            label1 = new Label();
            settingsbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // incomebtn
            // 
            incomebtn.Location = new Point(42, 289);
            incomebtn.Name = "incomebtn";
            incomebtn.Size = new Size(138, 77);
            incomebtn.TabIndex = 0;
            incomebtn.Text = "INCOME";
            incomebtn.UseVisualStyleBackColor = true;
            // 
            // expensesbtn
            // 
            expensesbtn.Location = new Point(42, 410);
            expensesbtn.Name = "expensesbtn";
            expensesbtn.Size = new Size(138, 77);
            expensesbtn.TabIndex = 1;
            expensesbtn.Text = "EXPENSES";
            expensesbtn.UseVisualStyleBackColor = true;
            // 
            // savingsbtn
            // 
            savingsbtn.Location = new Point(353, 289);
            savingsbtn.Name = "savingsbtn";
            savingsbtn.Size = new Size(138, 77);
            savingsbtn.TabIndex = 2;
            savingsbtn.Text = "SAVINGS";
            savingsbtn.UseVisualStyleBackColor = true;
            // 
            // historybtn
            // 
            historybtn.Location = new Point(353, 410);
            historybtn.Name = "historybtn";
            historybtn.Size = new Size(138, 77);
            historybtn.TabIndex = 3;
            historybtn.Text = "HISTORY";
            historybtn.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(189, 37);
            userName.Name = "userName";
            userName.Size = new Size(0, 20);
            userName.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(292, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 160);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // welcometxt
            // 
            welcometxt.AutoSize = true;
            welcometxt.Location = new Point(53, 38);
            welcometxt.Name = "welcometxt";
            welcometxt.Size = new Size(78, 20);
            welcometxt.TabIndex = 9;
            welcometxt.Text = "WELCOME";
            // 
            // myoverviewtxt
            // 
            myoverviewtxt.AutoSize = true;
            myoverviewtxt.Location = new Point(53, 95);
            myoverviewtxt.Name = "myoverviewtxt";
            myoverviewtxt.Size = new Size(106, 20);
            myoverviewtxt.TabIndex = 10;
            myoverviewtxt.Text = "MY OVERVIEW";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 37);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 11;
            label1.Text = "user";
            // 
            // settingsbtn
            // 
            settingsbtn.Location = new Point(383, 12);
            settingsbtn.Name = "settingsbtn";
            settingsbtn.Size = new Size(108, 46);
            settingsbtn.TabIndex = 12;
            settingsbtn.Text = "Settings";
            settingsbtn.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 508);
            Controls.Add(settingsbtn);
            Controls.Add(label1);
            Controls.Add(myoverviewtxt);
            Controls.Add(welcometxt);
            Controls.Add(pictureBox1);
            Controls.Add(userName);
            Controls.Add(historybtn);
            Controls.Add(savingsbtn);
            Controls.Add(expensesbtn);
            Controls.Add(incomebtn);
            Name = "Overview";
            Text = "Overview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button incomebtn;
        private Button expensesbtn;
        private Button savingsbtn;
        private Button historybtn;
        private Label userName;
        private PictureBox pictureBox1;
        private Label welcometxt;
        private Label myoverviewtxt;
        private Label label1;
        private Button settingsbtn;
    }
}