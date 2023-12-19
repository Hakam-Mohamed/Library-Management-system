namespace Library_Management_system
{
    partial class Login
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
            LBUserName = new Label();
            LBpassword = new Label();
            TXBUserName = new TextBox();
            TXBpassword = new TextBox();
            BTNlogin = new Button();
            BTNsignUp = new Button();
            SuspendLayout();
            // 
            // LBUserName
            // 
            LBUserName.AutoSize = true;
            LBUserName.Location = new Point(50, 113);
            LBUserName.Margin = new Padding(4, 0, 4, 0);
            LBUserName.Name = "LBUserName";
            LBUserName.Size = new Size(99, 25);
            LBUserName.TabIndex = 7;
            LBUserName.Text = "User Name";
            // 
            // LBpassword
            // 
            LBpassword.AutoSize = true;
            LBpassword.Location = new Point(313, 113);
            LBpassword.Margin = new Padding(4, 0, 4, 0);
            LBpassword.Name = "LBpassword";
            LBpassword.Size = new Size(87, 25);
            LBpassword.TabIndex = 8;
            LBpassword.Text = "Password";
            // 
            // TXBUserName
            // 
            TXBUserName.Location = new Point(22, 168);
            TXBUserName.Margin = new Padding(4);
            TXBUserName.Name = "TXBUserName";
            TXBUserName.Size = new Size(169, 31);
            TXBUserName.TabIndex = 9;
            // 
            // TXBpassword
            // 
            TXBpassword.Location = new Point(280, 168);
            TXBpassword.Margin = new Padding(4);
            TXBpassword.Name = "TXBpassword";
            TXBpassword.Size = new Size(155, 31);
            TXBpassword.TabIndex = 10;
            // 
            // BTNlogin
            // 
            BTNlogin.Location = new Point(173, 238);
            BTNlogin.Margin = new Padding(4);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(118, 36);
            BTNlogin.TabIndex = 11;
            BTNlogin.Text = "Login";
            BTNlogin.UseVisualStyleBackColor = true;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // BTNsignUp
            // 
            BTNsignUp.Location = new Point(173, 304);
            BTNsignUp.Margin = new Padding(4);
            BTNsignUp.Name = "BTNsignUp";
            BTNsignUp.Size = new Size(118, 36);
            BTNsignUp.TabIndex = 16;
            BTNsignUp.Text = "Sign up";
            BTNsignUp.UseVisualStyleBackColor = true;
            BTNsignUp.Click += BTNsignUp_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 537);
            Controls.Add(BTNsignUp);
            Controls.Add(BTNlogin);
            Controls.Add(TXBpassword);
            Controls.Add(TXBUserName);
            Controls.Add(LBpassword);
            Controls.Add(LBUserName);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBUserName;
        private Label LBpassword;
        private TextBox TXBUserName;
        private TextBox TXBpassword;
        private Button BTNlogin;
        private Button BTNsignUp;
    }
}