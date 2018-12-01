namespace MyDiploma
{
    partial class RenameChapterForm
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
            this.TBNewChName = new System.Windows.Forms.TextBox();
            this.BRenameChConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введiть нову назву глави:";
            // 
            // TBNewChName
            // 
            this.TBNewChName.Location = new System.Drawing.Point(13, 30);
            this.TBNewChName.Name = "TBNewChName";
            this.TBNewChName.Size = new System.Drawing.Size(217, 20);
            this.TBNewChName.TabIndex = 1;
            // 
            // BRenameChConfirm
            // 
            this.BRenameChConfirm.Location = new System.Drawing.Point(70, 56);
            this.BRenameChConfirm.Name = "BRenameChConfirm";
            this.BRenameChConfirm.Size = new System.Drawing.Size(103, 23);
            this.BRenameChConfirm.TabIndex = 2;
            this.BRenameChConfirm.Text = "Перейменувати";
            this.BRenameChConfirm.UseVisualStyleBackColor = true;
            this.BRenameChConfirm.Click += new System.EventHandler(this.BRenameChConfirm_Click);
            // 
            // RenameChapterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 85);
            this.Controls.Add(this.BRenameChConfirm);
            this.Controls.Add(this.TBNewChName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RenameChapterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Назва глави";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenameChapterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNewChName;
        private System.Windows.Forms.Button BRenameChConfirm;
    }
}