namespace MyDiploma
{
    partial class EditAddChForm
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
            this.TBEditAddCh = new System.Windows.Forms.TextBox();
            this.BEditAddCh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введiть назву глави:";
            // 
            // TBEditAddCh
            // 
            this.TBEditAddCh.Location = new System.Drawing.Point(13, 30);
            this.TBEditAddCh.Name = "TBEditAddCh";
            this.TBEditAddCh.Size = new System.Drawing.Size(232, 20);
            this.TBEditAddCh.TabIndex = 1;
            // 
            // BEditAddCh
            // 
            this.BEditAddCh.Location = new System.Drawing.Point(173, 56);
            this.BEditAddCh.Name = "BEditAddCh";
            this.BEditAddCh.Size = new System.Drawing.Size(75, 23);
            this.BEditAddCh.TabIndex = 2;
            this.BEditAddCh.Text = "Створити";
            this.BEditAddCh.UseVisualStyleBackColor = true;
            this.BEditAddCh.Click += new System.EventHandler(this.BEditAddCh_Click);
            // 
            // EditAddChForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 87);
            this.Controls.Add(this.BEditAddCh);
            this.Controls.Add(this.TBEditAddCh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditAddChForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Назва глави";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditAddChForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBEditAddCh;
        private System.Windows.Forms.Button BEditAddCh;
    }
}