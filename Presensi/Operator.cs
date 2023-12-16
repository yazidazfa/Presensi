using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presensi
{
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Hide the current form (which is the admin form)
            this.Close();

            // Show the login Form1 again
            Form1 form1 = Form1.GetMainFormInstance();
            form1.Show();
        }
    }
}
