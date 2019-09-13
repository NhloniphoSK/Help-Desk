namespace MacroComm_HelpDesk
{
    partial class frmLanding
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.webBrowserNewFeed = new System.Windows.Forms.WebBrowser();
            this.metroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.gbConsumerPortal = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlert = new MetroFramework.Controls.MetroButton();
            this.btnConsumerPortal = new MetroFramework.Controls.MetroButton();
            this.btnFaultLog = new MetroFramework.Controls.MetroButton();
            this.gbVendorPortal = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBids = new MetroFramework.Controls.MetroButton();
            this.btnInvoice = new MetroFramework.Controls.MetroButton();
            this.btnVendorPortal = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.gbConsumerPortal.SuspendLayout();
            this.gbVendorPortal.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.SlateGray;
            this.metroPanel1.Controls.Add(this.webBrowserNewFeed);
            this.metroPanel1.Controls.Add(this.metroDateTime);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(210, 493);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // webBrowserNewFeed
            // 
            this.webBrowserNewFeed.Location = new System.Drawing.Point(2, 200);
            this.webBrowserNewFeed.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNewFeed.Name = "webBrowserNewFeed";
            this.webBrowserNewFeed.Size = new System.Drawing.Size(204, 406);
            this.webBrowserNewFeed.TabIndex = 7;
            this.webBrowserNewFeed.Url = new System.Uri("https://www.timeslive.co.za/news/south-africa/", System.UriKind.Absolute);
            // 
            // metroDateTime
            // 
            this.metroDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTime.Location = new System.Drawing.Point(3, 3);
            this.metroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime.Name = "metroDateTime";
            this.metroDateTime.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime.TabIndex = 1;
            // 
            // gbConsumerPortal
            // 
            this.gbConsumerPortal.Controls.Add(this.label3);
            this.gbConsumerPortal.Controls.Add(this.label2);
            this.gbConsumerPortal.Controls.Add(this.label1);
            this.gbConsumerPortal.Controls.Add(this.btnAlert);
            this.gbConsumerPortal.Controls.Add(this.btnConsumerPortal);
            this.gbConsumerPortal.Controls.Add(this.btnFaultLog);
            this.gbConsumerPortal.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsumerPortal.Location = new System.Drawing.Point(236, 166);
            this.gbConsumerPortal.Name = "gbConsumerPortal";
            this.gbConsumerPortal.Size = new System.Drawing.Size(1009, 224);
            this.gbConsumerPortal.TabIndex = 1;
            this.gbConsumerPortal.TabStop = false;
            this.gbConsumerPortal.Text = "CONSUMER PORTAL";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(790, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registration for SMS Alert";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(376, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log into consumer portal if you exist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(44, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log a fault or check status of your log";
            // 
            // btnAlert
            // 
            this.btnAlert.BackgroundImage = global::MacroComm_HelpDesk.Properties.Resources.notifications_button;
            this.btnAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlert.Location = new System.Drawing.Point(781, 70);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(168, 79);
            this.btnAlert.TabIndex = 2;
            this.btnAlert.Text = "ALERT REGISTRATION";
            this.btnAlert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAlert.UseSelectable = true;
            this.btnAlert.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnConsumerPortal
            // 
            this.btnConsumerPortal.BackgroundImage = global::MacroComm_HelpDesk.Properties.Resources.round_account_button_with_user_inside;
            this.btnConsumerPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsumerPortal.Location = new System.Drawing.Point(392, 70);
            this.btnConsumerPortal.Name = "btnConsumerPortal";
            this.btnConsumerPortal.Size = new System.Drawing.Size(168, 79);
            this.btnConsumerPortal.TabIndex = 1;
            this.btnConsumerPortal.Text = "CONSUMER PORTAL";
            this.btnConsumerPortal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsumerPortal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnConsumerPortal.UseSelectable = true;
            this.btnConsumerPortal.Click += new System.EventHandler(this.btnConsumerPortal_Click);
            // 
            // btnFaultLog
            // 
            this.btnFaultLog.BackgroundImage = global::MacroComm_HelpDesk.Properties.Resources.phone_receiver;
            this.btnFaultLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFaultLog.Location = new System.Drawing.Point(47, 70);
            this.btnFaultLog.Name = "btnFaultLog";
            this.btnFaultLog.Size = new System.Drawing.Size(168, 79);
            this.btnFaultLog.TabIndex = 0;
            this.btnFaultLog.Text = "LOG FAULTS";
            this.btnFaultLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFaultLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFaultLog.UseSelectable = true;
            this.btnFaultLog.Click += new System.EventHandler(this.btnFaultLog_Click);
            // 
            // gbVendorPortal
            // 
            this.gbVendorPortal.Controls.Add(this.label6);
            this.gbVendorPortal.Controls.Add(this.label5);
            this.gbVendorPortal.Controls.Add(this.label4);
            this.gbVendorPortal.Controls.Add(this.btnBids);
            this.gbVendorPortal.Controls.Add(this.btnInvoice);
            this.gbVendorPortal.Controls.Add(this.btnVendorPortal);
            this.gbVendorPortal.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVendorPortal.Location = new System.Drawing.Point(236, 396);
            this.gbVendorPortal.Name = "gbVendorPortal";
            this.gbVendorPortal.Size = new System.Drawing.Size(1009, 224);
            this.gbVendorPortal.TabIndex = 2;
            this.gbVendorPortal.TabStop = false;
            this.gbVendorPortal.Text = "VENDOR PORTAL";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(807, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Available bids,bid here";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(389, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Download invoices and check billing";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(34, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log a fault or check  vendor status";
            // 
            // btnBids
            // 
            this.btnBids.BackgroundImage = global::MacroComm_HelpDesk.Properties.Resources.bids;
            this.btnBids.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBids.Location = new System.Drawing.Point(781, 41);
            this.btnBids.Name = "btnBids";
            this.btnBids.Size = new System.Drawing.Size(168, 92);
            this.btnBids.TabIndex = 4;
            this.btnBids.Text = "AVALIABLE BIDS";
            this.btnBids.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBids.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBids.UseSelectable = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackgroundImage = global::MacroComm_HelpDesk.Properties.Resources.upload;
            this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoice.Location = new System.Drawing.Point(392, 58);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(168, 75);
            this.btnInvoice.TabIndex = 3;
            this.btnInvoice.Text = "DOWNLOAD INVOICE";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInvoice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnInvoice.UseSelectable = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnVendorPortal
            // 
            this.btnVendorPortal.BackgroundImage = global::MacroComm_HelpDesk.Properties.Resources.round_account_button_with_user_inside;
            this.btnVendorPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVendorPortal.Location = new System.Drawing.Point(47, 58);
            this.btnVendorPortal.Name = "btnVendorPortal";
            this.btnVendorPortal.Size = new System.Drawing.Size(168, 75);
            this.btnVendorPortal.TabIndex = 3;
            this.btnVendorPortal.Text = "VENDOR PORTAL";
            this.btnVendorPortal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendorPortal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVendorPortal.UseSelectable = true;
            this.btnVendorPortal.Click += new System.EventHandler(this.btnVendorPortal_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.lblHeader);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(230, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1018, 100);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MacroComm_HelpDesk.Properties.Resources.Government_logoB;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHeader.Location = new System.Drawing.Point(385, 40);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(91, 25);
            this.lblHeader.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Welcome";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MacroComm_HelpDesk.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 573);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.gbVendorPortal);
            this.Controls.Add(this.gbConsumerPortal);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmLanding";
            this.Text = "Local Municipal";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.SlateGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLanding_Load);
            this.metroPanel1.ResumeLayout(false);
            this.gbConsumerPortal.ResumeLayout(false);
            this.gbConsumerPortal.PerformLayout();
            this.gbVendorPortal.ResumeLayout(false);
            this.gbVendorPortal.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime;
        private System.Windows.Forms.GroupBox gbConsumerPortal;
        private System.Windows.Forms.GroupBox gbVendorPortal;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnAlert;
        private MetroFramework.Controls.MetroButton btnConsumerPortal;
        private MetroFramework.Controls.MetroButton btnFaultLog;
        private MetroFramework.Controls.MetroButton btnBids;
        private MetroFramework.Controls.MetroButton btnInvoice;
        private MetroFramework.Controls.MetroButton btnVendorPortal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowserNewFeed;
    }
}

