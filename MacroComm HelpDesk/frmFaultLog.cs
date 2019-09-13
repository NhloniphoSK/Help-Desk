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
    public partial class frmFaultLog : MetroFramework.Forms.MetroForm
    {
        public Image imageVp = null;
        public string roleVp = " ";
        public string nameVp = " ";
        public string emailVp = " ";
        public string mobileVp = " ";
        public string surnameVp = " ";

        tblLogFault model = new tblLogFault();
        public frmFaultLog(string roleDb, Image imageDb, string nameDb, string mobileDb, string emailDb, string surnameDb)
        {
            InitializeComponent();

            imageVp = imageDb;
            roleVp = roleDb;
            nameVp = nameDb;
            emailVp = emailDb;
            mobileVp = mobileDb;
            surnameVp = surnameDb;
        }

        private void frmFaultLog_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MacrocommEntities context = new MacrocommEntities();
            tblLogFault objLog = new tblLogFault();

            if (cmbFaultType.Text == "" || cmbCustomerType.Text == "" || txtComment.Text == "")
            {
                MessageBox.Show("Please enter all requered field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Adding logs to the FaultLogs table.
                    objLog.Log_Type = cmbFaultType.Text;
                    objLog.Consumer_Type = cmbCustomerType.Text;
                    objLog.Comment = txtComment.Text;
                    context.tblLogFaults.Add(objLog);
                    context.SaveChanges();
                    MessageBox.Show("Log request Successfully logged.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                catch
                {
                    MessageBox.Show("Something went wrong please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();

                }
            }

            using (MacrocommEntities db = new MacrocommEntities())
            {
                tblViewLog view = new tblViewLog();
                var logg = (from p in db.tblLogFaults
                            join r in db.tblViewLogs
                            on p.Ref_No equals r.LogID
                            where p.Log_Type == "Water,Electricity,Refuse,Sawege"
                            select new
                            {
                                ID = p.Ref_No,
                                cmbFaultType = p.Log_Type,
                                cmbCustomerType = p.Consumer_Type,
                                txtComment = p.Comment,
                                lID = r.LogID,
                                fault = r.Fault_Type,
                                comsumer = r.Consumer_Status,
                                comments = r.Comment
                            }).ToList();
                context.tblViewLogs.Add(view);
                context.SaveChanges();
            }
        }

        private void Clear()
        {
            cmbFaultType.Text = "";
            cmbCustomerType.Text = "";
            txtComment.Text = "";
            cmbFaultType.Focus();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmViewLog frmView = new frmViewLog(roleVp, imageVp, nameVp, mobileVp, emailVp, surnameVp);
            frmView.Show();
            this.Close();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            tblRegistration registration = new tblRegistration();
            
            frmDashboard frmDash = new frmDashboard(roleVp, imageVp, nameVp, mobileVp, emailVp, surnameVp);
            frmDash.Show();
            this.Close();
        }
    }
}
