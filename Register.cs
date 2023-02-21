using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_store
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Admin" && txtPassword.Text == "Admin1")
            {
                Admin admin = new Admin();
                this.Hide();
                admin.ShowDialog();
            }
            else MessageBox.Show("Invalid user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
