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
    public partial class Van : Form
    {
        SqlConnection conn = null;
        SqlDataReader dataReader;

        string connectionString = @"Data Source=LENOVO-B5080;Initial Catalog=АИС_жд_узлаSQL;Integrated Security=True";
        public Van()
        {
            InitializeComponent();
        }

        private void buttonExitVan_menD_Click(object sender, EventArgs e)
        {
            Forms.manevrdisp.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Van_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Назначение_вагонов". При необходимости она может быть перемещена или удалена.
            this.назначение_вагоновTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Назначение_вагонов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Прибывающие_поезда". При необходимости она может быть перемещена или удалена.
            this.прибывающие_поездаTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Прибывающие_поезда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Вагоны". При необходимости она может быть перемещена или удалена.
            this.вагоныTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Вагоны);


        }

        private void buttonReportVan_Click(object sender, EventArgs e)
        {
            Form rt = new Report.ReportVan();
            rt.Show();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "vanTrai_proc";
            string trainPar = Convert.ToString(comboBoxSearch.Text);
            myCommand.Parameters.Add("@trainPar", SqlDbType.Int);
            myCommand.Parameters["@trainPar"].Value = trainPar;
            conn.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                // Создаем переменные, получаем для них значения из объекта dataReader,
                //используя метод GetТипДанных
                //int Idvan = dataReader.GetInt32(0);
                //string Nazn = dataReader.GetString(1);
               // int Ves = dataReader.GetInt32(2);
                //Выводим данные в элемент listBox1
                //listBox1.Items.Add("Название локомотива: " + NazvLoc + " Нахождение локомотива на узле: " + LocUz);
                //Создаем экземпляр item класса ListViewItem для записи в него
                //данных из dataReader
                ListViewItem item = new ListViewItem(new string[] { Convert.ToString(dataReader[0]), Convert.ToString(dataReader[1]), Convert.ToString(dataReader[2]) });
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        private void buttonSearchSumVan_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();       
            myCommand.CommandText = "SELECT dbo.[Список железнодорожных узлов].[Название ж/д узла] AS Названиеждузла, COUNT(dbo.Вагоны.ID_вагона) AS Количество_вагонов FROM dbo.[Список железнодорожных узлов] INNER JOIN dbo.Назначение_вагонов ON dbo.[Список железнодорожных узлов].Код = dbo.Назначение_вагонов.[Ж/д узла] INNER JOIN dbo.Вагоны ON dbo.Назначение_вагонов.Назначение_вагонов = dbo.Вагоны.Назначение GROUP BY dbo.[Список железнодорожных узлов].[Название ж/д узла]";
            conn.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                //Создаем экземпляр item класса ListViewItem для записи в него
                //данных из dataReader
                ListViewItem item = new ListViewItem(new string[] { Convert.ToString(dataReader[0]), Convert.ToString(dataReader[1])});
                listView2.Items.Add(item);
            }
            conn.Close();
        }
    }
}
