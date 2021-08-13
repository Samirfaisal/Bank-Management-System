using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class GeneralOfficer : Form
    {
       
        private Login Log { get; set; }
        public GeneralOfficer()
        {
            InitializeComponent();           
        }
        public GeneralOfficer(Login log)
        {
            InitializeComponent();
            this.Log = log;
        }
        private void btnInsertOfficer_Click(object sender, EventArgs e)
        {
            
            OfficerInsertUserControl oiuc = new OfficerInsertUserControl();
            this.panelGrideView.Controls.Clear();
            this.panelGrideView.Controls.Add(oiuc);
        }

        private void GeneralOfficer_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("App Closed");
            Application.Exit();
        }
        
        private void btnSearchGeneralOfficer_Click(object sender, EventArgs e)
        {

            OfficerSearchUserControl uc1 = new OfficerSearchUserControl();
            this.panelGrideView.Controls.Clear();
            this.panelGrideView.Controls.Add(uc1);           
        }

        private void btnRemoveOfficer_Click(object sender, EventArgs e)
        {
            OfficerDeleteUserControl odc = new OfficerDeleteUserControl();
            this.panelGrideView.Controls.Clear();
            this.panelGrideView.Controls.Add(odc);
        }

        private void btnUpdateOfficer_Click(object sender, EventArgs e)
        {
            OfficerUpdateUserControl ouuc = new OfficerUpdateUserControl();
            this.panelGrideView.Controls.Clear();
            this.panelGrideView.Controls.Add(ouuc);
        }
    }
}
