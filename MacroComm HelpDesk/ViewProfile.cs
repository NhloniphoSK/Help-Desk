using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroComm_HelpDesk
{
    public partial class ViewProfile : MetroFramework.Forms.MetroForm
    {
        public Image imageVUp = null;
        public string roleVUp = " ";
        public string nameVUp = " ";
        public string emailVUP = " ";
        public string moboleVUp = " ";
        public string surnameVUp = " ";
        public string oldRoleVUp = " ";
        public tblRegistration model;

        public ViewProfile(string role, Image image, string name, string Email, string Mobile, string surname)
        {
            InitializeComponent();

            pbProfilePic.Image = image;
            lblUsername.Text = name;
            lblUserRole.Text = role;
            lblUserEmail.Text = Email;

            imageVUp = image;

            roleVUp = role;
            nameVUp = name;
            emailVUP = Email;
            moboleVUp = Mobile;
            surnameVUp = surname;
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            if (roleVUp == "Administrator" || roleVUp == "Management")
            {
                btnAddUser.Visible = true;
            }
            else
            {
                btnAddUser.Visible = false;
            }
            using (MacrocommEntities db = new MacrocommEntities())
            {
                tblRegistrationBindingSource.DataSource = db.tblRegistrations.ToList();

            }
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            frmUserProfile registratioPag = new frmUserProfile(imageVUp, roleVUp, nameVUp, emailVUP, moboleVUp, surnameVUp, model, oldRoleVUp);
            this.Hide();
            registratioPag.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmListUser listuser = new frmListUser(imageVUp, roleVUp, nameVUp, emailVUP, moboleVUp, surnameVUp);
            this.Hide();
            listuser.Show();
        }
    }
}
