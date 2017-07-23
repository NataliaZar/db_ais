namespace KR_BD_AIS
{
    partial class M_L
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_L));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReportML = new System.Windows.Forms.Button();
            this.buttonSaveML = new System.Windows.Forms.Button();
            this.buttonExitML_locD = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.машинистыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.аИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.способностьМашинистаВодитьЛокомотивBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.машинистыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.списокТиповЛокомотивовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.способность_машиниста_водить_локомотивTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.Способность_машиниста_водить_локомотивTableAdapter();
            this.машинистыTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.МашинистыTableAdapter();
            this.способностьМашинистаВодитьЛокомотивBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.локомотивыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.локомотивыTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.ЛокомотивыTableAdapter();
            this.список_типов_локомотивовTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.Список_типов_локомотивовTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.машинистыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.способностьМашинистаВодитьЛокомотивBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.машинистыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокТиповЛокомотивовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.способностьМашинистаВодитьЛокомотивBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.локомотивыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Название лоекомотива";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Машинист";
            // 
            // buttonReportML
            // 
            this.buttonReportML.Location = new System.Drawing.Point(697, 118);
            this.buttonReportML.Name = "buttonReportML";
            this.buttonReportML.Size = new System.Drawing.Size(140, 57);
            this.buttonReportML.TabIndex = 53;
            this.buttonReportML.Text = "Отчёт";
            this.buttonReportML.UseVisualStyleBackColor = true;
            this.buttonReportML.Click += new System.EventHandler(this.buttonReportML_Click);
            // 
            // buttonSaveML
            // 
            this.buttonSaveML.Location = new System.Drawing.Point(697, 55);
            this.buttonSaveML.Name = "buttonSaveML";
            this.buttonSaveML.Size = new System.Drawing.Size(140, 57);
            this.buttonSaveML.TabIndex = 52;
            this.buttonSaveML.Text = "Сохранить";
            this.buttonSaveML.UseVisualStyleBackColor = true;
            this.buttonSaveML.Click += new System.EventHandler(this.buttonSaveML_Click);
            // 
            // buttonExitML_locD
            // 
            this.buttonExitML_locD.Location = new System.Drawing.Point(697, 181);
            this.buttonExitML_locD.Name = "buttonExitML_locD";
            this.buttonExitML_locD.Size = new System.Drawing.Size(140, 57);
            this.buttonExitML_locD.TabIndex = 51;
            this.buttonExitML_locD.Text = "Назад";
            this.buttonExitML_locD.UseVisualStyleBackColor = true;
            this.buttonExitML_locD.Click += new System.EventHandler(this.buttonExitML_locD_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(395, 241);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(140, 56);
            this.buttonSearch.TabIndex = 59;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Найденные локомотивы:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 301);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 84);
            this.listBox1.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Выберите машиниста:";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DataSource = this.машинистыBindingSource1;
            this.comboBoxSearch.DisplayMember = "ФИО_машиниста";
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(31, 241);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(310, 24);
            this.comboBoxSearch.TabIndex = 61;
            // 
            // машинистыBindingSource1
            // 
            this.машинистыBindingSource1.DataMember = "Машинисты";
            this.машинистыBindingSource1.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // аИС_жд_узлаSQLDataSet
            // 
            this.аИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.аИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.способностьМашинистаВодитьЛокомотивBindingSource, "ID_машиниста", true));
            this.comboBox1.DataSource = this.машинистыBindingSource;
            this.comboBox1.DisplayMember = "ФИО_машиниста";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 24);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.ValueMember = "ID_машиниста";
            // 
            // способностьМашинистаВодитьЛокомотивBindingSource
            // 
            this.способностьМашинистаВодитьЛокомотивBindingSource.DataMember = "Способность машиниста водить локомотив";
            this.способностьМашинистаВодитьЛокомотивBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // машинистыBindingSource
            // 
            this.машинистыBindingSource.DataMember = "Машинисты";
            this.машинистыBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.способностьМашинистаВодитьЛокомотивBindingSource, "Название_локомотива", true));
            this.comboBox2.DataSource = this.списокТиповЛокомотивовBindingSource;
            this.comboBox2.DisplayMember = "Название локомотива";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(255, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(317, 24);
            this.comboBox2.TabIndex = 63;
            this.comboBox2.ValueMember = "Название локомотива";
            // 
            // списокТиповЛокомотивовBindingSource
            // 
            this.списокТиповЛокомотивовBindingSource.DataMember = "Список типов локомотивов";
            this.списокТиповЛокомотивовBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.способностьМашинистаВодитьЛокомотивBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(849, 31);
            this.bindingNavigator1.TabIndex = 64;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(69, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // способность_машиниста_водить_локомотивTableAdapter
            // 
            this.способность_машиниста_водить_локомотивTableAdapter.ClearBeforeFill = true;
            // 
            // машинистыTableAdapter
            // 
            this.машинистыTableAdapter.ClearBeforeFill = true;
            // 
            // способностьМашинистаВодитьЛокомотивBindingSource1
            // 
            this.способностьМашинистаВодитьЛокомотивBindingSource1.DataMember = "Способность машиниста водить локомотив";
            this.способностьМашинистаВодитьЛокомотивBindingSource1.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // локомотивыBindingSource
            // 
            this.локомотивыBindingSource.DataMember = "Локомотивы";
            this.локомотивыBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // локомотивыTableAdapter
            // 
            this.локомотивыTableAdapter.ClearBeforeFill = true;
            // 
            // список_типов_локомотивовTableAdapter
            // 
            this.список_типов_локомотивовTableAdapter.ClearBeforeFill = true;
            // 
            // M_L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 507);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonReportML);
            this.Controls.Add(this.buttonSaveML);
            this.Controls.Add(this.buttonExitML_locD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "M_L";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Способность машиниста водить локомотив";
            this.Load += new System.EventHandler(this.M_L_Load);
            ((System.ComponentModel.ISupportInitialize)(this.машинистыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.способностьМашинистаВодитьЛокомотивBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.машинистыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокТиповЛокомотивовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.способностьМашинистаВодитьЛокомотивBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.локомотивыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReportML;
        private System.Windows.Forms.Button buttonSaveML;
        private System.Windows.Forms.Button buttonExitML_locD;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private АИС_жд_узлаSQLDataSet аИС_жд_узлаSQLDataSet;
        private System.Windows.Forms.BindingSource способностьМашинистаВодитьЛокомотивBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.Способность_машиниста_водить_локомотивTableAdapter способность_машиниста_водить_локомотивTableAdapter;
        private System.Windows.Forms.BindingSource машинистыBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.МашинистыTableAdapter машинистыTableAdapter;
        private System.Windows.Forms.BindingSource способностьМашинистаВодитьЛокомотивBindingSource1;
        private System.Windows.Forms.BindingSource локомотивыBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.ЛокомотивыTableAdapter локомотивыTableAdapter;
        private System.Windows.Forms.BindingSource списокТиповЛокомотивовBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.Список_типов_локомотивовTableAdapter список_типов_локомотивовTableAdapter;
        private System.Windows.Forms.BindingSource машинистыBindingSource1;
    }
}