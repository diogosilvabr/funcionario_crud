using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcionario_crud
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                frmLogin formLogin = new frmLogin();
                formLogin.Show();
                this.Hide();
            }
        }
    }
}
