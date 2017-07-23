namespace KR_BD_AIS.Report.reportselect
{
    partial class RepVanGD
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.аИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.vanGDView1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanGDView1TableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.VanGDView1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanGDView1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vanGDView1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.Report.reportselect.RepVanGD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(683, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // аИС_жд_узлаSQLDataSet
            // 
            this.аИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.аИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vanGDView1BindingSource
            // 
            this.vanGDView1BindingSource.DataMember = "VanGDView1";
            this.vanGDView1BindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // vanGDView1TableAdapter
            // 
            this.vanGDView1TableAdapter.ClearBeforeFill = true;
            // 
            // RepVanGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 377);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepVanGD";
            this.Text = "Отчёт \"Количество вагонов по железнодорожным узлам\"";
            this.Load += new System.EventHandler(this.RepVanGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanGDView1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private АИС_жд_узлаSQLDataSet аИС_жд_узлаSQLDataSet;
        private System.Windows.Forms.BindingSource vanGDView1BindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.VanGDView1TableAdapter vanGDView1TableAdapter;
    }
}