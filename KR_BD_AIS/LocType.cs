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
    public partial class LocType : Form
    {
        public LocType()
        {
            InitializeComponent();
        }

        private void buttonExitLocType_locD_Click(object sender, EventArgs e)
        {
            Forms.loc.Show();
            this.Hide();
        }

        private void LocType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Список_типов_локомотивов". При необходимости она может быть перемещена или удалена.
            this.список_типов_локомотивовTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Список_типов_локомотивов);

        }

        private void buttonSaveLocType_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.списокТиповЛокомотивовBindingSource.EndEdit();
                this.список_типов_локомотивовTableAdapter.Update(this.аИС_жд_узлаSQLDataSet.Список_типов_локомотивов);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:Update failed");
            }
        }

        private void buttonReportLocType_Click(object sender, EventArgs e)
        {
            Form rt = new Report.ReportLocType();
            rt.Show();
        }
    }
}
