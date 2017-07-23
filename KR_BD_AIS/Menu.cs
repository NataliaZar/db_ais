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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Equals("manevr") && textBoxPassword.Text.Equals("1234"))
            {
                Forms.manevrdisp.Show();
                this.Hide();
                this.textBoxLogin.Text = "";
                this.textBoxPassword.Text = "";

            }

            if (textBoxLogin.Text.Equals("locom") && textBoxPassword.Text.Equals("4321"))
            {
                Forms.locdisp.Show();
                this.Hide();
                this.textBoxLogin.Text = "";
                this.textBoxPassword.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
