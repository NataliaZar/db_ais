namespace KR_BD_AIS.Report.reportselect
{
    partial class RepVanTrain
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vanTrainViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vanTrainViewTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.VanTrainViewTableAdapter();
            this.vanTraiprocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanTrai_procTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.vanTrai_procTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vanTrainViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanTraiprocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vanTrainViewBindingSource
            // 
            this.vanTrainViewBindingSource.DataMember = "VanTrainView";
            this.vanTrainViewBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // аИС_жд_узлаSQLDataSet
            // 
            this.аИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.аИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vanTrainViewBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.vanTraiprocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.Report.reportselect.RepVanTrain.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(528, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // vanTrainViewTableAdapter
            // 
            this.vanTrainViewTableAdapter.ClearBeforeFill = true;
            // 
            // vanTraiprocBindingSource
            // 
            this.vanTraiprocBindingSource.DataMember = "vanTrai_proc";
            this.vanTraiprocBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // vanTrai_procTableAdapter
            // 
            this.vanTrai_procTableAdapter.ClearBeforeFill = true;
            // 
            // RepVanTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 478);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepVanTrain";
            this.Text = "Отчёт \"Вагоны поезда\"";
            this.Load += new System.EventHandler(this.RepVanTrain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vanTrainViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanTraiprocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private АИС_жд_узлаSQLDataSet аИС_жд_узлаSQLDataSet;
        private System.Windows.Forms.BindingSource vanTrainViewBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.VanTrainViewTableAdapter vanTrainViewTableAdapter;
        private System.Windows.Forms.BindingSource vanTraiprocBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.vanTrai_procTableAdapter vanTrai_procTableAdapter;
    }
}