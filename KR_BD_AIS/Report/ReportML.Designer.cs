namespace KR_BD_AIS.Report
{
    partial class ReportML
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.repMLViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repMLViewTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.RepMLViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.repMLViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // repMLViewBindingSource
            // 
            this.repMLViewBindingSource.DataMember = "RepMLView";
            this.repMLViewBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // аИС_жд_узлаSQLDataSet
            // 
            this.аИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.аИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.repMLViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.Report.ReportML.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // repMLViewTableAdapter
            // 
            this.repMLViewTableAdapter.ClearBeforeFill = true;
            // 
            // ReportML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 427);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт \"Способность машиниста водить локомотив\"";
            this.Load += new System.EventHandler(this.ReportML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repMLViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private АИС_жд_узлаSQLDataSet аИС_жд_узлаSQLDataSet;
        private System.Windows.Forms.BindingSource repMLViewBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.RepMLViewTableAdapter repMLViewTableAdapter;
    }
}