namespace Library_Management_system
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void BTNload_Click(object sender, EventArgs e)
        {
            string txt = TXBinput.Text;
            LBoutput.Text = txt;
        }
    }
}
