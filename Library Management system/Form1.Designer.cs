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
            TXBinput = new TextBox();
            LBbookid = new Label();
            LBoutput = new Label();
            BTNload = new Button();
            DTgrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DTgrid).BeginInit();
            SuspendLayout();
            // 
            // TXBinput
            // 
            TXBinput.Location = new Point(40, 79);
            TXBinput.Margin = new Padding(4);
            TXBinput.Name = "TXBinput";
            TXBinput.Size = new Size(155, 31);
            TXBinput.TabIndex = 0;
            // 
            // LBbookid
            // 
            LBbookid.AutoSize = true;
            LBbookid.Location = new Point(39, 24);
            LBbookid.Margin = new Padding(4, 0, 4, 0);
            LBbookid.Name = "LBbookid";
            LBbookid.Size = new Size(123, 25);
            LBbookid.TabIndex = 1;
            LBbookid.Text = "Input Book ID";
            // 
            // LBoutput
            // 
            LBoutput.AutoSize = true;
            LBoutput.Location = new Point(46, 146);
            LBoutput.Margin = new Padding(4, 0, 4, 0);
            LBoutput.Name = "LBoutput";
            LBoutput.Size = new Size(0, 25);
            LBoutput.TabIndex = 2;
            // 
            // BTNload
            // 
            BTNload.Location = new Point(49, 198);
            BTNload.Margin = new Padding(4);
            BTNload.Name = "BTNload";
            BTNload.Size = new Size(118, 36);
            BTNload.TabIndex = 3;
            BTNload.Text = "Load";
            BTNload.UseVisualStyleBackColor = true;
            BTNload.Click += BTNload_Click;
            // 
            // DTgrid
            // 
            DTgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTgrid.Location = new Point(252, 128);
            DTgrid.Name = "DTgrid";
            DTgrid.RowHeadersWidth = 62;
            DTgrid.Size = new Size(360, 225);
            DTgrid.TabIndex = 4;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(DTgrid);
            Controls.Add(BTNload);
            Controls.Add(LBoutput);
            Controls.Add(LBbookid);
            Controls.Add(TXBinput);
            Margin = new Padding(4);
            Name = "Window";
            Text = "Library Management system";
            Load += Window_Load;
            ((System.ComponentModel.ISupportInitialize)DTgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXBinput;
        private Label LBbookid;
        private Label LBoutput;
        private Button BTNload;
        private DataGridView DTgrid;
    }
}
