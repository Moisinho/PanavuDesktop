using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PanavuAdmin.Logic;
using PanavuAdmin.Views;

namespace PanavuAdmin
{
    public partial class Login : Form
    {
        AdminLogic adminLogic = new AdminLogic();
        Home homeForm = new Home();

        private Image eyeClosed = Image.FromFile(@"../../Img/invisible.png");
        private Image eyeOpen = Image.FromFile(@"../../Img/visible.png");
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            if (pictureBoxEye.Image == eyeClosed)
            {
                pictureBoxEye.Image = eyeOpen;
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBoxEye.Image = eyeClosed;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            checkFields(tbEmail.Text, tbPassword.Text);
        }

        private void checkFields(String email, String password)
        {
            if (adminLogic.GetAdmin(email, password))
            {
                this.Hide();
                homeForm.Show();
            }
            else if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
