namespace KR_BD_AIS.Report
{
    partial class ReportLocType
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
            this.repLocTypeViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.аИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.repLocViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repLocViewTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.RepLocViewTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RepLocTypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repLocTypeViewTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.RepLocTypeViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.repLocTypeViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLocViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepLocTypeViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // repLocTypeViewBindingSource1
            // 
            this.repLocTypeViewBindingSource1.DataMember = "RepLocTypeView";
            this.repLocTypeViewBindingSource1.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // аИС_жд_узлаSQLDataSet
            // 
            this.аИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.аИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repLocViewBindingSource
            // 
            this.repLocViewBindingSource.DataMember = "RepLocView";
            this.repLocViewBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // repLocViewTableAdapter
            // 
            this.repLocViewTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LocType";
            reportDataSource1.Value = this.repLocTypeViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.Report.ReportLocType.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(801, 364);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepLocTypeViewBindingSource
            // 
            this.RepLocTypeViewBindingSource.DataMember = "RepLocTypeView";
            this.RepLocTypeViewBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // repLocTypeViewTableAdapter
            // 
            this.repLocTypeViewTableAdapter.ClearBeforeFill = true;
            // 
            // ReportLocType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 364);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportLocType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт \"Список типов локомотивов\"";
            this.Load += new System.EventHandler(this.ReportLocType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repLocTypeViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLocViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepLocTypeViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private АИС_жд_узлаSQLDataSet аИС_жд_узлаSQLDataSet;
        private System.Windows.Forms.BindingSource repLocViewBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.RepLocViewTableAdapter repLocViewTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepLocTypeViewBindingSource;
        private System.Windows.Forms.BindingSource repLocTypeViewBindingSource1;
        private АИС_жд_узлаSQLDataSetTableAdapters.RepLocTypeViewTableAdapter repLocTypeViewTableAdapter;
    }
}