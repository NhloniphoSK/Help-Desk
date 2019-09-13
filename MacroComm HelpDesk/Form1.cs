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
    public partial class frmLanding : MetroFramework.Forms.MetroForm
    {
        public frmLanding()
        {
            InitializeComponent();
        }

        private void frmLanding_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            frmRegistration frmReg = new frmRegistration();
            frmReg.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnFaultLog_Click(object sender, EventArgs e)
        {
            frmSignIn frmIn = new frmSignIn();
            frmIn.Show();
        }

        private void btnConsumerPortal_Click(object sender, EventArgs e)
        {
            frmSignIn frmIn = new frmSignIn();
            frmIn.Show();
        }

        private void btnVendorPortal_Click(object sender, EventArgs e)
        {
            frmSignIn frmIn = new frmSignIn();
            frmIn.Show();
        }

        // String declaration for the timer.
        string[] messages = {
        "Clearner City | Safe City | Friendly environment",
        "All Services at your hand",
        " Log any issues you have with the services",
        "Municipality assistance at a click !"
        };

        int turn = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHeader.Text = messages[turn++];
            turn %= messages.Length;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
