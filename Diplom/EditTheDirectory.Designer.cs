namespace MyDiploma
{
    partial class EditTheDirectory
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
            this.CBoxCh = new System.Windows.Forms.ComboBox();
            this.BDelete = new System.Windows.Forms.Button();
            this.BRename = new System.Windows.Forms.Button();
            this.CBoxTh = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BDeleteTh = new System.Windows.Forms.Button();
            this.BAddCh = new System.Windows.Forms.Button();
            this.BAddTh = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RBTheme = new System.Windows.Forms.RadioButton();
            this.RBImage = new System.Windows.Forms.RadioButton();
            this.BImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CBoxImgName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберiть главу:";
            // 
            // CBoxCh
            // 
            this.CBoxCh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCh.FormattingEnabled = true;
            this.CBoxCh.Location = new System.Drawing.Point(12, 26);
            this.CBoxCh.Name = "CBoxCh";
            this.CBoxCh.Size = new System.Drawing.Size(499, 21);
            this.CBoxCh.TabIndex = 1;
            this.CBoxCh.SelectedIndexChanged += new System.EventHandler(this.CBoxCh_SelectedIndexChanged);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(436, 53);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(75, 27);
            this.BDelete.TabIndex = 4;
            this.BDelete.Text = "Видалити";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BRename
            // 
            this.BRename.Location = new System.Drawing.Point(329, 53);
            this.BRename.Name = "BRename";
            this.BRename.Size = new System.Drawing.Size(101, 27);
            this.BRename.TabIndex = 3;
            this.BRename.Text = "Перейменувати";
            this.BRename.UseVisualStyleBackColor = true;
            this.BRename.Click += new System.EventHandler(this.BRename_Click);
            // 
            // CBoxTh
            // 
            this.CBoxTh.FormattingEnabled = true;
            this.CBoxTh.Location = new System.Drawing.Point(76, 86);
            this.CBoxTh.Name = "CBoxTh";
            this.CBoxTh.Size = new System.Drawing.Size(435, 21);
            this.CBoxTh.TabIndex = 5;
            this.CBoxTh.SelectedIndexChanged += new System.EventHandler(this.CBoxTh_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 312);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // BDeleteTh
            // 
            this.BDeleteTh.Location = new System.Drawing.Point(157, 490);
            this.BDeleteTh.Name = "BDeleteTh";
            this.BDeleteTh.Size = new System.Drawing.Size(76, 26);
            this.BDeleteTh.TabIndex = 8;
            this.BDeleteTh.Text = "Видалити";
            this.BDeleteTh.UseVisualStyleBackColor = true;
            this.BDeleteTh.Click += new System.EventHandler(this.BDeleteTh_Click);
            // 
            // BAddCh
            // 
            this.BAddCh.Location = new System.Drawing.Point(11, 53);
            this.BAddCh.Name = "BAddCh";
            this.BAddCh.Size = new System.Drawing.Size(109, 27);
            this.BAddCh.TabIndex = 2;
            this.BAddCh.Text = "Створити";
            this.BAddCh.UseVisualStyleBackColor = true;
            this.BAddCh.Click += new System.EventHandler(this.BAddCh_Click);
            // 
            // BAddTh
            // 
            this.BAddTh.Location = new System.Drawing.Point(12, 490);
            this.BAddTh.Name = "BAddTh";
            this.BAddTh.Size = new System.Drawing.Size(139, 26);
            this.BAddTh.TabIndex = 6;
            this.BAddTh.Text = "Додати/Замiнити";
            this.BAddTh.UseVisualStyleBackColor = true;
            this.BAddTh.Click += new System.EventHandler(this.BAddTh_Click);
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(435, 490);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(76, 26);
            this.BBack.TabIndex = 10;
            this.BBack.Text = "Назад";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введiть текст:";
            // 
            // RBTheme
            // 
            this.RBTheme.AutoSize = true;
            this.RBTheme.Location = new System.Drawing.Point(15, 87);
            this.RBTheme.Name = "RBTheme";
            this.RBTheme.Size = new System.Drawing.Size(55, 17);
            this.RBTheme.TabIndex = 12;
            this.RBTheme.TabStop = true;
            this.RBTheme.Text = "Тема:";
            this.RBTheme.UseVisualStyleBackColor = true;
            this.RBTheme.CheckedChanged += new System.EventHandler(this.RBTheme_CheckedChanged);
            // 
            // RBImage
            // 
            this.RBImage.AutoSize = true;
            this.RBImage.Location = new System.Drawing.Point(15, 118);
            this.RBImage.Name = "RBImage";
            this.RBImage.Size = new System.Drawing.Size(91, 17);
            this.RBImage.TabIndex = 13;
            this.RBImage.TabStop = true;
            this.RBImage.Text = "Зображення:";
            this.RBImage.UseVisualStyleBackColor = true;
            this.RBImage.CheckedChanged += new System.EventHandler(this.RBImage_CheckedChanged);
            // 
            // BImage
            // 
            this.BImage.Location = new System.Drawing.Point(435, 118);
            this.BImage.Name = "BImage";
            this.BImage.Size = new System.Drawing.Size(75, 22);
            this.BImage.TabIndex = 15;
            this.BImage.Text = "Огляд";
            this.BImage.UseVisualStyleBackColor = true;
            this.BImage.Click += new System.EventHandler(this.BImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 312);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CBoxImgName
            // 
            this.CBoxImgName.FormattingEnabled = true;
            this.CBoxImgName.Location = new System.Drawing.Point(112, 118);
            this.CBoxImgName.Name = "CBoxImgName";
            this.CBoxImgName.Size = new System.Drawing.Size(318, 21);
            this.CBoxImgName.TabIndex = 17;
            this.CBoxImgName.SelectedIndexChanged += new System.EventHandler(this.CBoxImgName_SelectedIndexChanged);
            // 
            // EditTheDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 523);
            this.Controls.Add(this.CBoxImgName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BImage);
            this.Controls.Add(this.RBImage);
            this.Controls.Add(this.RBTheme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BAddTh);
            this.Controls.Add(this.BAddCh);
            this.Controls.Add(this.BDeleteTh);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CBoxTh);
            this.Controls.Add(this.BRename);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.CBoxCh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditTheDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор довiдника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditTheDirectory_FormClosed);
            this.Load += new System.EventHandler(this.EditTheDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BRename;
        private System.Windows.Forms.Button BDeleteTh;
        private System.Windows.Forms.Button BAddCh;
        private System.Windows.Forms.Button BAddTh;
        public System.Windows.Forms.ComboBox CBoxCh;
        public System.Windows.Forms.ComboBox CBoxTh;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.RadioButton RBTheme;
        public System.Windows.Forms.RadioButton RBImage;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox CBoxImgName;
    }
}