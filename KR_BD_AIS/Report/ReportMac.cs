using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_BD_AIS.Report
{
    public partial class ReportMac : Form
    {
        public ReportMac()
        {
            InitializeComponent();
        }

        private void ReportMac_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.RepMacView". При необходимости она может быть перемещена или удалена.
            this.repMacViewTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.RepMacView);

            this.reportViewer1.RefreshReport();
        }
    }
}
