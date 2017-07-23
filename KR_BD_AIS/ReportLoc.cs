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
    public partial class ReportLoc : Form
    {
        public ReportLoc()
        {
            InitializeComponent();
        }

        private void ReportLoc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.RepLocView". При необходимости она может быть перемещена или удалена.
            this.RepLocViewTableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.RepLocView);

            this.reportViewer1.RefreshReport();
        }
    }
}
