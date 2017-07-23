namespace KR_BD_AIS
{
    partial class Locomotive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locomotive));
            this.buttonLocType = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonReportLocType = new System.Windows.Forms.Button();
            this.buttonSaveLocType = new System.Windows.Forms.Button();
            this.buttonExitLoc_locD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.локомотивыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аИС_жд_узлаSQLDataSet = new KR_BD_AIS.АИС_жд_узлаSQLDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.депоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
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
            this.локомотивыTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.ЛокомотивыTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.списокТиповЛокомотивовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокЖелезнодорожныхУзловBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_железнодорожных_узловTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.Список_железнодорожных_узловTableAdapter();
            this.депоTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.ДепоTableAdapter();
            this.список_типов_локомотивовTableAdapter = new KR_BD_AIS.АИС_жд_узлаSQLDataSetTableAdapters.Список_типов_локомотивовTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.локомотивыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.списокТиповЛокомотивовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.локомотивыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.депоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.списокТиповЛокомотивовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЖелезнодорожныхУзловBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.локомотивыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокТиповЛокомотивовBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLocType
            // 
            this.buttonLocType.Location = new System.Drawing.Point(685, 248);
            this.buttonLocType.Name = "buttonLocType";
            this.buttonLocType.Size = new System.Drawing.Size(140, 56);
            this.buttonLocType.TabIndex = 75;
            this.buttonLocType.Text = "Список типов локомотивов";
            this.buttonLocType.UseVisualStyleBackColor = true;
            this.buttonLocType.Click += new System.EventHandler(this.buttonLocType_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(377, 247);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(140, 56);
            this.buttonSearch.TabIndex = 73;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Найденные локомотивы на узле:";
            // 
            // buttonReportLocType
            // 
            this.buttonReportLocType.Location = new System.Drawing.Point(685, 114);
            this.buttonReportLocType.Name = "buttonReportLocType";
            this.buttonReportLocType.Size = new System.Drawing.Size(140, 57);
            this.buttonReportLocType.TabIndex = 70;
            this.buttonReportLocType.Text = "Отчёт";
            this.buttonReportLocType.UseVisualStyleBackColor = true;
            this.buttonReportLocType.Click += new System.EventHandler(this.buttonReportLocType_Click);
            // 
            // buttonSaveLocType
            // 
            this.buttonSaveLocType.Location = new System.Drawing.Point(685, 51);
            this.buttonSaveLocType.Name = "buttonSaveLocType";
            this.buttonSaveLocType.Size = new System.Drawing.Size(140, 57);
            this.buttonSaveLocType.TabIndex = 69;
            this.buttonSaveLocType.Text = "Сохранить";
            this.buttonSaveLocType.UseVisualStyleBackColor = true;
            this.buttonSaveLocType.Click += new System.EventHandler(this.buttonSaveLocType_Click);
            // 
            // buttonExitLoc_locD
            // 
            this.buttonExitLoc_locD.Location = new System.Drawing.Point(685, 177);
            this.buttonExitLoc_locD.Name = "buttonExitLoc_locD";
            this.buttonExitLoc_locD.Size = new System.Drawing.Size(140, 57);
            this.buttonExitLoc_locD.TabIndex = 68;
            this.buttonExitLoc_locD.Text = "Назад";
            this.buttonExitLoc_locD.UseVisualStyleBackColor = true;
            this.buttonExitLoc_locD.Click += new System.EventHandler(this.buttonExitLoc_locD_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.локомотивыBindingSource, "ID_локомотива", true));
            this.textBox1.Location = new System.Drawing.Point(257, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 22);
            this.textBox1.TabIndex = 63;
            // 
            // локомотивыBindingSource
            // 
            this.локомотивыBindingSource.DataMember = "Локомотивы";
            this.локомотивыBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // аИС_жд_узлаSQLDataSet
            // 
            this.аИС_жд_узлаSQLDataSet.DataSetName = "АИС_жд_узлаSQLDataSet";
            this.аИС_жд_узлаSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Выберите локомотив:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Депо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Название локомотива";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "IDмашиниста";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.локомотивыBindingSource, "ID_депо", true));
            this.comboBox1.DataSource = this.депоBindingSource;
            this.comboBox1.DisplayMember = "Название_депо";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(257, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 24);
            this.comboBox1.TabIndex = 76;
            this.comboBox1.ValueMember = "ID_депо";
            // 
            // депоBindingSource
            // 
            this.депоBindingSource.DataMember = "Депо";
            this.депоBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DataSource = this.списокТиповЛокомотивовBindingSource1;
            this.comboBoxSearch.DisplayMember = "Название локомотива";
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(33, 249);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(317, 24);
            this.comboBoxSearch.TabIndex = 77;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.локомотивыBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(837, 31);
            this.bindingNavigator1.TabIndex = 78;
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
            // локомотивыTableAdapter
            // 
            this.локомотивыTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.локомотивыBindingSource, "Наличие_лакомотива_на_узле", true));
            this.checkBox1.Location = new System.Drawing.Point(257, 126);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 79;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "Нахождение локомотивы на узле";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.локомотивыBindingSource, "Название_локомотива", true));
            this.comboBox3.DataSource = this.списокТиповЛокомотивовBindingSource;
            this.comboBox3.DisplayMember = "Название локомотива";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(257, 96);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(317, 24);
            this.comboBox3.TabIndex = 81;
            this.comboBox3.ValueMember = "Название локомотива";
            // 
            // списокТиповЛокомотивовBindingSource
            // 
            this.списокТиповЛокомотивовBindingSource.DataMember = "Список типов локомотивов";
            this.списокТиповЛокомотивовBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // списокЖелезнодорожныхУзловBindingSource
            // 
            this.списокЖелезнодорожныхУзловBindingSource.DataMember = "Список железнодорожных узлов";
            this.списокЖелезнодорожныхУзловBindingSource.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // список_железнодорожных_узловTableAdapter
            // 
            this.список_железнодорожных_узловTableAdapter.ClearBeforeFill = true;
            // 
            // депоTableAdapter
            // 
            this.депоTableAdapter.ClearBeforeFill = true;
            // 
            // список_типов_локомотивовTableAdapter
            // 
            this.список_типов_локомотивовTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(33, 329);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 132);
            this.listView1.TabIndex = 82;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название локомотива";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наличие локомотива на узле";
            this.columnHeader2.Width = 227;
            // 
            // локомотивыBindingSource1
            // 
            this.локомотивыBindingSource1.DataMember = "Локомотивы";
            this.локомотивыBindingSource1.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // списокТиповЛокомотивовBindingSource1
            // 
            this.списокТиповЛокомотивовBindingSource1.DataMember = "Список типов локомотивов";
            this.списокТиповЛокомотивовBindingSource1.DataSource = this.аИС_жд_узлаSQLDataSet;
            // 
            // Locomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 505);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonLocType);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonReportLocType);
            this.Controls.Add(this.buttonSaveLocType);
            this.Controls.Add(this.buttonExitLoc_locD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Locomotive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Локомотивы";
            this.Load += new System.EventHandler(this.Locomotive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.локомотивыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аИС_жд_узлаSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.депоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.списокТиповЛокомотивовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЖелезнодорожныхУзловBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.локомотивыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокТиповЛокомотивовBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLocType;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonReportLocType;
        private System.Windows.Forms.Button buttonSaveLocType;
        private System.Windows.Forms.Button buttonExitLoc_locD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxSearch;
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
        private System.Windows.Forms.BindingSource локомотивыBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.ЛокомотивыTableAdapter локомотивыTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource списокЖелезнодорожныхУзловBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.Список_железнодорожных_узловTableAdapter список_железнодорожных_узловTableAdapter;
        private System.Windows.Forms.BindingSource депоBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.ДепоTableAdapter депоTableAdapter;
        private System.Windows.Forms.BindingSource списокТиповЛокомотивовBindingSource;
        private АИС_жд_узлаSQLDataSetTableAdapters.Список_типов_локомотивовTableAdapter список_типов_локомотивовTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.BindingSource локомотивыBindingSource1;
        private System.Windows.Forms.BindingSource списокТиповЛокомотивовBindingSource1;
    }
}