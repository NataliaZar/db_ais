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
    public partial class GD : Form
    {
        public GD()
        {
            InitializeComponent();
        }

        private void buttonExitGD_menD_Click(object sender, EventArgs e)
        {
            Forms.manevrdisp.Show();
            this.Hide();
        }

        private void GD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов". При необходимости она может быть перемещена или удалена.
            this.список_железнодорожных_узловTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов);

        }

        private void buttonSaveGD_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.списокЖелезнодорожныхУзловBindingSource.EndEdit();
                this.список_железнодорожных_узловTableAdapter.Update(this.аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:Update failed");
            }
        }

        private void buttonReportGD_Click(object sender, EventArgs e)
        {
            Form rt = new ReportGD();
            rt.Show();
        }
    }
}
