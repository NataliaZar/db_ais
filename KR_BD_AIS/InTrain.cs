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
    public partial class InTrain : Form
    {
        public InTrain()
        {
            InitializeComponent();
        }

        private void buttonExitInT_menD_Click(object sender, EventArgs e)
        {
            Forms.manevrdisp.Show();
            this.Hide();
        }

        private void InTrain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Локомотивы". При необходимости она может быть перемещена или удалена.
            this.локомотивыTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Локомотивы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Машинисты". При необходимости она может быть перемещена или удалена.
            this.машинистыTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Машинисты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Прибывающие_поезда". При необходимости она может быть перемещена или удалена.
            this.прибывающие_поездаTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Прибывающие_поезда);


        }

        private void buttonSaveInTrain_Click(object sender, EventArgs e)
        {
           try
            {
                this.Validate();
                this.прибывающиепоездаBindingSource.EndEdit();
                this.прибывающие_поездаTableAdapter.Update(this.аИС_жд_узлаSQLDataSet.Прибывающие_поезда);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error:Update failed");
            }
        }

        private void buttonReportInTrain_Click(object sender, EventArgs e)
        {
            Form rt = new ReportInTrain();
            rt.Show();
        }
    }
}
