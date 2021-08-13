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
    public partial class OfficerDeleteUserControl : UserControl
    {
        private DataBaseAccess Da { get; set; }
        public OfficerDeleteUserControl()
        {
            InitializeComponent();
            this.Da = new DataBaseAccess();
            this.PolulatedGridView();
        }
        public void PolulatedGridView(string sql = "select * from Officer;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvDeleteOfficer.AutoGenerateColumns = false;
            this.dgvDeleteOfficer.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Officer where Account_No like '" + this.txtSearchForDelete.Text + "%';";
                this.PolulatedGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error Occure " + exc.Message);
            }
        }
        private void btnRemoveOfficer_Click(object sender, EventArgs e)
        {
            try
            {
                var Account_No = this.dgvDeleteOfficer.CurrentRow.Cells[2].Value.ToString();
                string sql = "delete from Officer where Account_No='"+Account_No+"';";

                int count = Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show(Account_No+" has been  Remove ");
                }
                else
                    MessageBox.Show("Data Remove fail");

                this.PolulatedGridView();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error Occure " + exc.Message);
            }
        }
    }
}
