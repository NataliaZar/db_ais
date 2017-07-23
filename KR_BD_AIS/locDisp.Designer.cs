namespace KR_BD_AIS
{
    partial class locDisp
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
            this.buttonMachinist = new System.Windows.Forms.Button();
            this.buttonDepo = new System.Windows.Forms.Button();
            this.buttonExitMainMenu = new System.Windows.Forms.Button();
            this.buttonLocomotive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMachinist
            // 
            this.buttonMachinist.Location = new System.Drawing.Point(242, 12);
            this.buttonMachinist.Name = "buttonMachinist";
            this.buttonMachinist.Size = new System.Drawing.Size(264, 71);
            this.buttonMachinist.TabIndex = 0;
            this.buttonMachinist.Text = "Машинисты";
            this.buttonMachinist.UseVisualStyleBackColor = true;
            this.buttonMachinist.Click += new System.EventHandler(this.buttonMachinist_Click);
            // 
            // buttonDepo
            // 
            this.buttonDepo.Location = new System.Drawing.Point(242, 166);
            this.buttonDepo.Name = "buttonDepo";
            this.buttonDepo.Size = new System.Drawing.Size(264, 71);
            this.buttonDepo.TabIndex = 1;
            this.buttonDepo.Text = "Депо";
            this.buttonDepo.UseVisualStyleBackColor = true;
            this.buttonDepo.Click += new System.EventHandler(this.buttonDepo_Click);
            // 
            // buttonExitMainMenu
            // 
            this.buttonExitMainMenu.Location = new System.Drawing.Point(242, 243);
            this.buttonExitMainMenu.Name = "buttonExitMainMenu";
            this.buttonExitMainMenu.Size = new System.Drawing.Size(264, 71);
            this.buttonExitMainMenu.TabIndex = 2;
            this.buttonExitMainMenu.Text = "Назад";
            this.buttonExitMainMenu.UseVisualStyleBackColor = true;
            this.buttonExitMainMenu.Click += new System.EventHandler(this.buttonExitMainMenu_Click);
            // 
            // buttonLocomotive
            // 
            this.buttonLocomotive.Location = new System.Drawing.Point(242, 89);
            this.buttonLocomotive.Name = "buttonLocomotive";
            this.buttonLocomotive.Size = new System.Drawing.Size(264, 71);
            this.buttonLocomotive.TabIndex = 3;
            this.buttonLocomotive.Text = "Локомотивы";
            this.buttonLocomotive.UseVisualStyleBackColor = true;
            this.buttonLocomotive.Click += new System.EventHandler(this.buttonLocomotive_Click);
            // 
            // locDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 490);
            this.Controls.Add(this.buttonLocomotive);
            this.Controls.Add(this.buttonExitMainMenu);
            this.Controls.Add(this.buttonDepo);
            this.Controls.Add(this.buttonMachinist);
            this.Name = "locDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню для локомотивного диспетчера";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMachinist;
        private System.Windows.Forms.Button buttonDepo;
        private System.Windows.Forms.Button buttonExitMainMenu;
        private System.Windows.Forms.Button buttonLocomotive;
    }
}