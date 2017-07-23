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
    public partial class ReportVan : Form
    {
        public ReportVan()
        {
            InitializeComponent();
        }

        private void ReportVan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.RepVanView". При необходимости она может быть перемещена или удалена.
            this.repVanViewTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.RepVanView);

            this.reportViewer1.RefreshReport();
        }
    }
}
