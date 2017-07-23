namespace KR_BD_AIS
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonManevrDisp = new System.Windows.Forms.Button();
            this.buttonLocDisp = new System.Windows.Forms.Button();
            this.buttonExitSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManevrDisp
            // 
            this.buttonManevrDisp.Location = new System.Drawing.Point(351, 46);
            this.buttonManevrDisp.Name = "buttonManevrDisp";
            this.buttonManevrDisp.Size = new System.Drawing.Size(192, 68);
            this.buttonManevrDisp.TabIndex = 0;
            this.buttonManevrDisp.Text = "Маневровый диспетчер";
            this.buttonManevrDisp.UseVisualStyleBackColor = true;
            this.buttonManevrDisp.Click += new System.EventHandler(this.buttonManevrDisp_Click);
            // 
            // buttonLocDisp
            // 
            this.buttonLocDisp.Location = new System.Drawing.Point(351, 120);
            this.buttonLocDisp.Name = "buttonLocDisp";
            this.buttonLocDisp.Size = new System.Drawing.Size(192, 68);
            this.buttonLocDisp.TabIndex = 1;
            this.buttonLocDisp.Text = "Локомотивный диспетчер";
            this.buttonLocDisp.UseVisualStyleBackColor = true;
            this.buttonLocDisp.Click += new System.EventHandler(this.buttonLocDisp_Click);
            // 
            // buttonExitSystem
            // 
            this.buttonExitSystem.Location = new System.Drawing.Point(351, 194);
            this.buttonExitSystem.Name = "buttonExitSystem";
            this.buttonExitSystem.Size = new System.Drawing.Size(192, 68);
            this.buttonExitSystem.TabIndex = 2;
            this.buttonExitSystem.Text = "Выход из системы";
            this.buttonExitSystem.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 521);
            this.Controls.Add(this.buttonExitSystem);
            this.Controls.Add(this.buttonLocDisp);
            this.Controls.Add(this.buttonManevrDisp);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС железнодорожного узла";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManevrDisp;
        private System.Windows.Forms.Button buttonLocDisp;
        private System.Windows.Forms.Button buttonExitSystem;
    }
}

