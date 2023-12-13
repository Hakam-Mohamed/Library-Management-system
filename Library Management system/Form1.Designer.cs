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
            SuspendLayout();
            // 
            // TXBinput
            // 
            TXBinput.Location = new Point(32, 63);
            TXBinput.Name = "TXBinput";
            TXBinput.Size = new Size(125, 27);
            TXBinput.TabIndex = 0;
            // 
            // LBbookid
            // 
            LBbookid.AutoSize = true;
            LBbookid.Location = new Point(31, 19);
            LBbookid.Name = "LBbookid";
            LBbookid.Size = new Size(100, 20);
            LBbookid.TabIndex = 1;
            LBbookid.Text = "Input Book ID";
            // 
            // LBoutput
            // 
            LBoutput.AutoSize = true;
            LBoutput.Location = new Point(37, 117);
            LBoutput.Name = "LBoutput";
            LBoutput.Size = new Size(0, 20);
            LBoutput.TabIndex = 2;
            // 
            // BTNload
            // 
            BTNload.Location = new Point(39, 158);
            BTNload.Name = "BTNload";
            BTNload.Size = new Size(94, 29);
            BTNload.TabIndex = 3;
            BTNload.Text = "Load";
            BTNload.UseVisualStyleBackColor = true;
            BTNload.Click += BTNload_Click;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNload);
            Controls.Add(LBoutput);
            Controls.Add(LBbookid);
            Controls.Add(TXBinput);
            Name = "Window";
            Text = "Library Management system";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXBinput;
        private Label LBbookid;
        private Label LBoutput;
        private Button BTNload;
    }
}
