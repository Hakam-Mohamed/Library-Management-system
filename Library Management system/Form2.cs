using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_system
{
    public partial class Admin : Form
    {

        DataTable tableOfBooks;
        public Admin()
        {
            InitializeComponent();
        }

        public void addbook(string bookName)
        {
            tableOfBooks.Rows.Add((tableOfBooks.Rows.Count)+1, bookName);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            tableOfBooks = new DataTable();
            tableOfBooks.Columns.Add("ID", typeof(string));
            tableOfBooks.Columns.Add("Book name", typeof(string));

            viewBookTable.DataSource = tableOfBooks;

            for (int i = 1; i < 10;  i++)
            {
                tableOfBooks.Rows.Add(i, $"Book {i}");
            }
        }
    }
}
