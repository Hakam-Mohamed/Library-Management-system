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
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 553);
            Controls.Add(viewBookTable);
            Name = "Admin";
            Text = "Amin page";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)viewBookTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewBookTable;
    }
}