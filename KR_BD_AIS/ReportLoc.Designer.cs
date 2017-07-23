namespace KR_BD_AIS
{
    partial class ReportLoc
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
            this.RepLocViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.АИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.RepLocViewTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.RepLocViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RepLocViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.АИС_жд_узлаSQLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RepLocViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.ReportLoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(941, 497);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepLocViewBindingSource
            // 
            this.RepLocViewBindingSource.DataMember = "RepLocView";
            this.RepLocViewBindingSource.DataSource = this.АИС_жд_узлаSQLDataSet;
            // 
            // АИС_жд_узлаSQLDataSet
            // 
            this.АИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.АИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepLocViewTableAdapter
            // 
            this.RepLocViewTableAdapter.ClearBeforeFill = true;
            // 
            // ReportLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 497);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportLoc";
            this.Text = "Отчёт \"Локомотивы\"";
            this.Load += new System.EventHandler(this.ReportLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepLocViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.АИС_жд_узлаSQLDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepLocViewBindingSource;
        private АИС_жд_узлаSQLDataSet АИС_жд_узлаSQLDataSet;
        private АИС_жд_узлаSQLDataSetTableAdapters.RepLocViewTableAdapter RepLocViewTableAdapter;
    }
}