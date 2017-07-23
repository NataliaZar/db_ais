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
    public partial class locDisp : Form
    {
        public locDisp()
        {
            InitializeComponent();
        }

        private void buttonExitMainMenu_Click(object sender, EventArgs e)
        {
            Forms.menu.Show();
            this.Hide();
        }

        private void buttonMachinist_Click(object sender, EventArgs e)
        {
            Forms.machinist.Show();
            this.Hide();
        }

        private void buttonLocomotive_Click(object sender, EventArgs e)
        {
            Forms.loc.Show();
            this.Hide();
        }

        private void buttonDepo_Click(object sender, EventArgs e)
        {
            Forms.depo.Show();
            this.Hide();
        }
    }
}
