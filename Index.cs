namespace Music_store
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            this.Hide();
            guest.ShowDialog();
        }
    }
}