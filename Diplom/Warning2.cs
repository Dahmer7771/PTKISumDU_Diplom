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
using System.IO;

namespace MyDiploma
{
    public partial class Warning2 : Form
    {
        private EditTheDirectory refFormEditDir;
        private string DBName;
        private string chapterName;
        private string themeText;
        private string themeName;
        private string NewImage;

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Warning2(EditTheDirectory refFormEditDir, string DBName)
        {
            InitializeComponent();
            this.refFormEditDir = refFormEditDir;
            this.DBName = DBName;
            this.Show();
        }

        private void Warning2_FormClosed(object sender, FormClosedEventArgs e)
        {
            refFormEditDir.Show();
        }

        private void BNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BYes_Click(object sender, EventArgs e)
        {
            if (refFormEditDir.RBTheme.Checked == true)
            {
                if (refFormEditDir.CBoxTh.Text != "" && refFormEditDir.richTextBox1.Text != "" && refFormEditDir.CBoxCh.Text != "")
                {
                    DBName = DBName.Replace(' ', '_');
                    chapterName = refFormEditDir.CBoxCh.Text.Replace(' ', '_');
                    chapterName = chapterName.Replace("'", "UC39UC");
                    themeText = refFormEditDir.richTextBox1.Text.Replace("'", "UC39UC");
                    themeName = refFormEditDir.CBoxTh.Text.Replace("'", "UC39UC");

                    using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                    {
                        db.Open();
                        using (SQLiteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = "delete from " + chapterName + " where " + chapterName + "Th" + " = '" + themeName + "' or " + chapterName + "Str" + " = '" + themeText + "';";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "insert into " + chapterName + "(" + chapterName + "Th, " + chapterName + "Str) values('" + themeName + "', '" + themeText + "')";
                            cmd.ExecuteNonQuery();
                        }

                        db.Close();
                        refFormEditDir.CBoxTh.Text = "";
                        refFormEditDir.richTextBox1.Text = "";

                        refFormEditDir.CBoxTh.Items.Clear();
                        Array.Clear(refFormEditDir.ThemesList, 0, 49);
                        refFormEditDir.RefreshThemes();

                        MessageBox.Show("Тема успiшно створена!");
                    }
                }
                else
                {
                    MessageBox.Show("Даннi введенi неправильно!");
                }
            }
            else
            {
                //                       !!!ДОРАБОТАТЬ!!!

                if(refFormEditDir.CBoxCh.Text != "" && refFormEditDir.CBoxImgName.Text != "" && refFormEditDir.pictureBox1.Image != null)
                {
                    DBName = DBName.Replace(' ', '_');
                    chapterName = refFormEditDir.CBoxCh.Text.Replace(' ', '_');
                    chapterName = chapterName.Replace("'", "UC39UC");
                    NewImage = Convert.ToString(refFormEditDir.CBoxImgName.Text).Replace(' ', '_').Replace("'", "UC39UC");
                    //themeName = refFormEditDir.CBoxImgName.Text.Replace("'", "UC39UC");

                    byte[] photo = imageToByteArray(refFormEditDir.currentImage);

                    using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                    {
                        db.Open();
                        using (SQLiteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = "delete from " + chapterName + " where " + chapterName + "ImgName" + " = '" + NewImage + "' or " + chapterName + "ImgObj" + " = '" + photo + "';";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "insert into " + chapterName + "(" + chapterName + "ImgName, " + chapterName + "ImgObj) values('" + NewImage + "', @photo)";
                            cmd.Parameters.Add("@photo", DbType.Binary, 20).Value = photo;
                            cmd.ExecuteNonQuery();
                        }

                        db.Close();
                        refFormEditDir.CBoxImgName.Text = "";
                        refFormEditDir.pictureBox1.Image = null;

                        refFormEditDir.CBoxImgName.Items.Clear();
                        Array.Clear(refFormEditDir.ImagesList, 0, 99);
                        refFormEditDir.RefreshImages();

                        MessageBox.Show("Тема успiшно створена!");
                    }
                }
                else
                {
                    MessageBox.Show("Даннi введенi неправильно!");
                }
            }

            this.Close();
        }
    }
}
