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
    public partial class frmListUser : MetroFramework.Forms.MetroForm
    {

        public Image imageVUp = null;
        public string roleVUp = " ";
        public string nameVUp = " ";
        public string emailVUp = " ";
        public string mobileVUp = " ";
        public string surnameVUp = " ";
        public string oldRoleVUP = " ";
        public tblRegistration model = new tblRegistration();

        public frmListUser(Image image, string role, string name, string Email, string Mobile, string surname)
        {
            InitializeComponent();

            imageVUp = image;
            roleVUp = role;
            oldRoleVUP = role;
            nameVUp = name;
            emailVUp = Email;
            mobileVUp = Mobile;
            surnameVUp = surname;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            //frmUserProfile frmViewUserProfile = new frmUserProfile(imageVUp, roleVUp, nameVUp, emailVUp, mobileVUp, surnameVUp);
            //frmViewUserProfile.Show();
            frmRegistration registerUser = new frmRegistration();
            registerUser.Show();
        }

        private void frmListUser_Load(object sender, EventArgs e)
        {
            //using (MacrocommEntities db = new MacrocommEntities())
            //{
            //    tblRegistrationBindingSource.DataSource = db.tblRegistrations.ToList();
            //}

            if (roleVUp == "Administrator")
            {
                btnDelete.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
            }
            populateDataGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateDataGridview();
        }
        void populateDataGridview()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (MacrocommEntities db = new MacrocommEntities())
            {
                dataGridView1.DataSource = db.tblRegistrations.ToList<tblRegistration>();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.UserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserID"].Value);
                using (MacrocommEntities db = new MacrocommEntities())
                {
                    model = db.tblRegistrations.Where(x => x.UserID == model.UserID).FirstOrDefault();

                    if (MessageBox.Show("Are you sure to delete this record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {


                        var entry = db.Entry(model);
                        if (entry.State == EntityState.Detached)
                        {
                            db.tblRegistrations.Attach(model);

                        }
                        db.tblRegistrations.Remove(model);
                        db.SaveChanges();
                        MessageBox.Show("Deleted Successfully");

                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.UserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserID"].Value);
                using (MacrocommEntities db = new MacrocommEntities())
                {
                    model = db.tblRegistrations.Where(x => x.UserID == model.UserID).FirstOrDefault();

                    imageVUp = byteArrayToImage(model.images);
                    roleVUp = model.UserRole;
                    nameVUp = model.FirstName;
                    emailVUp = model.Email;
                    mobileVUp = model.Mobile;
                    surnameVUp = model.Surname;
                }
            }

            frmUserProfile ViewUserProfile = new frmUserProfile(imageVUp, roleVUp, nameVUp, emailVUp, mobileVUp, surnameVUp, model, oldRoleVUP);
            ViewUserProfile.Show();
        }
    }
}
