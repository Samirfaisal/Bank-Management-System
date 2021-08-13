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
    public partial class Manager : Form
    {
        private Login Log { get; set; }
        public Manager()
        {
            InitializeComponent();
        }
        public Manager(Login log)
        {
            InitializeComponent();
            this.Log = log;
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("App Closed");
            Application.Exit();
        }
    }
}
