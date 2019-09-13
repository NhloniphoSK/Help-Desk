using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MacroComm_HelpDesk
{
    public partial class frmSignIn : MetroFramework.Forms.MetroForm
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        //convert bytearray to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        MacrocommEntities ef = new MacrocommEntities();
        private void button1_Click(object sender, EventArgs e)
        {

            bool test = false;
            string role = "None";
            Image Pic = null;
            string name = "None";
            string email = "None";
            string mobile = "None";
            string surname = "None";





            foreach (var registration in ef.tblRegistrations)
            {
                if (registration.Mobile == txtUsername.Text && registration.Password == txtPassword.Text)
                {
                    test = true;
                    role = registration.UserRole;
                    Pic = byteArrayToImage(registration.images);
                    name = registration.FirstName;
                    mobile = registration.Mobile;
                    email = registration.Email;
                    surname = registration.Surname;


                }


            }
            if (test == true)
            {

                this.Hide();
                frmDashboard desh = new frmDashboard(role,Pic,name,mobile,email,surname);
                desh.Show();
                lblErrorPassword.Visible = false;
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            else
            {
                lblErrorPassword.Visible = true;
                // txtUsername.Clear();
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword frmForgot = new frmForgotPassword();
            this.Hide();
            frmForgot.Show();
        }
    }
}
