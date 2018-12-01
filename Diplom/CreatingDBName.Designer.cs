namespace MyDiploma
{
    partial class CreatingDBName
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
            this.LEnterDBName = new System.Windows.Forms.Label();
            this.TBNewDBName = new System.Windows.Forms.TextBox();
            this.BCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LEnterDBName
            // 
            this.LEnterDBName.AutoSize = true;
            this.LEnterDBName.Location = new System.Drawing.Point(12, 9);
            this.LEnterDBName.Name = "LEnterDBName";
            this.LEnterDBName.Size = new System.Drawing.Size(314, 26);
            this.LEnterDBName.TabIndex = 0;
            this.LEnterDBName.Text = "                         Введiть назву нового довiдника\r\n(нижнi пiдкреслення буду" +
    "ть автоматично замiненi на пробiл):";
            // 
            // TBNewDBName
            // 
            this.TBNewDBName.Location = new System.Drawing.Point(12, 38);
            this.TBNewDBName.Name = "TBNewDBName";
            this.TBNewDBName.Size = new System.Drawing.Size(311, 20);
            this.TBNewDBName.TabIndex = 1;
            // 
            // BCreate
            // 
            this.BCreate.Location = new System.Drawing.Point(112, 64);
            this.BCreate.Name = "BCreate";
            this.BCreate.Size = new System.Drawing.Size(108, 30);
            this.BCreate.TabIndex = 2;
            this.BCreate.Text = "Створити";
            this.BCreate.UseVisualStyleBackColor = true;
            this.BCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // CreatingDBName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 104);
            this.Controls.Add(this.BCreate);
            this.Controls.Add(this.TBNewDBName);
            this.Controls.Add(this.LEnterDBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreatingDBName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ім\'я нового довідника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreatingDBName_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LEnterDBName;
        private System.Windows.Forms.TextBox TBNewDBName;
        private System.Windows.Forms.Button BCreate;
    }
}