namespace KR_BD_AIS
{
    partial class ReportInTrain
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Прибывающие_поездаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.АИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.МашинистыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepInTrainViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отправляющиеся_поездаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отправляющиеся_поездаTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.Отправляющиеся_поездаTableAdapter();
            this.Прибывающие_поездаTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.Прибывающие_поездаTableAdapter();
            this.МашинистыTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.МашинистыTableAdapter();
            this.RepInTrainViewTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.RepInTrainViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Прибывающие_поездаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.АИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.МашинистыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepInTrainViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отправляющиеся_поездаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Прибывающие_поездаBindingSource
            // 
            this.Прибывающие_поездаBindingSource.DataMember = "Прибывающие_поезда";
            this.Прибывающие_поездаBindingSource.DataSource = this.АИС_жд_узлаSQLDataSet;
            // 
            // АИС_жд_узлаSQLDataSet
            // 
            this.АИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.АИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // МашинистыBindingSource
            // 
            this.МашинистыBindingSource.DataMember = "Машинисты";
            this.МашинистыBindingSource.DataSource = this.АИС_жд_узлаSQLDataSet;
            // 
            // RepInTrainViewBindingSource
            // 
            this.RepInTrainViewBindingSource.DataMember = "RepInTrainView";
            this.RepInTrainViewBindingSource.DataSource = this.АИС_жд_узлаSQLDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportInTrain";
            reportDataSource1.Value = this.Прибывающие_поездаBindingSource;
            reportDataSource2.Name = "ReportMac";
            reportDataSource2.Value = this.МашинистыBindingSource;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.RepInTrainViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD_AIS.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1079, 462);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отправляющиеся_поездаBindingSource
            // 
            this.Отправляющиеся_поездаBindingSource.DataMember = "Отправляющиеся_поезда";
            this.Отправляющиеся_поездаBindingSource.DataSource = this.АИС_жд_узлаSQLDataSet;
            // 
            // Отправляющиеся_поездаTableAdapter
            // 
            this.Отправляющиеся_поездаTableAdapter.ClearBeforeFill = true;
            // 
            // Прибывающие_поездаTableAdapter
            // 
            this.Прибывающие_поездаTableAdapter.ClearBeforeFill = true;
            // 
            // МашинистыTableAdapter
            // 
            this.МашинистыTableAdapter.ClearBeforeFill = true;
            // 
            // RepInTrainViewTableAdapter
            // 
            this.RepInTrainViewTableAdapter.ClearBeforeFill = true;
            // 
            // ReportInTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 462);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportInTrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт \"Прибывающие поезда\"";
            this.Load += new System.EventHandler(this.ReportOutTrain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Прибывающие_поездаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.АИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.МашинистыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepInTrainViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отправляющиеся_поездаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отправляющиеся_поездаBindingSource;
        private АИС_жд_узлаSQLDataSet АИС_жд_узлаSQLDataSet;
        private АИС_жд_узлаSQLDataSetTableAdapters.Отправляющиеся_поездаTableAdapter Отправляющиеся_поездаTableAdapter;
        private System.Windows.Forms.BindingSource Прибывающие_поездаBindingSource;
        private System.Windows.Forms.BindingSource МашинистыBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.Прибывающие_поездаTableAdapter Прибывающие_поездаTableAdapter;
        private АИС_жд_узлаSQLDataSetTableAdapters.МашинистыTableAdapter МашинистыTableAdapter;
        private System.Windows.Forms.BindingSource RepInTrainViewBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.RepInTrainViewTableAdapter RepInTrainViewTableAdapter;
    }
}