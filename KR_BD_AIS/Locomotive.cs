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
    public partial class Locomotive : Form
    {
        SqlConnection conn = null;
        SqlDataReader dataReader;
        
        string connectionString = @"Data Source=LENOVO-B5080;Initial Catalog=АИС_жд_узлаSQL;Integrated Security=True";
      
        public Locomotive()
        {
            InitializeComponent();            
        }

        private void buttonLocType_Click(object sender, EventArgs e)
        {
            Forms.loctype.Show();
            this.Hide();
        }

        private void buttonExitLoc_locD_Click(object sender, EventArgs e)
        {
            Forms.locdisp.Show();
            this.Hide();
        }

        private void Locomotive_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Список_типов_локомотивов". При необходимости она может быть перемещена или удалена.
            this.список_типов_локомотивовTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Список_типов_локомотивов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Депо". При необходимости она может быть перемещена или удалена.
            this.депоTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Депо);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов". При необходимости она может быть перемещена или удалена.
            this.список_железнодорожных_узловTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Список_железнодорожных_узлов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аИС_жд_узлаSQLDataSet.Локомотивы". При необходимости она может быть перемещена или удалена.
            this.локомотивыTableAdapter.Fill(this.аИС_жд_узлаSQLDataSet.Локомотивы);

        }

        private void buttonReportLocType_Click(object sender, EventArgs e)
        {
           Form rt = new ReportLoc();
           rt.Show();
        }

        private void buttonSaveLocType_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.локомотивыBindingSource.EndEdit();
                this.локомотивыTableAdapter.Update(this.аИС_жд_узлаSQLDataSet.Локомотивы);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error:Update failed");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "locstay_proc";
            string NazvLocPar = Convert.ToString(comboBoxSearch.Text);
            myCommand.Parameters.Add("@NazvLocPar", SqlDbType.NVarChar, 255);
            myCommand.Parameters["@NazvLocPar"].Value = NazvLocPar;
            conn.Open();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                // Создаем переменные, получаем для них значения из объекта dataReader,
                string NazvLoc = dataReader.GetString(0);
                bool LocUz = dataReader.GetBoolean(1);
                ListViewItem item = new ListViewItem(new string[]{Convert.ToString(dataReader[0]), Convert.ToString(dataReader[1])});
                listView1.Items.Add(item);
            }
            conn.Close();
        }
    }
}
