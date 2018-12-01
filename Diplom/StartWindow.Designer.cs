namespace MyDiploma
{
    partial class StartWindow
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
            this.LBSubjects = new System.Windows.Forms.ListBox();
            this.BOpen = new System.Windows.Forms.Button();
            this.BCreate = new System.Windows.Forms.Button();
            this.BDeleteDB = new System.Windows.Forms.Button();
            this.BEditDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберiть довiдник:";
            // 
            // LBSubjects
            // 
            this.LBSubjects.DisplayMember = "dghth";
            this.LBSubjects.FormattingEnabled = true;
            this.LBSubjects.Location = new System.Drawing.Point(12, 24);
            this.LBSubjects.Name = "LBSubjects";
            this.LBSubjects.Size = new System.Drawing.Size(292, 147);
            this.LBSubjects.TabIndex = 1;
            // 
            // BOpen
            // 
            this.BOpen.Location = new System.Drawing.Point(310, 24);
            this.BOpen.Name = "BOpen";
            this.BOpen.Size = new System.Drawing.Size(93, 32);
            this.BOpen.TabIndex = 2;
            this.BOpen.Text = "Вiдкрити";
            this.BOpen.UseVisualStyleBackColor = true;
            this.BOpen.Click += new System.EventHandler(this.BOpen_Click);
            // 
            // BCreate
            // 
            this.BCreate.Location = new System.Drawing.Point(310, 62);
            this.BCreate.Name = "BCreate";
            this.BCreate.Size = new System.Drawing.Size(93, 32);
            this.BCreate.TabIndex = 3;
            this.BCreate.Text = "Створити";
            this.BCreate.UseVisualStyleBackColor = true;
            this.BCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // BDeleteDB
            // 
            this.BDeleteDB.Location = new System.Drawing.Point(310, 138);
            this.BDeleteDB.Name = "BDeleteDB";
            this.BDeleteDB.Size = new System.Drawing.Size(90, 32);
            this.BDeleteDB.TabIndex = 5;
            this.BDeleteDB.Text = "Видалити";
            this.BDeleteDB.UseVisualStyleBackColor = true;
            this.BDeleteDB.Click += new System.EventHandler(this.BDeleteDB_Click);
            // 
            // BEditDB
            // 
            this.BEditDB.Location = new System.Drawing.Point(310, 100);
            this.BEditDB.Name = "BEditDB";
            this.BEditDB.Size = new System.Drawing.Size(92, 32);
            this.BEditDB.TabIndex = 4;
            this.BEditDB.Text = "Редагувати";
            this.BEditDB.UseVisualStyleBackColor = true;
            this.BEditDB.Click += new System.EventHandler(this.BEditDB_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 184);
            this.Controls.Add(this.BEditDB);
            this.Controls.Add(this.BDeleteDB);
            this.Controls.Add(this.BCreate);
            this.Controls.Add(this.BOpen);
            this.Controls.Add(this.LBSubjects);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довiдники";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BOpen;
        public System.Windows.Forms.ListBox LBSubjects;
        private System.Windows.Forms.Button BCreate;
        private System.Windows.Forms.Button BDeleteDB;
        private System.Windows.Forms.Button BEditDB;
    }
}