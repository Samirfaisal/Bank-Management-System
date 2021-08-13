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
    public partial class OfficerSearchUserControl : UserControl
    {
        private DataBaseAccess Da { get; set; }
        public OfficerSearchUserControl()
        {
            InitializeComponent();
            this.Da = new DataBaseAccess();
            this.PolulatedGridView();
        }
        public void PolulatedGridView(string sql="select * from Officer;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSearchOfficer.AutoGenerateColumns = false;
            this.dgvSearchOfficer.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Officer where Account_No like '" + this.txtSearch.Text + "%';";
                this.PolulatedGridView(sql);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error Occure " + exc.Message);
            }
            
        }
    }
}
