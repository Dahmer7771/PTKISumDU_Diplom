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
    public partial class EditTheDirectory : Form
    {
        private StartWindow refFormStartWindow;
        private string DBName;
        public string[] ChaptersList = new string[50];
        public string[] ThemesList = new string[50];
        public string[] ImagesList = new string[100];
        private string tableName;
        private string themeName;
        private string themeText;
        private string imageName;
        private byte[] imageByte;
        public Image currentImage;

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        //Оновлення списку глав в елементi CBoxCh
        public void RefreshChapters()
        {
            Array.Clear(ChaptersList, 0, 49);
            CBoxCh.Text = "";
            CBoxCh.Items.Clear();
            DBName = DBName.Replace(' ', '_');

            using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
            {
                db.Open();
                using (SQLiteCommand cmd = db.CreateCommand())
                {
                    cmd.CommandText = "select name from sqlite_master where type = 'table'";
                    using (SQLiteDataReader SQReader = cmd.ExecuteReader())
                    {
                        for (int i = 0; SQReader.Read(); i++)
                        {
                            ChaptersList[i] += SQReader["name"];
                            CBoxCh.Items.Add(ChaptersList[i].Replace('_', ' ').Replace("UC39UC", "'"));
                        }
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }

        //Оновлення списку тем в елементi CBoxTh
        public void RefreshThemes()
        {
            tableName = tableName.Replace("'", "UC39UC");
            DBName = DBName.Replace(' ', '_');

            using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
            {
                db.Open();
                //Формирование sql запроса
                using (SQLiteCommand cmd = db.CreateCommand())
                {
                    cmd.CommandText = "select " + tableName + "Th" + " from " + tableName + " where " + tableName + "Th != ''";
                    using (SQLiteDataReader SQReader = cmd.ExecuteReader())
                    {
                        
                        for (int i = 0; SQReader.Read(); i++)
                        {
                            ThemesList[i] += SQReader[tableName + "Th"];
                            CBoxTh.Items.Add(ThemesList[i].Replace("UC39UC", "'"));
                        }
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }

        //Оновлення списку картинок в елементi CBoxImageName
        public void RefreshImages()
        {
            DBName = DBName.Replace(' ', '_');

            using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
            {
                db.Open();
                using (SQLiteCommand cmd = db.CreateCommand())
                {
                    cmd.CommandText = "select " + tableName + "ImgName" + " from " + tableName + " where " + tableName + "ImgName != ''";
                    using (SQLiteDataReader SQReader = cmd.ExecuteReader())
                    {
                        for (int i = 0; SQReader.Read(); i++)
                        {
                            ImagesList[i] += SQReader[tableName + "ImgName"];
                            CBoxImgName.Items.Add(ImagesList[i].Replace("UC39UC", "'"));
                        }
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }

        public EditTheDirectory(StartWindow refFormStartWindow, string DBName)
        {
            InitializeComponent();
            this.refFormStartWindow = refFormStartWindow;
            this.DBName = DBName;
        }

        private void EditTheDirectory_Load(object sender, EventArgs e)
        {
            RefreshChapters();
            RBTheme.Checked = true;
        }

        private void EditTheDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            refFormStartWindow.Show();
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            Warning4 Warning4 = new Warning4(this, DBName);
        }

        private void BRename_Click(object sender, EventArgs e)
        {
            if (CBoxCh.Text != "")
            {
                RenameChapterForm RenameChForm = new RenameChapterForm(this, Convert.ToString(CBoxCh.SelectedItem), DBName);
            }
            else
            {
                MessageBox.Show("Виберiть главу для змiн!");
            }
        }

        private void BAddCh_Click(object sender, EventArgs e)
        {
            EditAddChForm editAddCh = new EditAddChForm(this, DBName);
        }

        private void CBoxCh_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableName = Convert.ToString(CBoxCh.SelectedItem).Replace(' ', '_');
            CBoxTh.Items.Clear();
            CBoxTh.Text = "";
            CBoxImgName.Items.Clear();
            CBoxImgName.Text = "";
            richTextBox1.Text = "";
            Array.Clear(ThemesList, 0, 49);
            RefreshThemes();
            Array.Clear(ImagesList, 0, 99);
            RefreshImages();
        }

        private void CBoxTh_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            themeText = "";
            themeName = Convert.ToString(CBoxTh.SelectedItem);
            themeName = themeName.Replace("'", "UC39UC");
            tableName = Convert.ToString(CBoxCh.SelectedItem).Replace(' ', '_').Replace("'", "UC39UC");
            DBName = DBName.Replace(' ', '_');

            using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
            {
                db.Open();
                using (SQLiteCommand cmd = db.CreateCommand())
                {
                    cmd.CommandText = "select " + tableName + "Str" + " from " + tableName + " where " + tableName + "Th = '" + themeName + "'";
                    using (SQLiteDataReader SQReader = cmd.ExecuteReader())
                    {
                        SQReader.Read();
                        themeText += SQReader[tableName + "Str"];
                        richTextBox1.Text += themeText.Replace("UC39UC", "'");
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }

        private void BAddTh_Click(object sender, EventArgs e)
        {
            Warning2 Warning2 = new Warning2(this, DBName);
        }

        private void BDeleteTh_Click(object sender, EventArgs e)
        {
            if (RBTheme.Checked == true)
            {
                if (CBoxTh.Text != "" && CBoxCh.Text != "")
                {
                    Warning3 Warning3 = new Warning3(this, DBName, true);
                }
                else
                {
                    MessageBox.Show("Виберiть тему!");
                }
            }
            else
            {
                if (CBoxCh.Text != "" && CBoxImgName.Text != "")
                {
                    Warning3 Warning3 = new Warning3(this, DBName, false);
                }
                else
                {
                    MessageBox.Show("Виберiть картинку!");
                }
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            if(CBoxTh.Text != "" || richTextBox1.Text != "")
            {
                Warning5 Warning5 = new Warning5(this);
            }
            else
            {
                this.Close();
            }
        }

        private void RBTheme_CheckedChanged(object sender, EventArgs e)
        {
            CBoxTh.Enabled = true;
            CBoxImgName.Enabled = false;
            BImage.Enabled = false;
            richTextBox1.Visible = true;
            pictureBox1.Visible = false;
            label3.Text = "Введiть текст:";
        }

        private void RBImage_CheckedChanged(object sender, EventArgs e)
        {
            CBoxTh.Enabled = false;
            CBoxImgName.Enabled = true;
            BImage.Enabled = true;
            richTextBox1.Visible = false;
            pictureBox1.Visible = true;
            label3.Text = "";
        }

        private void BImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Images (*.img;*.jpg)|*.img;*.jpg|All files (*.*)|*.*";

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == string.Empty) return;

            try
            {
                pictureBox1.Image = new Bitmap(Image.FromFile(openFileDialog1.FileName), 500, 300);
                currentImage = Image.FromFile(openFileDialog1.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CBoxImgName_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            imageName = Convert.ToString(CBoxImgName.SelectedItem);
            imageName = imageName.Replace("'", "UC39UC");
            tableName = Convert.ToString(CBoxCh.SelectedItem).Replace(' ', '_').Replace("'", "UC39UC");
            DBName = DBName.Replace(' ', '_');

            using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
            {
                db.Open();
                using (SQLiteCommand cmd = db.CreateCommand())
                {
                    cmd.CommandText = "select " + tableName + "ImgObj from " + tableName + " where " + tableName + "ImgName = '" + imageName + "'";
                    using (SQLiteDataReader SQReader = cmd.ExecuteReader())
                    {
                        SQReader.Read();
                        imageByte = (byte[])SQReader[tableName + "ImgObj"];
                        pictureBox1.Image = byteArrayToImage(imageByte);
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }
    }
}
