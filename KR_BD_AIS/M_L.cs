using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KR_BD_AIS
{
    public partial class M_L : Form
    {
        SqlConnection conn = null;
        SqlDataReader dataReader;

        string connectionString = @"Data Source=LENOVO-B5080;Initial Catalog=АИС_жд_узлаSQL;Integrated Security=True";
        public M_L()
        {
            InitializeComponent();
        }

        private void buttonExitML_locD_Click(object sender, EventArgs e)
        {
            Forms.machinist.Show();
            this.Hide();
        }

        private void M_L_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Список_типов_локомотивов". При необходимости она может быть перемещена или удалена.
            this.список_типов_локомотивовTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Список_типов_локомотивов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Локомотивы". При необходимости она может быть перемещена или удалена.
            this.локомотивыTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Локомотивы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Машинисты". При необходимости она может быть перемещена или удалена.
            this.машинистыTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Машинисты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Способность_машиниста_водить_локомотив". При необходимости она может быть перемещена или удалена.
            this.способность_машиниста_водить_локомотивTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Способность_машиниста_водить_локомотив);

        }

        private void buttonSaveML_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.способностьМашинистаВодитьЛокомотивBindingSource.EndEdit();
                this.способность_машиниста_водить_локомотивTableAdapter.Update(this.аИС_жд_узлаSQLDataSet.Способность_машиниста_водить_локомотив);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:Update failed");
            }
        }

        private void buttonReportML_Click(object sender, EventArgs e)
        {
            Form rt = new Report.ReportML();
            rt.Show();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "ml_proc";
            string macPar = Convert.ToString(comboBoxSearch.Text);
            myCommand.Parameters.Add("@macPar", SqlDbType.NVarChar, 255);
            myCommand.Parameters["@macPar"].Value = macPar;
            conn.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                // Создаем переменные, получаем для них значения из объекта dataReader,
                //используя метод GetТипДанных
                string LocName = dataReader.GetString(0);
                //Выводим данные в элемент listBox1
                listBox1.Items.Add(LocName);
            }
            conn.Close();
        }
    }
}
