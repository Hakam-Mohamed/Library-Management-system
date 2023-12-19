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
        private readonly Window _win;
        public Admin(Window win)
        {
            _win = win;
            // Creates a variable _win which is just a variable holding the main page
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            viewBookTable.DataSource = _win.getTableBooks();
            // Sets the table source to be found in the Main page
            viewUsersTable.DataSource = _win.getTableUsers();
        }

        private void BTNaddbook_Click(object sender, EventArgs e)
        {
            _win.addbook(TXBaddnewbook.Text);
            // Passes the text given in, to the main page through this method
        }
    }
}
