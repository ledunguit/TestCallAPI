using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCallAPI
{
    public partial class run : Form
    {
        public run(string key = null, string expired = null)
        {
            InitializeComponent();
            lblKeyVal.Text = key;
            lblExpiredVal.Text = expired;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
