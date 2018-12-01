using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace MyDiploma
{
    public partial class CreatingNewDB : Form
    {
        private StartWindow refFormStartWindow;
        private string DBName;
        bool valid;
        string[] ChaptersList = new string[100];
        private string NewChapter;
        private string NewTheme;
        private string NewImage;
        private Image currentImage;

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public CreatingNewDB(StartWindow refFormStartWindow, string DBName)
        {
            InitializeComponent();
            this.refFormStartWindow = refFormStartWindow;
            this.DBName = DBName;

            File.Create("Subjects/" + DBName.Replace(' ', '_') + ".db").Close();
        }

        private void CreatingNewDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            refFormStartWindow.Show();
        }

        private void BCreateCh_Click(object sender, EventArgs e)
        {
            CBox3.Items.Clear();
            Array.Clear(ChaptersList, 0, 99);

            valid = true;

            foreach (char ch in TBChapter.Text)
            {
                if ((int)ch >= 97 && (int)ch <= 122 ||
                    (int)ch >= 65 && (int)ch <= 90 ||
                    (int)ch >= 1040 && (int)ch <= 1103 ||
                    (int)ch >= 1168 && (int)ch <= 1169 ||
                    (int)ch == 1028 || (int)ch == 1108 ||
                    (int)ch == 1031 ||
                    (int)ch == 1111 ||
                    (int)ch == 1110 ||
                    (int)ch >= 48 && (int)ch <= 57 ||
                    (int)ch == 95 ||
                    (int)ch == 32 ||
                    (int)ch == 39)
                {
                    continue;
                }
                else
                {
                    valid = false;
                }
            }

            if(valid == false || TBChapter.Text == "")
            {
                MessageBox.Show("Неправильно введено iм'я глави!");
            }
            else
            {
                try
                {
                    NewChapter = TBChapter.Text.Replace(' ', '_');
                    NewChapter = NewChapter.Replace("'", "UC39UC");
                    DBName = DBName.Replace(' ', '_');

                    using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                    {
                        db.Open();
                        using (SQLiteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = "CREATE TABLE " + NewChapter + " (" + NewChapter + "Th VARCHAR (300)," + NewChapter + "Str VARCHAR(10000)," + NewChapter + "ImgName VARCHAR(1000)," + NewChapter + "ImgObj BLOB);";
                            cmd.ExecuteNonQuery();
                        }
                        db.Close();
                    }
                    MessageBox.Show("Глава створена!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

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
                            CBox3.Items.Add(ChaptersList[i].Replace('_', ' ').Replace("UC39UC", "'"));
                        }

                        TBChapter.Text = "";
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }

        private void BCreateTh_Click(object sender, EventArgs e)
        {
            if(RBTheme.Checked == true)
            {
                if (Convert.ToString(CBox3.SelectedItem) != "" && TBTheme.Text != "" && richTextBox2.Text != "")
                {
                    NewTheme = Convert.ToString(CBox3.SelectedItem).Replace(' ', '_').Replace("'", "UC39UC");

                    using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                    {
                        db.Open();
                        using (SQLiteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = "insert into " + NewTheme + "(" + NewTheme + "Th, " + NewTheme + "Str) values('" + TBTheme.Text.Replace("'", "UC39UC") + "', '" + richTextBox2.Text.Replace("'", "UC39UC") + "')";
                            cmd.ExecuteNonQuery();
                        }
                        db.Close();
                        TBTheme.Text = "";
                        richTextBox2.Text = "";

                        MessageBox.Show("Тема успiшно додана!");
                    }
                }
                else
                {
                    MessageBox.Show("Даннi введенi неправильно!");
                }
            }
            else
            {
                if (Convert.ToString(CBox3.SelectedItem) != "" && Convert.ToString(TBImgName.Text) != "" && pictureBox1.Image != null)
                {
                    NewTheme = Convert.ToString(CBox3.SelectedItem).Replace(' ', '_').Replace("'", "UC39UC");
                    NewImage = Convert.ToString(TBImgName.Text).Replace(' ', '_').Replace("'", "UC39UC");

                    byte[] photo = imageToByteArray(currentImage);

                    using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                    {
                        db.Open();
                        using (SQLiteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = "insert into " + NewTheme + "(" + NewTheme + "ImgName, " + NewTheme + "ImgObj) values('" + NewImage + "', @photo);";
                            cmd.Parameters.Add("@photo", DbType.Binary, 20).Value = photo;
                            cmd.ExecuteNonQuery();
                        }
                        db.Close();
                    }
                    TBImgName.Text = null;
                    pictureBox1.Image = null;
                    MessageBox.Show("Зображення успiшно додано!");

                }
                else
                {
                    MessageBox.Show("Даннi введенi неправильно!");
                }
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            if (TBTheme.Text != "" || richTextBox2.Text != "")
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
            TBImgName.Text = "";
            TBTheme.ReadOnly = false;
            BImage.Enabled = false;
            richTextBox2.Visible = true;
            pictureBox1.Visible = false;
            TBImgName.ReadOnly = true;
            label3.Text = "Текст теми:";
        }

        private void RBImage_CheckedChanged(object sender, EventArgs e)
        {
            TBTheme.Text = "";
            TBTheme.ReadOnly = true;
            BImage.Enabled = true;
            richTextBox2.Visible = false;
            pictureBox1.Visible = true;
            TBImgName.ReadOnly = false;
            label3.Text = "";
        }

        private void CreatingNewDB_Load(object sender, EventArgs e)
        {
            RBTheme.Checked = true;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}