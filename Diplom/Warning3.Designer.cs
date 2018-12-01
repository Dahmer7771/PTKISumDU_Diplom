namespace MyDiploma
{
    partial class Warning3
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
            this.BYes = new System.Windows.Forms.Button();
            this.BNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BYes
            // 
            this.BYes.Location = new System.Drawing.Point(31, 54);
            this.BYes.Name = "BYes";
            this.BYes.Size = new System.Drawing.Size(88, 31);
            this.BYes.TabIndex = 0;
            this.BYes.Text = "Так";
            this.BYes.UseVisualStyleBackColor = true;
            this.BYes.Click += new System.EventHandler(this.BYes_Click);
            // 
            // BNo
            // 
            this.BNo.Location = new System.Drawing.Point(143, 54);
            this.BNo.Name = "BNo";
            this.BNo.Size = new System.Drawing.Size(88, 31);
            this.BNo.TabIndex = 1;
            this.BNo.Text = "Нi";
            this.BNo.UseVisualStyleBackColor = true;
            this.BNo.Click += new System.EventHandler(this.BNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ви точно хочете видалити дану тему?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Warning3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 97);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BNo);
            this.Controls.Add(this.BYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Warning3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видалення теми";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BYes;
        private System.Windows.Forms.Button BNo;
        private System.Windows.Forms.Label label1;
    }
}