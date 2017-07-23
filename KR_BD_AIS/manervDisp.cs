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
    public partial class manevrDisp : Form
    {
        public manevrDisp()
        {
            InitializeComponent();
        }

        private void buttonExitMainM_Click(object sender, EventArgs e)
        {
            Forms.menu.Show();
            this.Hide();
        }

        private void buttonInTrain_Click(object sender, EventArgs e)
        {
            Forms.itrain.Show();
            this.Hide();
        }

        private void buttonOutTrain_Click(object sender, EventArgs e)
        {
            Forms.outtrain.Show();
            this.Hide();
        }

        private void buttonVan_Click(object sender, EventArgs e)
        {
            Forms.van.Show();
            this.Hide();
        }

        private void buttonNaz_Click(object sender, EventArgs e)
        {
            Forms.nazn.Show();
            this.Hide();
        }

        private void buttonGD_Click(object sender, EventArgs e)
        {
            Forms.gd.Show();
            this.Hide();
        }
    }
}
