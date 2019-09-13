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
// This is the OG.
namespace MacroComm_HelpDesk
{
    public partial class frmRegistration : MetroFramework.Forms.MetroForm
    {

        public void Clear()
        {
            txtFirstName.Text = txtSurname.Text = txtMobile.Text = txtEmail.Text = txtPassword.Text = txtPasswordConfirm.Text = "";
            cbUserRole.ResetText();
            imgProfile.Image = null;
        }

        public frmRegistration()
        {
            InitializeComponent();
        }

        // Convert path to Bytes for an image
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

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            using (MacrocommEntities db = new MacrocommEntities())
            {

                tblRegistrationBindingSource.DataSource = db.tblRegistrations.ToList();
            }
        }

        MacrocommEntities context = new MacrocommEntities();
        tblRegistration objReg = new tblRegistration();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtSurname.Text == "" || txtMobile.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtPasswordConfirm.Text == "")
            {
                MessageBox.Show("Please enter all fields");
                Clear();

            }
            else if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Password Does not match!");
                txtPassword.Text = "";
                txtPasswordConfirm.Text = "";
            }
            // if exists, show a message error
            else if (context.tblRegistrations.Any(o => o.Mobile == txtMobile.Text))
            {
                lblErrorUser.Visible = true;
                txtMobile.Text = "";
                txtMobile.Focus();
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtPasswordConfirm.Text = "";
            }
            else if (!EmailValidation.IsValidEmailAddress(txtEmail.Text.ToString()))
            {
                lblEmailValidation.Visible = true;
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtPasswordConfirm.Text = "";
            }
            else
            {
                try
                {
                    
                    objReg.FirstName = txtFirstName.Text;
                    objReg.Surname = txtSurname.Text;
                    objReg.Mobile = txtMobile.Text;
                    objReg.Password = txtPassword.Text;
                    objReg.Email = txtEmail.Text;
                    objReg.UserRole = cbUserRole.Text;
                    objReg.images = ConvertFiltoByte(this.imgProfile.ImageLocation);
                    context.tblRegistrations.Add(objReg);
                    context.SaveChanges();
                    MessageBox.Show("New Record created", "Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    lblErrorUser.Visible = false;
                    Clear();
                }
                catch
                {
                    MessageBox.Show("User not registered please check all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a picture";
            ofd.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
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

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
