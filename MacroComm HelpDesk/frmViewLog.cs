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
using System.Data.Entity;
namespace MacroComm_HelpDesk
{
    public partial class frmViewLog : MetroFramework.Forms.MetroForm
    {
        public Image imageVp = null;
        public string roleVp = " ";
        public string nameVp = " ";
        public string emailVp = " ";
        public string mobileVp = " ";
        public string surnameVp = " ";

        tblViewLog model = new tblViewLog();
        public frmViewLog(string roleDb, Image imageDb, string nameDb, string mobileDb, string emailDb, string surnameDb)
        {
            InitializeComponent();

            imageVp = imageDb;
            roleVp = roleDb;
            nameVp = nameDb;
            emailVp = emailDb;
            mobileVp = mobileDb;
            surnameVp = surnameDb;
        }

        private void dgvViewLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmViewLog_Load(object sender, EventArgs e)
        {
            using (MacrocommEntities db = new MacrocommEntities())
            {
                tblViewLogBindingSource.DataSource = db.tblViewLogs.ToList();
            }
        }

        //Function to Sortby fault type
        //public ActionResult Index(string sortOrder)
        //{
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        //    ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
        //    var students = from s in db.Students
        //                   select s;
        //    switch (sortOrder)
        //    {
        //        case "name_desc":
        //            students = students.OrderByDescending(s => s.LastName);
        //            break;
        //        case "Date":
        //            students = students.OrderBy(s => s.EnrollmentDate);
        //            break;
        //        case "date_desc":
        //            students = students.OrderByDescending(s => s.EnrollmentDate);
        //            break;
        //        default:
        //            students = students.OrderBy(s => s.LastName);
        //            break;
        //    }
        //    return View(students.ToList());
        //}


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        MacrocommEntities ef = new MacrocommEntities();
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string x = txtSearch.Text.Trim();
            int result = System.Int32.Parse(x);
            model.Ref_No = result;
            using (MacrocommEntities db = new MacrocommEntities())
            {
                //dgvViewLog.Visible = true;
                //dgvViewLog.Visible = false;

                dgvViewLog.DataSource = ef.tblViewLogs.SqlQuery("SELECT * FROM tblViewLog WHERE Ref_No=" + txtSearch.Text).ToList<tblViewLog>();
            }
            txtSearch.Text = "";
        }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tblLogFault fault = new tblLogFault();
            if (dgvViewLog.CurrentRow.Index != -1)
            {
                model.LogID = Convert.ToInt32(dgvViewLog.CurrentRow.Cells["LogID"].Value);
                using (MacrocommEntities db = new MacrocommEntities())
                {
                    model = db.tblViewLogs.Where(x => x.LogID == model.LogID).FirstOrDefault();

                    if (MessageBox.Show("Are you sure to delete this record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {


                        var entry = db.Entry(model);
                        if (entry.State == EntityState.Detached)
                        {
                            db.tblViewLogs.Attach(model);

                        }
                        db.tblViewLogs.Remove(model);
                        db.SaveChanges();
                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
        }
    }
}
