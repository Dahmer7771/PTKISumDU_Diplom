namespace MyDiploma
{
    partial class Warning5
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
            this.label1 = new System.Windows.Forms.Label();
            this.BYes = new System.Windows.Forms.Button();
            this.BNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ви впевненi що хочете вийти з редактору довiдника?\r\n            Незбереженi данi " +
    "можуть бути втраченi";
            // 
            // BYes
            // 
            this.BYes.Location = new System.Drawing.Point(27, 39);
            this.BYes.Name = "BYes";
            this.BYes.Size = new System.Drawing.Size(97, 33);
            this.BYes.TabIndex = 1;
            this.BYes.Text = "Так";
            this.BYes.UseVisualStyleBackColor = true;
            this.BYes.Click += new System.EventHandler(this.BYes_Click);
            // 
            // BNo
            // 
            this.BNo.Location = new System.Drawing.Point(174, 39);
            this.BNo.Name = "BNo";
            this.BNo.Size = new System.Drawing.Size(97, 33);
            this.BNo.TabIndex = 2;
            this.BNo.Text = "Нi";
            this.BNo.UseVisualStyleBackColor = true;
            this.BNo.Click += new System.EventHandler(this.BNo_Click);
            // 
            // Warning5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 84);
            this.Controls.Add(this.BNo);
            this.Controls.Add(this.BYes);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Warning5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Попередження";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BYes;
        private System.Windows.Forms.Button BNo;
    }
}