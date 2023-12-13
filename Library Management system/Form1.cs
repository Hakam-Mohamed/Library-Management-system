using System.Data;

namespace Library_Management_system
{
    public partial class Window : Form
    {

        DataTable table;

        public Window()
        {
            InitializeComponent();
        }

        private void BTNload_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TXBinput.Text, TXBinput.Text);
        }

        private void Window_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("ID", typeof(String));
            table.Columns.Add("Book name", typeof(String));

            DTgrid.DataSource = table;
        }
    }
}
