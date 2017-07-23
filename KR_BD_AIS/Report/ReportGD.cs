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
    public partial class ReportGD : Form
    {
        public ReportGD()
        {
            InitializeComponent();
        }

        private void ReportGD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.RepGDView". При необходимости она может быть перемещена или удалена.
            this.RepGDViewTableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.RepGDView);

            this.reportViewer1.RefreshReport();
        }
    }
}
