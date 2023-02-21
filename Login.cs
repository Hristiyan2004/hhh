using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Music_store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "User" && txtPassword.Text == "User1")
            {
                User user = new User();
                this.Hide();
                user.ShowDialog();
            }
            else MessageBox.Show("Invalid user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
