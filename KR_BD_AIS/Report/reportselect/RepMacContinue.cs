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
    public partial class RepMacContinue : Form
    {
        public RepMacContinue()
        {
            InitializeComponent();
        }

        private void RepMacContinue_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.mactimesmenView1". При необходимости она может быть перемещена или удалена.
            this.mactimesmenView1TableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.mactimesmenView1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.VanTrainView". При необходимости она может быть перемещена или удалена.
            this.VanTrainViewTableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.VanTrainView);

            this.reportViewer1.RefreshReport();
        }
    }
}
