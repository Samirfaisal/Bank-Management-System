using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BankManagement
{
    public partial class Login : Form
    {
        private DataBaseAccess Da { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Da = new DataBaseAccess();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
                string sql = "select * from Officer where O_Id ='" + this.txtUserId.Text + "' and O_Password='" + this.txtPassword.Text + "';";
                DataSet ds = Da.ExecuteQuery(sql);
           // DataTable dt = new DataTable();
            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                this.ClearContent();
                if (ds.Tables[0].Rows[0][7].ToString() == "Customer")
                {
                    GeneralOfficer go = new GeneralOfficer(this);
                    go.Show();
                }
                else if (ds.Tables[1].Rows[0][4].ToString() == "Admin")
                 {
                     Admin admin = new Admin(this);
                     admin.Show();
                 }
            }
                else
                {
                    MessageBox.Show("Login invalid");
                    this.ClearContent();

                }
        }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Exp");
            //    Application.Exit();
            //}
       // }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
        private void ClearContent()
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }
    }
}
               

