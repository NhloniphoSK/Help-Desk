using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroComm_HelpDesk
{
    public partial class frmDashboard : MetroFramework.Forms.MetroForm
    {
        // Attributes for the Dashboard.
        public Image imageVp = null;
        public string roleVp = " ";
        public string nameVp = " ";
        public string emailVp = " ";
        public string mobileVp = " ";
        public string surnameVp = " ";
        // Attributes for Log Faults.
        //Attributes for Log Faults for other Address.
        public frmDashboard(string roleDb, Image imageDb, string nameDb, string mobileDb, string emailDb, string surnameDb)
        {
            InitializeComponent();

            lblUserRoleD.Text = roleDb;
            lblUsernameD.Text = nameDb;

            pictureBox1.Image = imageDb;

            imageVp = imageDb;

            roleVp = roleDb;
            nameVp = nameDb;
            mobileVp = mobileDb;
            emailVp = emailDb;
            surnameVp = surnameDb;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

            using (MacrocommEntities db = new MacrocommEntities())
            {
                tblRegistrationBindingSource.DataSource = db.tblRegistrations.ToList();

            }

            // Circular progress bar for fixed
            for (int x = 1; x <= 80; x++)
            {
                Thread.Sleep(5);
                cbFixed.Value = x;
                cbFixed.Update();
            }
            // Circular progress bar for Not fixed
            for (int x = 1; x <= 90; x++)
            {
                Thread.Sleep(5);
                cbNotFixed.Value = x;
                cbNotFixed.Update();
            }

            // Circular progress bar for Total
            for (int x = 1; x <= 60; x++)
            {
                Thread.Sleep(5);
                cbTotal.Value = x;
                cbTotal.Update();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pnlSide.Height = btnViewLog.Height;
            //pnlSide.Top = btnViewLog.Top;

            frmViewLog frmView = new frmViewLog(roleVp, imageVp, nameVp, mobileVp, emailVp, surnameVp);
            this.Hide();
            frmView.Show();
        }

        private void btnLogRequest_Click(object sender, EventArgs e)
        {
            //pnlSide.Height = btnLogRequest.Height;
            //pnlSide.Top = btnLogRequest.Top;

            frmFaultLog frmLog = new frmFaultLog(roleVp, imageVp, nameVp, mobileVp, emailVp, surnameVp);
            this.Hide();
            frmLog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pnlSide.Height = btnLogOther.Height;
            //pnlSide.Top = btnLogOther.Top;

            // Calling Fault Log other form.
            frmFaultLogOther frmLog = new frmFaultLogOther(roleVp, imageVp, nameVp, mobileVp, emailVp, surnameVp);
            this.Hide();
            frmLog.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //pnlSide.Height = btnSignOut.Height;
            //pnlSide.Top = btnSignOut.Top;

            //Call LogIn form
            frmLanding frmL = new frmLanding();
            DialogResult res = MessageBox.Show("Do You want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                // Call Sign In form.
                frmL.Show();
                this.Close();

            }
            if (res == DialogResult.No)
            {
                // Go back to the dashboard.
                this.Show();

            }
        }

        private void btnViewNoti_Click(object sender, EventArgs e)
        {
            //pnlSide.Height = btnViewNoti.Height;
            //pnlSide.Top = btnViewNoti.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ViewProfile viewprofile = new ViewProfile(roleVp, imageVp, nameVp, emailVp, mobileVp, surnameVp);

            viewprofile.Show();
        }
    }
}
