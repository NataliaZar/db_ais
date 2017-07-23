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
    public partial class RepVanTrain : Form
    {
        public RepVanTrain()
        {
            InitializeComponent();
        }

        private void RepVanTrain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.VanTrainView". При необходимости она может быть перемещена или удалена.
            this.vanTrainViewTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.VanTrainView);

            this.reportViewer1.RefreshReport();
        }
    }
}
