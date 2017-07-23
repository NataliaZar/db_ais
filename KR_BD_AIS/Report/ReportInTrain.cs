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
    public partial class ReportInTrain : Form
    {
        public ReportInTrain()
        {
            InitializeComponent();
        }

        private void ReportOutTrain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.RepInTrainView". При необходимости она может быть перемещена или удалена.
            this.RepInTrainViewTableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.RepInTrainView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.Прибывающие_поезда". При необходимости она может быть перемещена или удалена.
            this.Прибывающие_поездаTableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.Прибывающие_поезда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.Машинисты". При необходимости она может быть перемещена или удалена.
            this.МашинистыTableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.Машинисты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.Отправляющиеся_поезда". При необходимости она может быть перемещена или удалена.
            this.Отправляющиеся_поездаTableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.Отправляющиеся_поезда);

            this.reportViewer1.RefreshReport();
        }
    }
}
