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
    public partial class Login : Form
    {
        private readonly Window _win;
        DataTable tableOfUsers;
        public Login(Window win)
        {
            InitializeComponent();
            _win = win;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            tableOfUsers = _win.getTableUsers();
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (tableOfUsers.Rows.Count); i++)
            {
                if ((tableOfUsers.Rows[i].ItemArray[0].ToString() == TXBUserName.Text) 
                    && (tableOfUsers.Rows[i].ItemArray[1].ToString() == TXBpassword.Text))
                {                 
                    _win.loggedin(TXBUserName.Text);
                    this.Close();
                }
            }
        }

        private void BTNsignUp_Click(object sender, EventArgs e)
        {
            if ((TXBUserName.Text != "") && TXBpassword.Text != "")
            {
                _win.addUser(TXBUserName.Text, TXBpassword.Text);
                TXBUserName.Text = "";
                TXBpassword.Text = "";
            }
        }
    }
}
