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
    public partial class OutTrain : Form
    {
        SqlConnection conn = null;
        SqlDataReader dataReader;

        string connectionString = @"Data Source=LENOVO-B5080;Initial Catalog=АИС_жд_узлаSQL;Integrated Security=True";
        public OutTrain()
        {
            InitializeComponent();
           // comboBox3.SelectedIndex = 0;
        }

        private void buttonExitOuT_menD_Click(object sender, EventArgs e)
        {
            Forms.manevrdisp.Show();
            this.Hide();
        }

        private void OutTrain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Локомотивы". При необходимости она может быть перемещена или удалена.
            this.локомотивыTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Локомотивы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Машинисты". При необходимости она может быть перемещена или удалена.
            this.машинистыTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Машинисты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов". При необходимости она может быть перемещена или удалена.
            this.список_железнодорожных_узловTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Назначение_вагонов". При необходимости она может быть перемещена или удалена.
            this.назначение_вагоновTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Назначение_вагонов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Отправляющиеся_поезда". При необходимости она может быть перемещена или удалена.
            this.отправляющиеся_поездаTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Отправляющиеся_поезда);


        }

        private void buttonSaveOutTrain_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.отправляющиесяпоездаBindingSource.EndEdit();
                this.отправляющиеся_поездаTableAdapter.Update(this.аИС_жд_узлаSQLDataSet.Отправляющиеся_поезда);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:Update failed");
            }
        }

        private void buttonReportOutTrain_Click(object sender, EventArgs e)
        {
            Form rt = new Report.ReportOutTrain();
            rt.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "gd_proc";
            string gdTrain = Convert.ToString(comboBoxSearch.Text);
            myCommand.Parameters.Add("@gdTrain", SqlDbType.NVarChar, 255);
            myCommand.Parameters["@gdTrain"].Value = gdTrain;
            conn.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                //Создаем экземпляр item класса ListViewItem для записи в него
                //данных из dataReader
                ListViewItem item = new ListViewItem(new string[] { Convert.ToString(dataReader[0]), Convert.ToString(dataReader[1]), Convert.ToString(dataReader[2]), Convert.ToString(dataReader[3]), Convert.ToString(dataReader[4]), Convert.ToString(dataReader[5]) });
                listView1.Items.Add(item);
            }
            conn.Close();
        }
    }
}
