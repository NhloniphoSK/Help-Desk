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
    public partial class frmUserProfile : MetroFramework.Forms.MetroForm
    {
        public Image imageVUp = null;
        public string roleVUp = " ";
        public string nameVUp = " ";
        public string emailVUP = " ";
        public string moboleVUp = " ";
        public string surnameVUp = " ";
        public string oldRoleVUp = " ";
        public tblRegistration model;

        public frmUserProfile(Image image, string role, string name, string email, string mobile, string Surname, tblRegistration modelvd, string oldRole)
        {
            InitializeComponent();

            lblFirstName.Text = name;
            lblSurname.Text = Surname;
            lblrole.Text = role;
            lblEmail.Text = email;
            lblMobile.Text = mobile;

            imgProfile.Image = image;

            txtFirstName.Text = name;
            txtSurname.Text = Surname;
            tblroles.Text = role;
            txtEmail.Text = email;
            txtMobile.Text = mobile;
            model = modelvd;

            imageVUp = image;
            roleVUp = role;
            nameVUp = name;
            surnameVUp = Surname;
            emailVUP = email;
            moboleVUp = mobile;
            oldRoleVUp = oldRole;
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            //using (MacrocommEntities db = new MacrocommEntities())
            //{
            //    tblRegistrationBindingSource.DataSource = db.tblRegistrations.ToList();

            //}
            if (oldRoleVUp == "Administrator")
            {
                txtMobile.ReadOnly = false;
                //btnDelete.Visible = true;
                cmbUserRole.Visible = false;
            }
            else if (oldRoleVUp == "Management")
            {
                txtMobile.ReadOnly = false;
                //btnDelete.Visible = false;
                cmbUserRole.Visible = false;
            }
            else
            {
                txtMobile.ReadOnly = true;
                //btnDelete.Visible = false;
                cmbUserRole.Visible = false;
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            txtFirstName.Visible = true;
            txtSurname.Visible = true;
            txtEmail.Visible = true;
            txtMobile.Visible = true;
            tblroles.Visible = true;

            btnUpload.Visible = true;
            btnSave.Visible = true;
            btnEditProfile.Visible = false;

            lblFirstName.Visible = false;
            lblSurname.Visible = false;
            lblrole.Visible = false;
            lblEmail.Visible = false;
            lblMobile.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //txtFirstName.Visible = false;
            //txtEmail.Visible = false;
            //txtMobile.Visible = false;
            //txtSurname.Visible = false;
            //tblroles.Visible = false;

            //btnUpload.Visible = false;
            //btnSave.Visible = false;
            //btnEditProfile.Visible = true;


            //lblFirstName.Visible = true;
            //lblEmail.Visible = true;
            //lblMobile.Visible = true;
            //lblrole.Visible = true;
            //lblSurname.Visible = true;


            if (txtFirstName.Text == "" || txtSurname.Text == "" || txtMobile.Text == "" || txtEmail.Text == "" || imgProfile.Image == null)
            {
                MessageBox.Show("Please enter all fields");

                txtFirstName.Visible = true;
                txtSurname.Visible = true;
                txtEmail.Visible = true;
                txtMobile.Visible = true;
                tblroles.Visible = true;
                cmbUserRole.Visible = true;

                btnUpload.Visible = true;
                btnSave.Visible = true;
                btnEditProfile.Visible = false;
                btnCancel.Visible = false;
                btnDelete.Visible = false;
                btnCancel2.Visible = true;

                lblFirstName.Visible = false;
                lblSurname.Visible = false;
                lblrole.Visible = false;
                lblEmail.Visible = false;
                lblMobile.Visible = false;
            }
            else
            {
                try
                {

                    //MacrocommEntities context = new MacrocommEntities();


                    model.FirstName = txtFirstName.Text;
                    model.Surname = txtSurname.Text;
                    model.Email = txtEmail.Text;
                    model.UserRole = cmbUserRole.Text;
                    model.Mobile = txtMobile.Text;
                    //model.images = ConvertFiltoByte(this.imgProfile.ImageLocation);

                    using (MacrocommEntities context = new MacrocommEntities())
                    {

                        context.Entry(model).State = EntityState.Modified;
                        context.SaveChanges();
                    }

                    MessageBox.Show("Record Modified", "Confirmation");
                    txtFirstName.Visible = false;
                    txtEmail.Visible = false;
                    txtMobile.Visible = false;
                    txtSurname.Visible = false;
                    tblroles.Visible = false;
                    cmbUserRole.Visible = false;

                    btnUpload.Visible = false;
                    btnSave.Visible = false;
                    btnEditProfile.Visible = true;
                    btnCancel2.Visible = true;
                    btnDelete.Visible = false;


                    lblFirstName.Visible = true;
                    lblEmail.Visible = true;
                    lblMobile.Visible = true;
                    lblrole.Visible = true;
                    lblSurname.Visible = true;
                }
                catch
                {
                    txtFirstName.Visible = true;
                    txtSurname.Visible = true;
                    txtEmail.Visible = true;
                    txtMobile.Visible = true;
                    tblroles.Visible = true;

                    btnUpload.Visible = true;
                    btnSave.Visible = true;
                    btnEditProfile.Visible = false;
                    btnCancel.Visible = false;
                    btnDelete.Visible = false;
                    btnCancel2.Visible = true;

                    lblFirstName.Visible = false;
                    lblSurname.Visible = false;
                    lblrole.Visible = false;
                    lblEmail.Visible = false;
                    lblMobile.Visible = false;
                    MessageBox.Show("User not Updated", "Confirmation");

                }
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtFirstName.Visible = false;
            txtEmail.Visible = false;
            txtMobile.Visible = false;
            txtSurname.Visible = false;
            tblroles.Visible = false;
            cmbUserRole.Visible = false;

            btnUpload.Visible = false;
            btnSave.Visible = false;
            btnEditProfile.Visible = true;
            btnCancel2.Visible = true;
            btnDelete.Visible = true;


            lblFirstName.Visible = true;
            lblEmail.Visible = true;
            lblMobile.Visible = true;
            lblrole.Visible = true;
            lblSurname.Visible = true;
            this.Close();
        }

        private byte[] ConvertFiltoByte(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numByte = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numByte);
            return data;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a picture";
            ofd.Filter = "All files(*.*)|*.*|png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                imgProfile.Image = Image.FromFile(ofd.FileName);
                tblRegistration obj = tblRegistrationBindingSource.Current as tblRegistration;
                if (obj != null)
                {
                    this.imgProfile.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MacrocommEntities db = new MacrocommEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.tblRegistrations.Attach(model);

                    }
                    db.tblRegistrations.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                    this.Close();


                }
            }
        }
    }
}
