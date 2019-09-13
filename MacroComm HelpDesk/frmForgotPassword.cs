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
    public partial class frmForgotPassword : MetroFramework.Forms.MetroForm
    {
        int x = 255, y = 1;

        MacrocommEntities context = new MacrocommEntities();
        MacrocommEntities2 ef = new MacrocommEntities2();
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            string emailLab = "sorry we do not have admin email yet!!";
            string emailAdmin = " ";
            string role = " ";
            foreach (var reg in context.tblRegistrations)
            {
                role = reg.UserRole;

                if (role == "Admin" || role == "Administrator")
                {
                    emailAdmin = reg.Email;
                    emailLab = reg.Email;
                }
            }
            label5.Text = " Email our Admin at " + emailLab + " if the system is slow.";
            label6.Text = "Administrator email address " + emailAdmin + "  ";
            label6.Font = new Font(" ", 12);
            label5.Font = new Font(" ", 14);
            timer1.Interval = 1;
            timer1.Start();

            cmdQuery.Items.Add("Forgot Password");
            cmdQuery.Items.Add("Change Password");
            cmdQuery.Items.Add("Change Phone Number");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.SetBounds(x, y, 1, 1);
            x++;
            if (x >= 800)
            {
                x = 1;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool test = false;
            foreach (var registration in context.tblRegistrations)
            {
                if (registration.Mobile == txtPhone.Text && registration.Email == txtEmail.Text)
                {
                    test = true;
                }
            }
            if (test == true)
            {
                tblForgotPassword objQry = new tblForgotPassword();

                objQry.email = txtEmail.Text;
                objQry.Phone_No = txtPhone.Text;
                objQry.Query = cmdQuery.Text;

                foreach (var reg in context.tblRegistrations)
                {

                    if (reg.Mobile == txtPhone.Text)
                    {
                        objQry.EmpName = reg.FirstName;
                    }
                }


                using (ef)
                {
                    ef.tblForgotPasswords.Add(objQry);
                    ef.SaveChanges();
                }

                label4.Hide();
                cmdQuery.Text = "";
                txtPhone.Clear();
                txtEmail.Clear();
                txtEmail.Focus();
                MessageBox.Show("Query Sent Admin will contact you soon.","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                label4.Show();
                txtEmail.Clear();
                txtEmail.Focus();
            }
        }
    }
}
