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
    public partial class Depo : Form
    {
        public Depo()
        {
            InitializeComponent();
        }

        private void buttonExitDepo_locD_Click(object sender, EventArgs e)
        {
            Forms.locdisp.Show();
            this.Hide();
        }

        private void Depo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Депо". При необходимости она может быть перемещена или удалена.
            this.депоTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Депо);

        }

        private void buttonReportDepo_Click(object sender, EventArgs e)
        {
            Form rt = new Report.ReportDepo();
            rt.Show();
        }
    }
}
