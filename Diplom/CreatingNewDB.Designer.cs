namespace MyDiploma
{
    partial class CreatingNewDB
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBChapter = new System.Windows.Forms.TextBox();
            this.TBTheme = new System.Windows.Forms.TextBox();
            this.BCreateCh = new System.Windows.Forms.Button();
            this.BCreateTh = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.CBox3 = new System.Windows.Forms.ComboBox();
            this.BBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BImage = new System.Windows.Forms.Button();
            this.RBTheme = new System.Windows.Forms.RadioButton();
            this.RBImage = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBImgName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додати главу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Додати до глави:";
            // 
            // TBChapter
            // 
            this.TBChapter.Location = new System.Drawing.Point(97, 12);
            this.TBChapter.Name = "TBChapter";
            this.TBChapter.Size = new System.Drawing.Size(415, 20);
            this.TBChapter.TabIndex = 1;
            // 
            // TBTheme
            // 
            this.TBTheme.Location = new System.Drawing.Point(76, 103);
            this.TBTheme.Name = "TBTheme";
            this.TBTheme.Size = new System.Drawing.Size(436, 20);
            this.TBTheme.TabIndex = 4;
            // 
            // BCreateCh
            // 
            this.BCreateCh.Location = new System.Drawing.Point(437, 38);
            this.BCreateCh.Name = "BCreateCh";
            this.BCreateCh.Size = new System.Drawing.Size(75, 23);
            this.BCreateCh.TabIndex = 2;
            this.BCreateCh.Text = "Створити";
            this.BCreateCh.UseVisualStyleBackColor = true;
            this.BCreateCh.Click += new System.EventHandler(this.BCreateCh_Click);
            // 
            // BCreateTh
            // 
            this.BCreateTh.Location = new System.Drawing.Point(12, 505);
            this.BCreateTh.Name = "BCreateTh";
            this.BCreateTh.Size = new System.Drawing.Size(75, 23);
            this.BCreateTh.TabIndex = 6;
            this.BCreateTh.Text = "Додати";
            this.BCreateTh.UseVisualStyleBackColor = true;
            this.BCreateTh.Click += new System.EventHandler(this.BCreateTh_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 187);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(500, 312);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // CBox3
            // 
            this.CBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox3.FormattingEnabled = true;
            this.CBox3.Location = new System.Drawing.Point(113, 70);
            this.CBox3.Name = "CBox3";
            this.CBox3.Size = new System.Drawing.Size(399, 21);
            this.CBox3.TabIndex = 3;
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(437, 505);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 23);
            this.BBack.TabIndex = 7;
            this.BBack.Text = "Назад";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BImage
            // 
            this.BImage.Location = new System.Drawing.Point(437, 133);
            this.BImage.Name = "BImage";
            this.BImage.Size = new System.Drawing.Size(75, 22);
            this.BImage.TabIndex = 11;
            this.BImage.Text = "Огляд";
            this.BImage.UseVisualStyleBackColor = true;
            this.BImage.Click += new System.EventHandler(this.BImage_Click);
            // 
            // RBTheme
            // 
            this.RBTheme.AutoSize = true;
            this.RBTheme.Location = new System.Drawing.Point(16, 103);
            this.RBTheme.Name = "RBTheme";
            this.RBTheme.Size = new System.Drawing.Size(54, 17);
            this.RBTheme.TabIndex = 12;
            this.RBTheme.TabStop = true;
            this.RBTheme.Text = "Тему:";
            this.RBTheme.UseVisualStyleBackColor = true;
            this.RBTheme.CheckedChanged += new System.EventHandler(this.RBTheme_CheckedChanged);
            // 
            // RBImage
            // 
            this.RBImage.AutoSize = true;
            this.RBImage.Location = new System.Drawing.Point(16, 136);
            this.RBImage.Name = "RBImage";
            this.RBImage.Size = new System.Drawing.Size(75, 17);
            this.RBImage.TabIndex = 13;
            this.RBImage.TabStop = true;
            this.RBImage.Text = "Картинку:";
            this.RBImage.UseVisualStyleBackColor = true;
            this.RBImage.CheckedChanged += new System.EventHandler(this.RBImage_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 312);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // TBImgName
            // 
            this.TBImgName.Location = new System.Drawing.Point(98, 134);
            this.TBImgName.Name = "TBImgName";
            this.TBImgName.Size = new System.Drawing.Size(333, 20);
            this.TBImgName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Текст теми:";
            // 
            // CreatingNewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBImgName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RBImage);
            this.Controls.Add(this.RBTheme);
            this.Controls.Add(this.BImage);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.CBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.BCreateTh);
            this.Controls.Add(this.BCreateCh);
            this.Controls.Add(this.TBTheme);
            this.Controls.Add(this.TBChapter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreatingNewDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення довiдника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreatingNewDB_FormClosed);
            this.Load += new System.EventHandler(this.CreatingNewDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBChapter;
        private System.Windows.Forms.TextBox TBTheme;
        private System.Windows.Forms.Button BCreateCh;
        private System.Windows.Forms.Button BCreateTh;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox CBox3;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BImage;
        private System.Windows.Forms.RadioButton RBTheme;
        private System.Windows.Forms.RadioButton RBImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBImgName;
        private System.Windows.Forms.Label label3;
    }
}