using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_BD_AIS.Report.reportselect
{
    public partial class RepLocStay : Form
    {
        public RepLocStay()
        {
            InitializeComponent();
        }

        private void RepLocStay_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.locstayView1". При необходимости она может быть перемещена или удалена.
            this.locstayView1TableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.locstayView1);

            this.reportViewer1.RefreshReport();
        }
    }
}
