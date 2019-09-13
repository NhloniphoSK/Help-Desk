namespace MacroComm_HelpDesk
{
    partial class ViewProfile
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
            this.lblUserRole = new MetroFramework.Controls.MetroLabel();
            this.lblUserEmail = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnViewProfile = new MetroFramework.Controls.MetroButton();
            this.btnAddUser = new MetroFramework.Controls.MetroButton();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.tblRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRegistrationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(128, 72);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(61, 19);
            this.lblUserRole.TabIndex = 15;
            this.lblUserRole.Text = "UserRole";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(128, 48);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(41, 19);
            this.lblUserEmail.TabIndex = 14;
            this.lblUserEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(128, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(42, 19);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "name";
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(215, 105);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(75, 23);
            this.btnViewProfile.TabIndex = 12;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseSelectable = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(128, 105);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseSelectable = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Location = new System.Drawing.Point(13, 16);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(109, 112);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 10;
            this.pbProfilePic.TabStop = false;
            // 
            // tblRegistrationBindingSource
            // 
            this.tblRegistrationBindingSource.DataSource = typeof(MacroComm_HelpDesk.tblRegistration);
            // 
            // tblRegistrationBindingSource1
            // 
            this.tblRegistrationBindingSource1.DataSource = typeof(MacroComm_HelpDesk.tblRegistration);
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 140);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.pbProfilePic);
            this.DisplayHeader = false;
            this.Location = new System.Drawing.Point(920, 160);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ViewProfile";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ViewProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblUserRole;
        private MetroFramework.Controls.MetroLabel lblUserEmail;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroButton btnViewProfile;
        private MetroFramework.Controls.MetroButton btnAddUser;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.BindingSource tblRegistrationBindingSource;
        private System.Windows.Forms.BindingSource tblRegistrationBindingSource1;
    }
}