namespace KR_BD_AIS.Report.reportselect
{
    partial class RepOutTrainNazn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.аИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.outTrainView1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outTrainView1TableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.OutTrainView1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTrainView1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.outTrainView1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.Report.reportselect.RepOutTrainNazn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(685, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // аИС_жд_узлаSQLDataSet
            // 
            this.аИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.аИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outTrainView1BindingSource
            // 
            this.outTrainView1BindingSource.DataMember = "OutTrainView1";
            this.outTrainView1BindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // outTrainView1TableAdapter
            // 
            this.outTrainView1TableAdapter.ClearBeforeFill = true;
            // 
            // RepOutTrainNazn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 391);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepOutTrainNazn";
            this.Text = "Отчёт \"Отправляющиеся поезда по данному назначению\"";
            this.Load += new System.EventHandler(this.RepOutTrainNazn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTrainView1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private АИС_жд_узлаSQLDataSet аИС_жд_узлаSQLDataSet;
        private System.Windows.Forms.BindingSource outTrainView1BindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.OutTrainView1TableAdapter outTrainView1TableAdapter;
    }
}