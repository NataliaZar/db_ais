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
    public partial class Machinist : Form
    {
        SqlConnection conn = null;
        SqlDataReader dataReader;

        string connectionString = @"Data Source=LENOVO-B5080;Initial Catalog=АИС_жд_узлаSQL;Integrated Security=True";
        public Machinist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitMach_locD_Click(object sender, EventArgs e)
        {
            Forms.locdisp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.ml.Show();
            this.Hide();
        }

        private void Machinist_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Депо". При необходимости она может быть перемещена или удалена.
            this.депоTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Депо);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Машинисты". При необходимости она может быть перемещена или удалена.
            this.машинистыTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Машинисты);

        }

        private void buttonSaveMach_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.машинистыBindingSource.EndEdit();
                this.машинистыTableAdapter.Update(this.аИС_жд_узлаSQLDataSet.Машинисты);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:Update failed");
            }
        }

        private void buttonReportMach_Click(object sender, EventArgs e)
        {
            Form rt = new Report.ReportMac();
            rt.Show();
        }       

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "mactime_proc ";
            string fioPar = Convert.ToString(comboBoxSearch.Text);
            myCommand.Parameters.Add("@fioPar", SqlDbType.NVarChar, 255);
            myCommand.Parameters["@fioPar"].Value = fioPar;
            conn.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                //Создаем экземпляр item класса ListViewItem для записи в него
                //данных из dataReader
                ListViewItem item = new ListViewItem(new string[] { Convert.ToString(dataReader[0]), Convert.ToString(dataReader[1]), Convert.ToString(dataReader[2]) });
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        private void buttonSearchTimeFinish_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            //myCommand.CommandType = CommandType.TableDirect;
            myCommand.CommandText = "SELECT Время_окончания_дежурства, ФИО_машиниста FROM dbo.Машинисты WHERE(Время_окончания_дежурства >= GETDATE())";
            // string fioPar = Convert.ToString(comboBoxSearch.Text);
            // myCommand.Parameters.Add("@fioPar", SqlDbType.DateTime);
            // myCommand.Parameters["@fioPar"].Value = fioPar;
            conn.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                // Создаем переменные, получаем для них значения из объекта dataReader,
                //используя метод GetТипДанных
                //string NazvLoc = dataReader.GetString(0);
                //bool LocUz = dataReader.GetBoolean(1);
                //Выводим данные в элемент listBox1
                //listBox1.Items.Add("Название локомотива: " + NazvLoc + " Нахождение локомотива на узле: " + LocUz);
                //Создаем экземпляр item класса ListViewItem для записи в него
                //данных из dataReader
                ListViewItem item = new ListViewItem(new string[] { Convert.ToString(dataReader[0]), Convert.ToString(dataReader[1]) });
                listView2.Items.Add(item);
            }
            conn.Close();
        }
    }
}
