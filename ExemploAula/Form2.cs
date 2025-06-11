using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploAula
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }
    }
}
