﻿using System;
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
    public partial class RepMacEnd : Form
    {
        public RepMacEnd()
        {
            InitializeComponent();
        }

        private void RepMacEnd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АИС_жд_узлаSQLDataSet.macfinishView1". При необходимости она может быть перемещена или удалена.
            this.macfinishView1TableAdapter.Fill(this.АИС_жд_узлаSQLDataSet.macfinishView1);

            this.reportViewer1.RefreshReport();
        }
    }
}
