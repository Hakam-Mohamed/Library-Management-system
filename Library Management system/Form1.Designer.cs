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
            LBfindbookid = new Label();
            TXBfindbookid = new TextBox();
            LBoutputbookname = new Label();
            BTNfindbook = new Button();
            BTNadmin = new Button();
            SuspendLayout();
            // 
            // LBfindbookid
            // 
            LBfindbookid.AutoSize = true;
            LBfindbookid.Location = new Point(44, 43);
            LBfindbookid.Margin = new Padding(4, 0, 4, 0);
            LBfindbookid.Name = "LBfindbookid";
            LBfindbookid.Size = new Size(157, 25);
            LBfindbookid.TabIndex = 6;
            LBfindbookid.Text = "ID of book to find";
            // 
            // TXBfindbookid
            // 
            TXBfindbookid.Location = new Point(44, 100);
            TXBfindbookid.Margin = new Padding(4);
            TXBfindbookid.Name = "TXBfindbookid";
            TXBfindbookid.Size = new Size(155, 31);
            TXBfindbookid.TabIndex = 7;
            // 
            // LBoutputbookname
            // 
            LBoutputbookname.AutoSize = true;
            LBoutputbookname.Location = new Point(297, 174);
            LBoutputbookname.Margin = new Padding(4, 0, 4, 0);
            LBoutputbookname.Name = "LBoutputbookname";
            LBoutputbookname.Size = new Size(109, 25);
            LBoutputbookname.TabIndex = 8;
            LBoutputbookname.Text = "Book Name:";
            // 
            // BTNfindbook
            // 
            BTNfindbook.Location = new Point(44, 168);
            BTNfindbook.Margin = new Padding(4);
            BTNfindbook.Name = "BTNfindbook";
            BTNfindbook.Size = new Size(118, 36);
            BTNfindbook.TabIndex = 9;
            BTNfindbook.Text = "Find";
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
            // Window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(BTNadmin);
            Controls.Add(BTNfindbook);
            Controls.Add(LBoutputbookname);
            Controls.Add(TXBfindbookid);
            Controls.Add(LBfindbookid);
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
    }
}
