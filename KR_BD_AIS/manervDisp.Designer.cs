namespace KR_BD_AIS
{
    partial class manevrDisp
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
            this.buttonInTrain = new System.Windows.Forms.Button();
            this.buttonVan = new System.Windows.Forms.Button();
            this.buttonNaz = new System.Windows.Forms.Button();
            this.buttonGD = new System.Windows.Forms.Button();
            this.buttonOutTrain = new System.Windows.Forms.Button();
            this.buttonExitMainM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInTrain
            // 
            this.buttonInTrain.Location = new System.Drawing.Point(283, 23);
            this.buttonInTrain.Name = "buttonInTrain";
            this.buttonInTrain.Size = new System.Drawing.Size(236, 73);
            this.buttonInTrain.TabIndex = 0;
            this.buttonInTrain.Text = "Прибывающие поезда";
            this.buttonInTrain.UseVisualStyleBackColor = true;
            this.buttonInTrain.Click += new System.EventHandler(this.buttonInTrain_Click);
            // 
            // buttonVan
            // 
            this.buttonVan.Location = new System.Drawing.Point(283, 181);
            this.buttonVan.Name = "buttonVan";
            this.buttonVan.Size = new System.Drawing.Size(236, 73);
            this.buttonVan.TabIndex = 1;
            this.buttonVan.Text = "Вагоны";
            this.buttonVan.UseVisualStyleBackColor = true;
            this.buttonVan.Click += new System.EventHandler(this.buttonVan_Click);
            // 
            // buttonNaz
            // 
            this.buttonNaz.Location = new System.Drawing.Point(283, 260);
            this.buttonNaz.Name = "buttonNaz";
            this.buttonNaz.Size = new System.Drawing.Size(236, 73);
            this.buttonNaz.TabIndex = 2;
            this.buttonNaz.Text = "Назначение вагонов";
            this.buttonNaz.UseVisualStyleBackColor = true;
            this.buttonNaz.Click += new System.EventHandler(this.buttonNaz_Click);
            // 
            // buttonGD
            // 
            this.buttonGD.Location = new System.Drawing.Point(283, 339);
            this.buttonGD.Name = "buttonGD";
            this.buttonGD.Size = new System.Drawing.Size(236, 73);
            this.buttonGD.TabIndex = 3;
            this.buttonGD.Text = "Список железнодорожных узлов";
            this.buttonGD.UseVisualStyleBackColor = true;
            this.buttonGD.Click += new System.EventHandler(this.buttonGD_Click);
            // 
            // buttonOutTrain
            // 
            this.buttonOutTrain.Location = new System.Drawing.Point(283, 102);
            this.buttonOutTrain.Name = "buttonOutTrain";
            this.buttonOutTrain.Size = new System.Drawing.Size(236, 73);
            this.buttonOutTrain.TabIndex = 5;
            this.buttonOutTrain.Text = "Отправляяющиеся поезда";
            this.buttonOutTrain.UseVisualStyleBackColor = true;
            this.buttonOutTrain.Click += new System.EventHandler(this.buttonOutTrain_Click);
            // 
            // buttonExitMainM
            // 
            this.buttonExitMainM.Location = new System.Drawing.Point(283, 418);
            this.buttonExitMainM.Name = "buttonExitMainM";
            this.buttonExitMainM.Size = new System.Drawing.Size(236, 72);
            this.buttonExitMainM.TabIndex = 6;
            this.buttonExitMainM.Text = "Назад";
            this.buttonExitMainM.UseVisualStyleBackColor = true;
            this.buttonExitMainM.Click += new System.EventHandler(this.buttonExitMainM_Click);
            // 
            // manevrDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 508);
            this.Controls.Add(this.buttonExitMainM);
            this.Controls.Add(this.buttonOutTrain);
            this.Controls.Add(this.buttonGD);
            this.Controls.Add(this.buttonNaz);
            this.Controls.Add(this.buttonVan);
            this.Controls.Add(this.buttonInTrain);
            this.Name = "manevrDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню для маневрового диспетчера";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInTrain;
        private System.Windows.Forms.Button buttonVan;
        private System.Windows.Forms.Button buttonNaz;
        private System.Windows.Forms.Button buttonGD;
        private System.Windows.Forms.Button buttonOutTrain;
        private System.Windows.Forms.Button buttonExitMainM;
    }
}