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
    public partial class OfficerInsertUserControl : UserControl
    {
        private DataBaseAccess Da { get; set; }
        public OfficerInsertUserControl()
        {
            InitializeComponent();
            this.Da = new DataBaseAccess();
            this.PolulatedGridView();
        }
        public void PolulatedGridView(string sql = "select * from Officer;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvInsertOfficer.AutoGenerateColumns = false;
            this.dgvInsertOfficer.DataSource = ds.Tables[0];
        }

        private void btnInsertOfficer_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(this.txtO_Id.Text) || String.IsNullOrEmpty(this.txtO_Password.Text) || String.IsNullOrEmpty(this.txtAccount_No .Text) || String.IsNullOrEmpty(this.txtAccount_Name.Text) || String.IsNullOrEmpty(this.dtpInsertOfficer.Text) || String.IsNullOrEmpty(this.txtC_PhoneNo.Text) || String.IsNullOrEmpty(this.txtC_Address.Text) || String.IsNullOrEmpty(this.txtRole.Text))
                {
                    MessageBox.Show("Insert all the information ");
                    return;
                }
                string sql = "insert into Officer values ('" + this.txtO_Id.Text + "','" + this.txtO_Password.Text + "','" + this.txtAccount_No.Text + "', '" + this.txtAccount_Name.Text + "','" + this.dtpInsertOfficer.Text + "','" + txtC_PhoneNo.Text + "','" + this.txtC_Address.Text + "','" + this.txtRole.Text + "');";
                int count = Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Data Insert Done");
                }
                else
                    MessageBox.Show("Data Insert fail");

                this.PolulatedGridView();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error Occure " + exc.Message);
            }
            
        }

    }
}
