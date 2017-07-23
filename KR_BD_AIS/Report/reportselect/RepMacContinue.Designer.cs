namespace KR_BD_AIS
{
    partial class RepMacContinue
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
            this.VanTrainViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.АИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VanTrainViewTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.VanTrainViewTableAdapter();
            this.mactimesmenView1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mactimesmenView1TableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.mactimesmenView1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VanTrainViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.АИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mactimesmenView1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VanTrainViewBindingSource
            // 
            this.VanTrainViewBindingSource.DataMember = "VanTrainView";
            this.VanTrainViewBindingSource.DataSource = this.АИС_жд_узлаSQLDataSet;
            // 
            // АИС_жд_узлаSQLDataSet
            // 
            this.АИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.АИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mactimesmenView1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.Report.reportselect.RepMacContinue.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1029, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // VanTrainViewTableAdapter
            // 
            this.VanTrainViewTableAdapter.ClearBeforeFill = true;
            // 
            // mactimesmenView1BindingSource
            // 
            this.mactimesmenView1BindingSource.DataMember = "mactimesmenView1";
            this.mactimesmenView1BindingSource.DataSource = this.АИС_жд_узлаSQLDataSet;
            // 
            // mactimesmenView1TableAdapter
            // 
            this.mactimesmenView1TableAdapter.ClearBeforeFill = true;
            // 
            // RepMacContinue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 449);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepMacContinue";
            this.Text = "Отчёт \"Продолжительность смены машиниста\"";
            this.Load += new System.EventHandler(this.RepMacContinue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VanTrainViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.АИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mactimesmenView1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VanTrainViewBindingSource;
        private АИС_жд_узлаSQLDataSet АИС_жд_узлаSQLDataSet;
        private АИС_жд_узлаSQLDataSetTableAdapters.VanTrainViewTableAdapter VanTrainViewTableAdapter;
        private System.Windows.Forms.BindingSource mactimesmenView1BindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.mactimesmenView1TableAdapter mactimesmenView1TableAdapter;
    }
}