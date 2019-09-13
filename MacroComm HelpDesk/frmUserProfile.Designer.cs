namespace MacroComm_HelpDesk
{
    partial class frmUserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblrole = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblMobile = new MetroFramework.Controls.MetroLabel();
            this.lblSurname = new MetroFramework.Controls.MetroLabel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.btnEditProfile = new MetroFramework.Controls.MetroButton();
            this.tblroles = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUserDetail = new System.Windows.Forms.GroupBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbUserRole = new MetroFramework.Controls.MetroComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.tblRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbUserDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Location = new System.Drawing.Point(538, 155);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(35, 19);
            this.lblrole.TabIndex = 57;
            this.lblrole.Text = "Role";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(154, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 56;
            this.lblEmail.Text = "Email";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(153, 155);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(50, 19);
            this.lblMobile.TabIndex = 55;
            this.lblMobile.Text = "Mobile";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(153, 117);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 19);
            this.lblSurname.TabIndex = 54;
            this.lblSurname.Text = "Surname";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(497, 158);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(124, 35);
            this.btnUpload.TabIndex = 53;
            this.btnUpload.Text = "Upload Picture";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Visible = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(152, 84);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(52, 19);
            this.lblFirstName.TabIndex = 52;
            this.lblFirstName.Text = "FName";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(215, 237);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(124, 34);
            this.btnEditProfile.TabIndex = 51;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseSelectable = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // tblroles
            // 
            // 
            // 
            // 
            this.tblroles.CustomButton.Image = null;
            this.tblroles.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.tblroles.CustomButton.Name = "";
            this.tblroles.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tblroles.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tblroles.CustomButton.TabIndex = 1;
            this.tblroles.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tblroles.CustomButton.UseSelectable = true;
            this.tblroles.CustomButton.Visible = false;
            this.tblroles.Lines = new string[0];
            this.tblroles.Location = new System.Drawing.Point(345, 40);
            this.tblroles.MaxLength = 32767;
            this.tblroles.Name = "tblroles";
            this.tblroles.PasswordChar = '\0';
            this.tblroles.ReadOnly = true;
            this.tblroles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tblroles.SelectedText = "";
            this.tblroles.SelectionLength = 0;
            this.tblroles.SelectionStart = 0;
            this.tblroles.ShortcutsEnabled = true;
            this.tblroles.Size = new System.Drawing.Size(124, 23);
            this.tblroles.TabIndex = 50;
            this.tblroles.UseSelectable = true;
            this.tblroles.Visible = false;
            this.tblroles.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tblroles.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 24);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(151, 115);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(318, 24);
            this.txtSurname.TabIndex = 42;
            this.txtSurname.Visible = false;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(151, 153);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(146, 24);
            this.txtMobile.TabIndex = 41;
            this.txtMobile.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mobile";
            // 
            // gbUserDetail
            // 
            this.gbUserDetail.Controls.Add(this.btnCancel2);
            this.gbUserDetail.Controls.Add(this.btnDelete);
            this.gbUserDetail.Controls.Add(this.cmbUserRole);
            this.gbUserDetail.Controls.Add(this.lblrole);
            this.gbUserDetail.Controls.Add(this.lblEmail);
            this.gbUserDetail.Controls.Add(this.lblMobile);
            this.gbUserDetail.Controls.Add(this.lblSurname);
            this.gbUserDetail.Controls.Add(this.btnUpload);
            this.gbUserDetail.Controls.Add(this.lblFirstName);
            this.gbUserDetail.Controls.Add(this.btnEditProfile);
            this.gbUserDetail.Controls.Add(this.tblroles);
            this.gbUserDetail.Controls.Add(this.btnCancel);
            this.gbUserDetail.Controls.Add(this.btnSave);
            this.gbUserDetail.Controls.Add(this.imgProfile);
            this.gbUserDetail.Controls.Add(this.txtEmail);
            this.gbUserDetail.Controls.Add(this.txtSurname);
            this.gbUserDetail.Controls.Add(this.txtMobile);
            this.gbUserDetail.Controls.Add(this.txtFirstName);
            this.gbUserDetail.Controls.Add(this.label4);
            this.gbUserDetail.Controls.Add(this.label3);
            this.gbUserDetail.Controls.Add(this.label2);
            this.gbUserDetail.Controls.Add(this.label1);
            this.gbUserDetail.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserDetail.Location = new System.Drawing.Point(87, 77);
            this.gbUserDetail.Name = "gbUserDetail";
            this.gbUserDetail.Size = new System.Drawing.Size(638, 293);
            this.gbUserDetail.TabIndex = 38;
            this.gbUserDetail.TabStop = false;
            this.gbUserDetail.Text = "User Details";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Image = global::MacroComm_HelpDesk.Properties.Resources.iconfinder_dashboard__Delete_2877014;
            this.btnCancel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel2.Location = new System.Drawing.Point(345, 238);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(124, 35);
            this.btnCancel2.TabIndex = 63;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::MacroComm_HelpDesk.Properties.Resources.iconfinder_dashboard__Delete_2877014;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(345, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 35);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblRegistrationBindingSource, "UserRole", true));
            this.cmbUserRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblRegistrationBindingSource, "UserRole", true));
            this.cmbUserRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblRegistrationBindingSource, "UserRole", true));
            this.cmbUserRole.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tblRegistrationBindingSource, "UserRole", true));
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.ItemHeight = 23;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Administrator",
            "Management",
            "Clerk"});
            this.cmbUserRole.Location = new System.Drawing.Point(497, 199);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(124, 29);
            this.cmbUserRole.TabIndex = 61;
            this.cmbUserRole.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MacroComm_HelpDesk.Properties.Resources.iconfinder_dashboard__Delete_2877014;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(475, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 35);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::MacroComm_HelpDesk.Properties.Resources.iconfinder_save_2639912;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(215, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 35);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imgProfile
            // 
            this.imgProfile.Location = new System.Drawing.Point(497, 40);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(124, 112);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfile.TabIndex = 46;
            this.imgProfile.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(151, 82);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(318, 24);
            this.txtFirstName.TabIndex = 40;
            this.txtFirstName.Visible = false;
            // 
            // tblRegistrationBindingSource
            // 
            this.tblRegistrationBindingSource.DataSource = typeof(MacroComm_HelpDesk.tblRegistration);
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbUserDetail);
            this.Name = "frmUserProfile";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.gbUserDetail.ResumeLayout(false);
            this.gbUserDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblRegistrationBindingSource;
        private MetroFramework.Controls.MetroLabel lblrole;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblMobile;
        private MetroFramework.Controls.MetroLabel lblSurname;
        private System.Windows.Forms.Button btnUpload;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private MetroFramework.Controls.MetroButton btnEditProfile;
        private MetroFramework.Controls.MetroTextBox tblroles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox imgProfile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUserDetail;
        private System.Windows.Forms.TextBox txtFirstName;
        private MetroFramework.Controls.MetroComboBox cmbUserRole;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnDelete;
    }
}