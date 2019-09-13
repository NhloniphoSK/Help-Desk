namespace MacroComm_HelpDesk
{
    partial class frmDashboard
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
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnViewNoti = new System.Windows.Forms.Button();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.btnLogOther = new System.Windows.Forms.Button();
            this.btnLogRequest = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsernameD = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbKPI = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNotFixed = new CircularProgressBar.CircularProgressBar();
            this.cbFixed = new CircularProgressBar.CircularProgressBar();
            this.cbTotal = new CircularProgressBar.CircularProgressBar();
            this.lblUserRoleD = new MetroFramework.Controls.MetroLabel();
            this.tblRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbKPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.SlateGray;
            this.pnlSide.Controls.Add(this.btnSignOut);
            this.pnlSide.Controls.Add(this.btnViewNoti);
            this.pnlSide.Controls.Add(this.btnViewLog);
            this.pnlSide.Controls.Add(this.btnLogOther);
            this.pnlSide.Controls.Add(this.btnLogRequest);
            this.pnlSide.Controls.Add(this.pictureBox2);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(20, 60);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(219, 577);
            this.pnlSide.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Image = global::MacroComm_HelpDesk.Properties.Resources.logout;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(2, 447);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(215, 54);
            this.btnSignOut.TabIndex = 6;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnViewNoti
            // 
            this.btnViewNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewNoti.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNoti.Image = global::MacroComm_HelpDesk.Properties.Resources.close_envelope;
            this.btnViewNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewNoti.Location = new System.Drawing.Point(2, 391);
            this.btnViewNoti.Name = "btnViewNoti";
            this.btnViewNoti.Size = new System.Drawing.Size(216, 54);
            this.btnViewNoti.TabIndex = 5;
            this.btnViewNoti.Text = "VIEW NOTIFICATIONS";
            this.btnViewNoti.UseVisualStyleBackColor = true;
            this.btnViewNoti.Click += new System.EventHandler(this.btnViewNoti_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLog.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLog.Image = global::MacroComm_HelpDesk.Properties.Resources.file;
            this.btnViewLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewLog.Location = new System.Drawing.Point(2, 335);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(216, 54);
            this.btnViewLog.TabIndex = 4;
            this.btnViewLog.Text = "VIEW LOGS";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogOther
            // 
            this.btnLogOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOther.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOther.Image = global::MacroComm_HelpDesk.Properties.Resources.phone_receiver;
            this.btnLogOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOther.Location = new System.Drawing.Point(2, 279);
            this.btnLogOther.Name = "btnLogOther";
            this.btnLogOther.Size = new System.Drawing.Size(216, 54);
            this.btnLogOther.TabIndex = 3;
            this.btnLogOther.Text = "LOG REQUEST OTHER";
            this.btnLogOther.UseVisualStyleBackColor = true;
            this.btnLogOther.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogRequest
            // 
            this.btnLogRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogRequest.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogRequest.Image = global::MacroComm_HelpDesk.Properties.Resources.phone_receiver;
            this.btnLogRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogRequest.Location = new System.Drawing.Point(2, 223);
            this.btnLogRequest.Name = "btnLogRequest";
            this.btnLogRequest.Size = new System.Drawing.Size(216, 54);
            this.btnLogRequest.TabIndex = 2;
            this.btnLogRequest.Text = "LOG REQUEST";
            this.btnLogRequest.UseVisualStyleBackColor = true;
            this.btnLogRequest.Click += new System.EventHandler(this.btnLogRequest_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MacroComm_HelpDesk.Properties.Resources.Government_logoB;
            this.pictureBox2.Location = new System.Drawing.Point(40, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.lblUsernameD);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(239, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblUsernameD
            // 
            this.lblUsernameD.AutoSize = true;
            this.lblUsernameD.Location = new System.Drawing.Point(928, 76);
            this.lblUsernameD.Name = "lblUsernameD";
            this.lblUsernameD.Size = new System.Drawing.Size(68, 19);
            this.lblUsernameD.TabIndex = 2;
            this.lblUsernameD.Text = "Username";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(5, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "WELCOME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1021, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbKPI
            // 
            this.gbKPI.Controls.Add(this.label4);
            this.gbKPI.Controls.Add(this.circularProgressBar1);
            this.gbKPI.Controls.Add(this.label3);
            this.gbKPI.Controls.Add(this.cbTotal);
            this.gbKPI.Controls.Add(this.label2);
            this.gbKPI.Controls.Add(this.label1);
            this.gbKPI.Controls.Add(this.cbNotFixed);
            this.gbKPI.Controls.Add(this.cbFixed);
            this.gbKPI.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKPI.Location = new System.Drawing.Point(255, 216);
            this.gbKPI.Name = "gbKPI";
            this.gbKPI.Size = new System.Drawing.Size(1090, 419);
            this.gbKPI.TabIndex = 2;
            this.gbKPI.TabStop = false;
            this.gbKPI.Text = "Municipality Services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Logs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Not Fixed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Fixed Logs:";
            // 
            // cbNotFixed
            // 
            this.cbNotFixed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cbNotFixed.AnimationSpeed = 500;
            this.cbNotFixed.BackColor = System.Drawing.Color.Transparent;
            this.cbNotFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cbNotFixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbNotFixed.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbNotFixed.InnerMargin = 2;
            this.cbNotFixed.InnerWidth = -1;
            this.cbNotFixed.Location = new System.Drawing.Point(291, 53);
            this.cbNotFixed.MarqueeAnimationSpeed = 2000;
            this.cbNotFixed.Name = "cbNotFixed";
            this.cbNotFixed.OuterColor = System.Drawing.Color.Gray;
            this.cbNotFixed.OuterMargin = -25;
            this.cbNotFixed.OuterWidth = 26;
            this.cbNotFixed.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbNotFixed.ProgressWidth = 25;
            this.cbNotFixed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cbNotFixed.Size = new System.Drawing.Size(243, 235);
            this.cbNotFixed.StartAngle = 270;
            this.cbNotFixed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cbNotFixed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cbNotFixed.SubscriptText = ".23";
            this.cbNotFixed.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cbNotFixed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cbNotFixed.SuperscriptText = "°C";
            this.cbNotFixed.TabIndex = 1;
            this.cbNotFixed.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cbNotFixed.Value = 68;
            // 
            // cbFixed
            // 
            this.cbFixed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cbFixed.AnimationSpeed = 500;
            this.cbFixed.BackColor = System.Drawing.Color.Transparent;
            this.cbFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cbFixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFixed.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFixed.InnerMargin = 2;
            this.cbFixed.InnerWidth = -1;
            this.cbFixed.Location = new System.Drawing.Point(14, 53);
            this.cbFixed.MarqueeAnimationSpeed = 2000;
            this.cbFixed.Name = "cbFixed";
            this.cbFixed.OuterColor = System.Drawing.Color.Gray;
            this.cbFixed.OuterMargin = -25;
            this.cbFixed.OuterWidth = 26;
            this.cbFixed.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbFixed.ProgressWidth = 25;
            this.cbFixed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cbFixed.Size = new System.Drawing.Size(248, 236);
            this.cbFixed.StartAngle = 270;
            this.cbFixed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cbFixed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cbFixed.SubscriptText = ".23";
            this.cbFixed.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cbFixed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cbFixed.SuperscriptText = "°C";
            this.cbFixed.TabIndex = 0;
            this.cbFixed.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cbFixed.Value = 68;
            // 
            // cbTotal
            // 
            this.cbTotal.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cbTotal.AnimationSpeed = 500;
            this.cbTotal.BackColor = System.Drawing.Color.Transparent;
            this.cbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTotal.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTotal.InnerMargin = 2;
            this.cbTotal.InnerWidth = -1;
            this.cbTotal.Location = new System.Drawing.Point(583, 67);
            this.cbTotal.MarqueeAnimationSpeed = 2000;
            this.cbTotal.Name = "cbTotal";
            this.cbTotal.OuterColor = System.Drawing.Color.Gray;
            this.cbTotal.OuterMargin = -25;
            this.cbTotal.OuterWidth = 26;
            this.cbTotal.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbTotal.ProgressWidth = 25;
            this.cbTotal.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cbTotal.Size = new System.Drawing.Size(235, 222);
            this.cbTotal.StartAngle = 270;
            this.cbTotal.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cbTotal.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cbTotal.SubscriptText = ".23";
            this.cbTotal.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cbTotal.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cbTotal.SuperscriptText = "°C";
            this.cbTotal.TabIndex = 2;
            this.cbTotal.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cbTotal.Value = 68;
            // 
            // lblUserRoleD
            // 
            this.lblUserRoleD.AutoSize = true;
            this.lblUserRoleD.Location = new System.Drawing.Point(1274, 163);
            this.lblUserRoleD.Name = "lblUserRoleD";
            this.lblUserRoleD.Size = new System.Drawing.Size(61, 19);
            this.lblUserRoleD.TabIndex = 3;
            this.lblUserRoleD.Text = "UserRole";
            // 
            // tblRegistrationBindingSource
            // 
            this.tblRegistrationBindingSource.DataSource = typeof(MacroComm_HelpDesk.tblRegistration);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(855, 67);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(235, 221);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 5;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "In Progress:";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 657);
            this.Controls.Add(this.lblUserRoleD);
            this.Controls.Add(this.gbKPI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSide);
            this.Name = "frmDashboard";
            this.Text = "Municipal Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbKPI.ResumeLayout(false);
            this.gbKPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnViewNoti;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.Button btnLogOther;
        private System.Windows.Forms.Button btnLogRequest;
        private System.Windows.Forms.GroupBox gbKPI;
        private CircularProgressBar.CircularProgressBar cbNotFixed;
        private CircularProgressBar.CircularProgressBar cbFixed;
        private CircularProgressBar.CircularProgressBar cbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel lblUsernameD;
        private MetroFramework.Controls.MetroLabel lblUserRoleD;
        private System.Windows.Forms.BindingSource tblRegistrationBindingSource;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}