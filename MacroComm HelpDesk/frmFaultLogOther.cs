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
    public partial class frmFaultLogOther : MetroFramework.Forms.MetroForm
    {
        public Image imageVp = null;
        public string roleVp = " ";
        public string nameVp = " ";
        public string emailVp = " ";
        public string mobileVp = " ";
        public string surnameVp = " ";

        public frmFaultLogOther(string roleDb, Image imageDb, string nameDb, string mobileDb, string emailDb, string surnameDb)
        {
            InitializeComponent();

            imageVp = imageDb;
            roleVp = roleDb;
            nameVp = nameDb;
            emailVp = emailDb;
            mobileVp = mobileDb;
            surnameVp = surnameDb;
        }

        private void Clear()
        {
            cmbFaultType.Text = "";
            cmbCustomerType.Text = "";
            txtComment.Text = "";
            txtLocation.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MacrocommEntities context = new MacrocommEntities();
                tblLogOther objOther = new tblLogOther();

                objOther.Fault_Type = cmbFaultType.Text;
                objOther.ConsumerType = cmbCustomerType.Text;
                objOther.Location = txtLocation.Text;
                objOther.Comment = txtComment.Text;

                context.tblLogOthers.Add(objOther);
                context.SaveChanges();
                MessageBox.Show("Request Logged successfully", "Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear();
                cmbFaultType.Focus();
            }
            catch
            {
                MessageBox.Show("Request not logged, Please check all fields", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Clear();
                cmbFaultType.Focus();
            }
        }

        //Function for Searching logged faults.
        //public ViewResult (string searchString)
        //{

        //}

        private void btnHome_Click(object sender, EventArgs e)
        {
            Image imageVp = null;
            string roleVp = " ";
            string nameVp = " ";
            string emailVp = " ";
            string mobileVp = " ";
            string surnameVp = " ";


            frmDashboard frmD = new frmDashboard(roleVp, imageVp, nameVp, emailVp, mobileVp, surnameVp);
            this.Hide();
            frmD.Show();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmViewLog frmView = new frmViewLog(roleVp, imageVp, nameVp, mobileVp, emailVp, surnameVp);
            this.Hide();
            frmView.Show();
        }

        private void frmFaultLogOther_Load(object sender, EventArgs e)
        {

        }
    }
}
