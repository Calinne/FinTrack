namespace FinTrack.NewFolder
{
    partial class Settings
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
            label1 = new Label();
            username = new Label();
            button1 = new Button();
            button2 = new Button();
            updateprofilebtn = new Button();
            deleteprofilebtn = new Button();
            logoutbtn = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 28);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "SETTINGS && SERVICES";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(73, 96);
            username.Name = "username";
            username.Size = new Size(49, 20);
            username.TabIndex = 1;
            username.Text = "Name";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Image = Properties.Resources.arrowleft;
            button1.Location = new Point(73, 106);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(22, 24);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "arrow back";
            button2.UseVisualStyleBackColor = true;
            // 
            // updateprofilebtn
            // 
            updateprofilebtn.Location = new Point(85, 210);
            updateprofilebtn.Name = "updateprofilebtn";
            updateprofilebtn.Size = new Size(140, 29);
            updateprofilebtn.TabIndex = 4;
            updateprofilebtn.Text = "UPDATE PROFILE";
            updateprofilebtn.UseVisualStyleBackColor = true;
            // 
            // deleteprofilebtn
            // 
            deleteprofilebtn.Location = new Point(85, 254);
            deleteprofilebtn.Name = "deleteprofilebtn";
            deleteprofilebtn.Size = new Size(140, 29);
            deleteprofilebtn.TabIndex = 5;
            deleteprofilebtn.Text = "DELETE PROFILE";
            deleteprofilebtn.UseVisualStyleBackColor = true;
            // 
            // logoutbtn
            // 
            logoutbtn.Location = new Point(85, 298);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(140, 29);
            logoutbtn.TabIndex = 6;
            logoutbtn.Text = "LOG OUT";
            logoutbtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(85, 430);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "regulations";
            button3.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 484);
            Controls.Add(button3);
            Controls.Add(logoutbtn);
            Controls.Add(deleteprofilebtn);
            Controls.Add(updateprofilebtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label username; // Updated identifier
        private Button button1;
        private Button button2;
        private Button updateprofilebtn;
        private Button deleteprofilebtn;
        private Button logoutbtn;
        private Button button3;
    }
}
