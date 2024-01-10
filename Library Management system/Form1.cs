using System.Data;
using System.Web;

namespace Library_Management_system
{
    public partial class Window : Form
    {

        DataTable tableOfBooks;
        DataTable tableOfUsers;

        public Window()
        {
            InitializeComponent();
        }

        // A method which takes in the new book name and adds it to the table
        public void addbook(string bookName)
        {
            tableOfBooks.Rows.Add((tableOfBooks.Rows.Count), bookName);
        }
        public void addUser(string userName, string password)
        {
            tableOfUsers.Rows.Add(userName, password);
        }

        public void loggedin(string userName)
        {
            BTNloginSignUp.Hide();
            LBloggedIn.Text = userName;
        }

        // A method which returns the table so it can be accessed from the admin panel 
        public DataTable getTableBooks()
        {
            return tableOfBooks;
        }
        public DataTable getTableUsers()
        {
            return tableOfUsers;
        }


        private void Window_Load(object sender, EventArgs e)
        {
            tableOfBooks = new DataTable();
            tableOfBooks.Columns.Add("ID", typeof(String));
            tableOfBooks.Columns.Add("Book name", typeof(String));
            tableOfBooks.Columns.Add("Reserved", typeof(String));
            // Creates a table which has a column with the ID and a column with the name of the book 

            for (int i = 0; i < 215; i++)
            {
                tableOfBooks.Rows.Add(i, $"Book {i}");
            }
            // Goes ahead and adds 10 books called "Book i" where i is the index 
            // Every book that is added is added as a new row


            tableOfUsers = new DataTable();
            tableOfUsers.Columns.Add("User name", typeof(string));
            tableOfUsers.Columns.Add("Password", typeof(string));
            tableOfUsers.Rows.Add("Admin", "password");
        }

        private void BTNfindbook_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(TXBfindbookid.Text);
            // Takes in the number input into the text book and converts into an int 
            if (tableOfBooks.Rows.Count >= index)
            {
                LBoutputbookname.Text = tableOfBooks.Rows[index].ItemArray[1].ToString();
                // Matches up the Row with the Row index and outputs the name of the book on that Row
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin f2 = new Admin(this);
            f2.Show();
        }

        private void BTNloginSignUp_Click(object sender, EventArgs e)
        {
            Login f3 = new Login(this);
            f3.Show();
        }
    }
}
