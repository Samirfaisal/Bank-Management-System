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
    public partial class Admin : Form
    {
        private Login Log { get; set; }
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(Login log)
        {
            InitializeComponent();
            this.Log = log;
        }
    }
}
