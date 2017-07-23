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
    public partial class ReportLocType : Form
    {
        public ReportLocType()
        {
            InitializeComponent();
        }

        private void ReportLocType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.RepLocTypeView". При необходимости она может быть перемещена или удалена.
            this.repLocTypeViewTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.RepLocTypeView);

            this.reportViewer1.RefreshReport();
        }
    }
}
