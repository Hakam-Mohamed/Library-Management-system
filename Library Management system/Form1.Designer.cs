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
            TXBinputbookid = new TextBox();
            LBinputbookid = new Label();
            LBinputname = new Label();
            BTNadd = new Button();
            DTgrid = new DataGridView();
            TXBinputbookname = new TextBox();
            LBfindbookid = new Label();
            TXBfindbookid = new TextBox();
            LBoutputbookname = new Label();
            BTNfindbook = new Button();
            ((System.ComponentModel.ISupportInitialize)DTgrid).BeginInit();
            SuspendLayout();
            // 
            // TXBinputbookid
            // 
            TXBinputbookid.Location = new Point(40, 79);
            TXBinputbookid.Margin = new Padding(4);
            TXBinputbookid.Name = "TXBinputbookid";
            TXBinputbookid.Size = new Size(155, 31);
            TXBinputbookid.TabIndex = 0;
            // 
            // LBinputbookid
            // 
            LBinputbookid.AutoSize = true;
            LBinputbookid.Location = new Point(39, 24);
            LBinputbookid.Margin = new Padding(4, 0, 4, 0);
            LBinputbookid.Name = "LBinputbookid";
            LBinputbookid.Size = new Size(123, 25);
            LBinputbookid.TabIndex = 1;
            LBinputbookid.Text = "Input Book ID";
            // 
            // LBinputname
            // 
            LBinputname.AutoSize = true;
            LBinputname.Location = new Point(39, 146);
            LBinputname.Margin = new Padding(4, 0, 4, 0);
            LBinputname.Name = "LBinputname";
            LBinputname.Size = new Size(149, 25);
            LBinputname.TabIndex = 2;
            LBinputname.Text = "Input Book name";
            // 
            // BTNadd
            // 
            BTNadd.Location = new Point(40, 243);
            BTNadd.Margin = new Padding(4);
            BTNadd.Name = "BTNadd";
            BTNadd.Size = new Size(118, 36);
            BTNadd.TabIndex = 3;
            BTNadd.Text = "Add";
            BTNadd.UseVisualStyleBackColor = true;
            BTNadd.Click += BTNload_Click;
            // 
            // DTgrid
            // 
            DTgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTgrid.Location = new Point(284, 24);
            DTgrid.Name = "DTgrid";
            DTgrid.RowHeadersWidth = 62;
            DTgrid.Size = new Size(360, 225);
            DTgrid.TabIndex = 4;
            // 
            // TXBinputbookname
            // 
            TXBinputbookname.Location = new Point(40, 185);
            TXBinputbookname.Margin = new Padding(4);
            TXBinputbookname.Name = "TXBinputbookname";
            TXBinputbookname.Size = new Size(155, 31);
            TXBinputbookname.TabIndex = 5;
            // 
            // LBfindbookid
            // 
            LBfindbookid.AutoSize = true;
            LBfindbookid.Location = new Point(39, 368);
            LBfindbookid.Margin = new Padding(4, 0, 4, 0);
            LBfindbookid.Name = "LBfindbookid";
            LBfindbookid.Size = new Size(157, 25);
            LBfindbookid.TabIndex = 6;
            LBfindbookid.Text = "ID of book to find";
            // 
            // TXBfindbookid
            // 
            TXBfindbookid.Location = new Point(40, 409);
            TXBfindbookid.Margin = new Padding(4);
            TXBfindbookid.Name = "TXBfindbookid";
            TXBfindbookid.Size = new Size(155, 31);
            TXBfindbookid.TabIndex = 7;
            // 
            // LBoutputbookname
            // 
            LBoutputbookname.AutoSize = true;
            LBoutputbookname.Location = new Point(329, 409);
            LBoutputbookname.Margin = new Padding(4, 0, 4, 0);
            LBoutputbookname.Name = "LBoutputbookname";
            LBoutputbookname.Size = new Size(109, 25);
            LBoutputbookname.TabIndex = 8;
            LBoutputbookname.Text = "Book Name:";
            // 
            // BTNfindbook
            // 
            BTNfindbook.Location = new Point(44, 474);
            BTNfindbook.Margin = new Padding(4);
            BTNfindbook.Name = "BTNfindbook";
            BTNfindbook.Size = new Size(118, 36);
            BTNfindbook.TabIndex = 9;
            BTNfindbook.Text = "Find";
            BTNfindbook.UseVisualStyleBackColor = true;
            BTNfindbook.Click += BTNfindbook_Click;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(BTNfindbook);
            Controls.Add(LBoutputbookname);
            Controls.Add(TXBfindbookid);
            Controls.Add(LBfindbookid);
            Controls.Add(TXBinputbookname);
            Controls.Add(DTgrid);
            Controls.Add(BTNadd);
            Controls.Add(LBinputname);
            Controls.Add(LBinputbookid);
            Controls.Add(TXBinputbookid);
            Margin = new Padding(4);
            Name = "Window";
            Text = "Library Management system";
            Load += Window_Load;
            ((System.ComponentModel.ISupportInitialize)DTgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXBinputbookid;
        private Label LBinputbookid;
        private Label LBinputname;
        private Button BTNadd;
        private DataGridView DTgrid;
        private TextBox TXBinputbookname;
        private Label LBfindbookid;
        private TextBox TXBfindbookid;
        private Label LBoutputbookname;
        private Button BTNfindbook;
    }
}
