using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_BD_AIS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonManevrDisp_Click(object sender, EventArgs e)
        {
           Forms.manevrdisp.Show();
           this.Hide();
        }

        private void buttonLocDisp_Click(object sender, EventArgs e)
        {
            Forms.locdisp.Show();
            this.Hide();
        }
    }
}
