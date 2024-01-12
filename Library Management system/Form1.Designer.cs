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
            SuspendLayout();
            // 
            // LBfindbookid
            // 
            LBfindbookid.AutoSize = true;
            LBfindbookid.BackColor = Color.FromArgb(0, 192, 192);
            LBfindbookid.Font = new Font("Segoe UI", 10F);
            LBfindbookid.ForeColor = SystemColors.ButtonHighlight;
            LBfindbookid.Location = new Point(317, 91);
            LBfindbookid.Margin = new Padding(4, 0, 4, 0);
            LBfindbookid.Name = "LBfindbookid";
            LBfindbookid.Size = new Size(168, 28);
            LBfindbookid.TabIndex = 6;
            LBfindbookid.Text = "ID of book to find";
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
            LBoutputbookname.BackColor = Color.FromArgb(0, 192, 192);
            LBoutputbookname.Font = new Font("Segoe UI", 10F);
            LBoutputbookname.ForeColor = SystemColors.ButtonHighlight;
            LBoutputbookname.Location = new Point(542, 155);
            LBoutputbookname.Margin = new Padding(4, 0, 4, 0);
            LBoutputbookname.Name = "LBoutputbookname";
            LBoutputbookname.Size = new Size(118, 28);
            LBoutputbookname.TabIndex = 8;
            LBoutputbookname.Text = "Book Name:";
            // 
            // BTNfindbook
            // 
            BTNfindbook.BackColor = Color.FromArgb(0, 192, 192);
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
            BTNloginSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTNloginSignUp.BackColor = Color.White;
            BTNloginSignUp.FlatStyle = FlatStyle.Flat;
            BTNloginSignUp.Location = new Point(691, 72);
            BTNloginSignUp.Margin = new Padding(4);
            BTNloginSignUp.Name = "BTNloginSignUp";
            BTNloginSignUp.Size = new Size(153, 44);
            BTNloginSignUp.TabIndex = 11;
            BTNloginSignUp.Text = "Login / Sign up ";
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
            LBreserveable.Location = new Point(138, 303);
            LBreserveable.Name = "LBreserveable";
            LBreserveable.Size = new Size(737, 48);
            LBreserveable.TabIndex = 14;
            LBreserveable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Location = new Point(270, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 254);
            panel1.TabIndex = 15;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 562);
            Controls.Add(LBreserveable);
            Controls.Add(BTNreserve);
            Controls.Add(LBloggedIn);
            Controls.Add(BTNloginSignUp);
            Controls.Add(BTNadmin);
            Controls.Add(BTNfindbook);
            Controls.Add(LBoutputbookname);
            Controls.Add(TXBfindbookid);
            Controls.Add(LBfindbookid);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Window";
            Text = "Library Application";
            Load += Window_Load;
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
    }
}
