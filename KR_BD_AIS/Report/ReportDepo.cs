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
    public partial class ReportDepo : Form
    {
        public ReportDepo()
        {
            InitializeComponent();
        }

        private void ReportDepo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Депо". При необходимости она может быть перемещена или удалена.
            this.депоTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Депо);

            this.reportViewer1.RefreshReport();
        }
    }
}
