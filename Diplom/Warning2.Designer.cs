namespace MyDiploma
{
    partial class Warning2
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
            this.BNo = new System.Windows.Forms.Button();
            this.BYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Якщо в даному довiднику вже є запис з такою назвою\r\n або змiстом то вона буде пер" +
    "еписана. Продовжити?";
            // 
            // BNo
            // 
            this.BNo.Location = new System.Drawing.Point(172, 48);
            this.BNo.Name = "BNo";
            this.BNo.Size = new System.Drawing.Size(88, 31);
            this.BNo.TabIndex = 2;
            this.BNo.Text = "Нi";
            this.BNo.UseVisualStyleBackColor = true;
            this.BNo.Click += new System.EventHandler(this.BNo_Click);
            // 
            // BYes
            // 
            this.BYes.Location = new System.Drawing.Point(53, 48);
            this.BYes.Name = "BYes";
            this.BYes.Size = new System.Drawing.Size(88, 31);
            this.BYes.TabIndex = 1;
            this.BYes.Text = "Так";
            this.BYes.UseVisualStyleBackColor = true;
            this.BYes.Click += new System.EventHandler(this.BYes_Click);
            // 
            // Warning2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 93);
            this.Controls.Add(this.BYes);
            this.Controls.Add(this.BNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Warning2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Попередження";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Warning2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BNo;
        private System.Windows.Forms.Button BYes;
    }
}