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
    public partial class Nazn : Form
    {
        public Nazn()
        {
            InitializeComponent();
        }

        private void buttonExitNazn_menD_Click(object sender, EventArgs e)
        {
            Forms.manevrdisp.Show();
            this.Hide();
        }

        private void Nazn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов". При необходимости она может быть перемещена или удалена.
            this.список_железнодорожных_узловTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Назначение_вагонов". При необходимости она может быть перемещена или удалена.
            this.назначение_вагоновTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Назначение_вагонов);

        }

        private void buttonReportNazn_Click(object sender, EventArgs e)
        {
          Form rt = new ReportNazn();
          rt.Show();
        }
    }
}
