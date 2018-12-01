using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MyDiploma
{
    public partial class Warning3 : Form
    {
        private EditTheDirectory editDir;
        private string DBName;
        private string tableName;
        private bool isTheme;

        public Warning3(EditTheDirectory editDir, string DBName, bool isTheme)
        {
            InitializeComponent();
            this.editDir = editDir;
            this.DBName = DBName;
            this.isTheme = isTheme;
            if (editDir.RBImage.Checked == true)
            {
                label1.Text = "Ви точно хочете видалити дану картинку?";
            }
            this.Show();
        }

        private void BYes_Click(object sender, EventArgs e)
        {
            if (isTheme)
            {
                if (editDir.CBoxTh.Text != "" && editDir.richTextBox1.Text != "" && editDir.CBoxCh.Text != "")
                {
                    tableName = editDir.CBoxCh.Text.Replace(' ', '_').Replace("'", "UC39UC");
                    DBName = DBName.Replace(' ', '_');

                    using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                    {
                        db.Open();
                        using (SQLiteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = "delete from " + tableName + " where " + tableName + "Th" + " = '" + editDir.CBoxTh.Text + "' and " + tableName + "Str" + " = '" + editDir.richTextBox1.Text.Replace("'", "UC39UC") + "';";
                            cmd.ExecuteNonQuery();
                        }
                        db.Close();
                    }

                    MessageBox.Show("Тема успiшно видалена!");
                }
                else
                {
                    MessageBox.Show("Данi введенi неправильно!");
                }

                editDir.CBoxTh.Items.Clear();
                Array.Clear(editDir.ThemesList, 0, 49);
                editDir.CBoxTh.Text = "";
                editDir.richTextBox1.Text = "";
                editDir.RefreshThemes();

                this.Close();
            }
            else
            {
                if (editDir.CBoxCh.Text != "" && editDir.CBoxImgName.Text != "" && editDir.pictureBox1.Image != null)
                {
                    tableName = editDir.CBoxCh.Text.Replace(' ', '_').Replace("'", "UC39UC");
                    DBName = DBName.Replace(' ', '_');
                    byte[] photo = editDir.imageToByteArray(editDir.pictureBox1.Image);

                    using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                    {
                        db.Open();
                        using (SQLiteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = "delete from " + tableName + " where " + tableName + "ImgName" + " = '" + editDir.CBoxImgName.Text + "' and " + tableName + "ImgObj" + " = @photo;";
                            cmd.Parameters.Add("@photo", DbType.Binary, 20).Value = photo;
                            cmd.ExecuteNonQuery();
                        }
                        db.Close();
                    }

                    MessageBox.Show("Тема успiшно видалена!");
                }
                else
                {
                    MessageBox.Show("Данi введенi неправильно!");
                }

                editDir.CBoxImgName.Items.Clear();
                Array.Clear(editDir.ImagesList, 0, 99);
                editDir.CBoxImgName.Text = "";
                editDir.pictureBox1.Text = "";
                editDir.pictureBox1.Image = null;
                editDir.RefreshImages();

                this.Close();
            }
        }

        private void BNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
