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
    public partial class OfficerUpdateUserControl : UserControl
    {
        private DataBaseAccess Da { get; set; }
        public OfficerUpdateUserControl()
        {
            InitializeComponent();
            this.Da = new DataBaseAccess();
            this.PolulatedGridView();
        }
        public void PolulatedGridView(string sql = "select * from Officer;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUpdateOfficer.AutoGenerateColumns = false;
            this.dgvUpdateOfficer.DataSource = ds.Tables[0];
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Officer where Account_No like '" + this.txtSeachForUpdateOfficer.Text + "%';";
                this.PolulatedGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error Occure " + exc.Message);
            }
        }

        private void btnUpdateOfficer_Click(object sender, EventArgs e)
        {
            try
            {
               // if (String.IsNullOrEmpty(this.txtUpdateOfficerId.Text) || String.IsNullOrEmpty(this.txtUpdateOfficerPassword.Text) || String.IsNullOrEmpty(this.txtUpdateOfficerAccountNo.Text) || String.IsNullOrEmpty(this.txtUpdateOfficerAccountName.Text) || String.IsNullOrEmpty(this.dtpUpdateOfficer.Text) || String.IsNullOrEmpty(this.txtUpdateOfficerPhoneNo.Text) || String.IsNullOrEmpty(this.txtUpdateOfficerAddress.Text) || String.IsNullOrEmpty(this.txtUpdateOfficerRole.Text))
                //{
                //    MessageBox.Show("Insert all the information ");
                 //   return;
                //}
                string query = "Select * from Officer where O_Id = '" + this.txtUpdateOfficerId.Text + "';";
                var ds = Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    string sql = "update Officer set O_Password='" + this.txtUpdateOfficerPassword.Text + "',Account_Name='" + this.txtUpdateOfficerAccountName + "',AccountCreateDate='" + this.dtpUpdateOfficer.Text + "',C_PhoneNo='" + this.txtUpdateOfficerPhoneNo.Text + "',C_Address='" + this.txtUpdateOfficerAddress.Text + "',Role='" + this.txtUpdateOfficerRole.Text + "' where Account_NO='" + this.txtUpdateOfficerAccountNo.Text + "';";
                    int count = Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Update Done");
                        
                    }
                    else
                        MessageBox.Show("Data Update fail");
                }
                else
                    

                    this.PolulatedGridView();

            }
            catch(Exception exc)
            {
                MessageBox.Show("Error Occure " + exc.Message);
            }                                                               
        }

        private void dgvUpdateOfficer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtUpdateOfficerId.Text = this.dgvUpdateOfficer.CurrentRow.Cells["O_Id"].Value.ToString();
                this.txtUpdateOfficerPassword.Text = this.dgvUpdateOfficer.CurrentRow.Cells["O_Password"].Value.ToString();
                this.txtUpdateOfficerAccountNo.Text = this.dgvUpdateOfficer.CurrentRow.Cells["Account_No"].Value.ToString();
                this.txtUpdateOfficerAccountName.Text = this.dgvUpdateOfficer.CurrentRow.Cells["Account_Name"].Value.ToString();
                this.dtpUpdateOfficer.Text = this.dgvUpdateOfficer.CurrentRow.Cells["AccountCreateDate"].Value.ToString();
                this.txtUpdateOfficerPhoneNo.Text = this.dgvUpdateOfficer.CurrentRow.Cells["C_PhoneNo"].Value.ToString();
                this.txtUpdateOfficerAddress.Text = this.dgvUpdateOfficer.CurrentRow.Cells["C_Address"].Value.ToString();
                this.txtUpdateOfficerRole.Text = this.dgvUpdateOfficer.CurrentRow.Cells["Role"].Value.ToString();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error Occure " + exc.Message);
            }
            
        }
    }
}
