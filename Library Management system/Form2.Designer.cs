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
            TXBaddnewbook = new TextBox();
            BTNaddbook = new Button();
            viewBookTable = new DataGridView();
            viewUsersTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)viewBookTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewUsersTable).BeginInit();
            SuspendLayout();
            // 
            // TXBaddnewbook
            // 
            TXBaddnewbook.Location = new Point(81, 449);
            TXBaddnewbook.Margin = new Padding(4);
            TXBaddnewbook.Name = "TXBaddnewbook";
            TXBaddnewbook.Size = new Size(155, 31);
            TXBaddnewbook.TabIndex = 14;
            // 
            // BTNaddbook
            // 
            BTNaddbook.Location = new Point(270, 444);
            BTNaddbook.Margin = new Padding(4);
            BTNaddbook.Name = "BTNaddbook";
            BTNaddbook.Size = new Size(118, 36);
            BTNaddbook.TabIndex = 13;
            BTNaddbook.Text = "Add book";
            BTNaddbook.UseVisualStyleBackColor = true;
            BTNaddbook.Click += BTNaddbook_Click;
            // 
            // viewBookTable
            // 
            viewBookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBookTable.Location = new Point(22, 26);
            viewBookTable.Name = "viewBookTable";
            viewBookTable.RowHeadersWidth = 62;
            viewBookTable.Size = new Size(357, 352);
            viewBookTable.TabIndex = 15;
            // 
            // viewUsersTable
            // 
            viewUsersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewUsersTable.Location = new Point(427, 26);
            viewUsersTable.Name = "viewUsersTable";
            viewUsersTable.RowHeadersWidth = 62;
            viewUsersTable.Size = new Size(357, 352);
            viewUsersTable.TabIndex = 16;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 553);
            Controls.Add(viewUsersTable);
            Controls.Add(viewBookTable);
            Controls.Add(TXBaddnewbook);
            Controls.Add(BTNaddbook);
            Name = "Admin";
            Text = "Amin page";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)viewBookTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewUsersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TXBaddnewbook;
        private Button BTNaddbook;
        private DataGridView viewBookTable;
        private DataGridView viewUsersTable;
    }
}