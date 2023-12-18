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

        private void BTNload_Click(object sender, EventArgs e)
        {
            tableOfBooks.Rows.Add(TXBinputbookid.Text, TXBinputbookname.Text);
        }

        private void Window_Load(object sender, EventArgs e)
        {
            tableOfBooks = new DataTable();
            tableOfBooks.Columns.Add("ID", typeof(String));
            tableOfBooks.Columns.Add("Book name", typeof(String));

            DTgrid.DataSource = tableOfBooks;

            for (int i = 0; i < 10; i++)
            {
                tableOfBooks.Rows.Add(i, $"Book {i}");
            }
        }

        private void BTNfindbook_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(TXBfindbookid.Text);
            LBoutputbookname.Text = tableOfBooks.Rows[index].ItemArray[1].ToString();
        }
    }
}
