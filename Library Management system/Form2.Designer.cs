namespace Library_Management_system
{
    partial class Admin
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
            viewBookTable = new DataGridView();
            TXBaddnewbook = new TextBox();
            BTNaddbook = new Button();
            ((System.ComponentModel.ISupportInitialize)viewBookTable).BeginInit();
            SuspendLayout();
            // 
            // viewBookTable
            // 
            viewBookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBookTable.Location = new Point(68, 43);
            viewBookTable.Name = "viewBookTable";
            viewBookTable.RowHeadersWidth = 62;
            viewBookTable.Size = new Size(643, 260);
            viewBookTable.TabIndex = 0;
            // 
            // TXBaddnewbook
            // 
            TXBaddnewbook.Location = new Point(404, 357);
            TXBaddnewbook.Margin = new Padding(4);
            TXBaddnewbook.Name = "TXBaddnewbook";
            TXBaddnewbook.Size = new Size(155, 31);
            TXBaddnewbook.TabIndex = 14;
            // 
            // BTNaddbook
            // 
            BTNaddbook.Location = new Point(593, 352);
            BTNaddbook.Margin = new Padding(4);
            BTNaddbook.Name = "BTNaddbook";
            BTNaddbook.Size = new Size(118, 36);
            BTNaddbook.TabIndex = 13;
            BTNaddbook.Text = "Add book";
            BTNaddbook.UseVisualStyleBackColor = true;
            BTNaddbook.Click += BTNaddbook_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 553);
            Controls.Add(TXBaddnewbook);
            Controls.Add(BTNaddbook);
            Controls.Add(viewBookTable);
            Name = "Admin";
            Text = "Amin page";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)viewBookTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewBookTable;
        private TextBox TXBaddnewbook;
        private Button BTNaddbook;
    }
}