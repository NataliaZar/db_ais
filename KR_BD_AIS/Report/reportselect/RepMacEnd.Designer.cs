namespace KR_BD_AIS
{
    partial class RepMacEnd
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
            this.АИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.macfinishView1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.macfinishView1TableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.macfinishView1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.АИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macfinishView1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.macfinishView1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.Report.reportselect.RepMacEnd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(827, 457);
            this.reportViewer1.TabIndex = 0;
            // 
            // АИС_жд_узлаSQLDataSet
            // 
            this.АИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.АИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // macfinishView1BindingSource
            // 
            this.macfinishView1BindingSource.DataMember = "macfinishView1";
            this.macfinishView1BindingSource.DataSource = this.АИС_жд_узлаSQLDataSet;
            // 
            // macfinishView1TableAdapter
            // 
            this.macfinishView1TableAdapter.ClearBeforeFill = true;
            // 
            // RepMacEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 457);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepMacEnd";
            this.Text = "Отчёт \"Время окончания дежурства машинистов\"";
            this.Load += new System.EventHandler(this.RepMacEnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.АИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macfinishView1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource macfinishView1BindingSource;
        private АИС_жд_узлаSQLDataSet АИС_жд_узлаSQLDataSet;
        private АИС_жд_узлаSQLDataSetTableAdapters.macfinishView1TableAdapter macfinishView1TableAdapter;
    }
}