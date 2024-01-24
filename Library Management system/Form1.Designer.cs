namespace Library_Management_system
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            LBfindbookid = new Label();
            TXBfindbookid = new TextBox();
            LBoutputbookname = new Label();
            BTNfindbook = new Button();
            BTNadmin = new Button();
            BTNloginSignUp = new Button();
            LBloggedIn = new Label();
            BTNreserve = new Button();
            LBreserveable = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            LBUsername = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LBfindbookid
            // 
            LBfindbookid.AutoSize = true;
            LBfindbookid.BackColor = Color.Transparent;
            LBfindbookid.Font = new Font("Segoe UI", 10F);
            LBfindbookid.ForeColor = SystemColors.ButtonHighlight;
            LBfindbookid.Location = new Point(60, 55);
            LBfindbookid.Margin = new Padding(4, 0, 4, 0);
            LBfindbookid.Name = "LBfindbookid";
            LBfindbookid.Size = new Size(168, 28);
            LBfindbookid.TabIndex = 6;
            LBfindbookid.Text = "ID of book to find";
            LBfindbookid.Click += LBfindbookid_Click;
            // 
            // TXBfindbookid
            // 
            TXBfindbookid.BackColor = Color.FromArgb(0, 192, 192);
            TXBfindbookid.ForeColor = SystemColors.ButtonHighlight;
            TXBfindbookid.Location = new Point(511, 91);
            TXBfindbookid.Margin = new Padding(4);
            TXBfindbookid.Name = "TXBfindbookid";
            TXBfindbookid.Size = new Size(155, 31);
            TXBfindbookid.TabIndex = 7;
            // 
            // LBoutputbookname
            // 
            LBoutputbookname.AutoSize = true;
            LBoutputbookname.BackColor = Color.Transparent;
            LBoutputbookname.Font = new Font("Segoe UI", 10F);
            LBoutputbookname.ForeColor = SystemColors.ButtonHighlight;
            LBoutputbookname.Location = new Point(267, 122);
            LBoutputbookname.Margin = new Padding(4, 0, 4, 0);
            LBoutputbookname.Name = "LBoutputbookname";
            LBoutputbookname.Size = new Size(118, 28);
            LBoutputbookname.TabIndex = 8;
            LBoutputbookname.Text = "Book Name:";
            // 
            // BTNfindbook
            // 
            BTNfindbook.BackColor = Color.FromArgb(0, 192, 192);
            BTNfindbook.FlatAppearance.BorderSize = 0;
            BTNfindbook.FlatStyle = FlatStyle.Flat;
            BTNfindbook.ForeColor = SystemColors.ButtonHighlight;
            BTNfindbook.Image = (Image)resources.GetObject("BTNfindbook.Image");
            BTNfindbook.Location = new Point(334, 150);
            BTNfindbook.Margin = new Padding(4);
            BTNfindbook.Name = "BTNfindbook";
            BTNfindbook.Padding = new Padding(10, 0, 0, 0);
            BTNfindbook.Size = new Size(118, 36);
            BTNfindbook.TabIndex = 9;
            BTNfindbook.Text = "Find";
            BTNfindbook.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNfindbook.UseVisualStyleBackColor = true;
            BTNfindbook.Click += BTNfindbook_Click;
            // 
            // BTNadmin
            // 
            BTNadmin.Location = new Point(781, 452);
            BTNadmin.Margin = new Padding(4);
            BTNadmin.Name = "BTNadmin";
            BTNadmin.Size = new Size(118, 36);
            BTNadmin.TabIndex = 10;
            BTNadmin.Text = "Admin";
            BTNadmin.UseVisualStyleBackColor = true;
            BTNadmin.Click += button1_Click;
            // 
            // BTNloginSignUp
            // 
            BTNloginSignUp.BackColor = Color.FromArgb(0, 192, 192);
            BTNloginSignUp.FlatAppearance.BorderSize = 0;
            BTNloginSignUp.FlatStyle = FlatStyle.Flat;
            BTNloginSignUp.Font = new Font("Segoe UI", 12F);
            BTNloginSignUp.ForeColor = SystemColors.ButtonHighlight;
            BTNloginSignUp.Location = new Point(148, 206);
            BTNloginSignUp.Margin = new Padding(4);
            BTNloginSignUp.Name = "BTNloginSignUp";
            BTNloginSignUp.Size = new Size(201, 66);
            BTNloginSignUp.TabIndex = 11;
            BTNloginSignUp.Text = "Login / Sign up";
            BTNloginSignUp.UseVisualStyleBackColor = false;
            BTNloginSignUp.Click += BTNloginSignUp_Click;
            // 
            // LBloggedIn
            // 
            LBloggedIn.AutoSize = true;
            LBloggedIn.Location = new Point(781, 62);
            LBloggedIn.Margin = new Padding(4, 0, 4, 0);
            LBloggedIn.Name = "LBloggedIn";
            LBloggedIn.Size = new Size(0, 25);
            LBloggedIn.TabIndex = 12;
            // 
            // BTNreserve
            // 
            BTNreserve.BackColor = Color.FromArgb(0, 192, 192);
            BTNreserve.FlatAppearance.BorderSize = 0;
            BTNreserve.FlatStyle = FlatStyle.Flat;
            BTNreserve.Font = new Font("Segoe UI", 10F);
            BTNreserve.ForeColor = SystemColors.ButtonHighlight;
            BTNreserve.Location = new Point(426, 216);
            BTNreserve.Name = "BTNreserve";
            BTNreserve.Size = new Size(112, 34);
            BTNreserve.TabIndex = 13;
            BTNreserve.Text = "Reserve";
            BTNreserve.UseVisualStyleBackColor = false;
            BTNreserve.Click += button1_Click_1;
            // 
            // LBreserveable
            // 
            LBreserveable.BackColor = Color.Transparent;
            LBreserveable.ForeColor = SystemColors.ButtonHighlight;
            LBreserveable.Location = new Point(-41, 265);
            LBreserveable.Name = "LBreserveable";
            LBreserveable.Size = new Size(517, 48);
            LBreserveable.TabIndex = 14;
            LBreserveable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(LBreserveable);
            panel1.Controls.Add(LBfindbookid);
            panel1.Controls.Add(LBoutputbookname);
            panel1.Location = new Point(258, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 329);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(LBUsername);
            panel2.Location = new Point(770, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 68);
            panel2.TabIndex = 16;
            // 
            // LBUsername
            // 
            LBUsername.BackColor = Color.Transparent;
            LBUsername.Font = new Font("Segoe UI", 10F);
            LBUsername.ForeColor = SystemColors.ButtonHighlight;
            LBUsername.Image = (Image)resources.GetObject("LBUsername.Image");
            LBUsername.ImageAlign = ContentAlignment.MiddleLeft;
            LBUsername.Location = new Point(13, 19);
            LBUsername.Margin = new Padding(4, 0, 4, 0);
            LBUsername.Name = "LBUsername";
            LBUsername.Size = new Size(172, 28);
            LBUsername.TabIndex = 9;
            LBUsername.Text = "Username";
            LBUsername.TextAlign = ContentAlignment.MiddleCenter;
            LBUsername.UseCompatibleTextRendering = true;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 562);
            Controls.Add(BTNloginSignUp);
            Controls.Add(BTNreserve);
            Controls.Add(LBloggedIn);
            Controls.Add(BTNadmin);
            Controls.Add(BTNfindbook);
            Controls.Add(TXBfindbookid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Window";
            Text = "Library Application";
            Load += Window_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LBfindbookid;
        private TextBox TXBfindbookid;
        private Label LBoutputbookname;
        private Button BTNfindbook;
        private Button BTNadmin;
        private Button BTNloginSignUp;
        private Label LBloggedIn;
        private Button BTNreserve;
        private Label LBreserveable;
        private Panel panel1;
        private Panel panel2;
        private Label LBUsername;
    }
}
