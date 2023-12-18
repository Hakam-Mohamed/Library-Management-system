using System.Data;
using System.Web;

namespace Library_Management_system
{
    public partial class Window : Form
    {

        DataTable tableOfBooks;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            tableOfBooks = new DataTable();
            tableOfBooks.Columns.Add("ID", typeof(String));
            tableOfBooks.Columns.Add("Book name", typeof(String));
            // Creates a table which has a column with the ID and a column with the name of the book 


            for (int i = 0; i < 10; i++)
            {
                tableOfBooks.Rows.Add(i, $"Book {i}");
            }
            // Goes ahead and adds 10 books called "Book i" where i is the index 
            // Every book that is added is added as a new row
        }

        private void BTNfindbook_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(TXBfindbookid.Text);
            // Takes in the number input into the text book and converts into an int 
            LBoutputbookname.Text = tableOfBooks.Rows[index].ItemArray[1].ToString();
            // Matches up the Row with the Row index and outputs the name of the book on that Row
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin f2 = new Admin();
            f2.Show();
        }
    }
}
