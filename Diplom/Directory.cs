using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Drawing;

namespace MyDiploma
{
    public partial class Directory : Form
    {
        private string[] ChaptersList = new string[200];
        private string[] ThemesList = new string[200];
        private string[] ImagesList = new string[200];
        private string tableName;
        private StartWindow refStartWindow;
        private string DBName;
        private string themeName;
        private string themeText;
        private string imageName;
        private byte[] imageByte;

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public Directory(StartWindow refForm, string DBName)
        {
            InitializeComponent();
            KeyPreview = true;

            this.refStartWindow = refForm;
            this.DBName = DBName;
            WindowState = FormWindowState.Maximized;
            richTextBox1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                            CBox1.Items.Add(ChaptersList[i].Replace('_', ' ').Replace("UC39UC", "'"));
                        }
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            refStartWindow.Show();
        }

        private void CBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Image = null;

            imageName = Convert.ToString(CBox3.SelectedItem);
            imageName = imageName.Replace("'", "UC39UC");
            tableName = Convert.ToString(CBox1.SelectedItem).Replace(' ', '_').Replace("'", "UC39UC");
            DBName = DBName.Replace(' ', '_');

            using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
            {
                db.Open();
                using (SQLiteCommand cmd = db.CreateCommand())
                {
                    cmd.CommandText = $"select {tableName}ImgObj from {tableName} where {tableName}ImgName = '" + imageName + "'";
                    using (SQLiteDataReader SQReader = cmd.ExecuteReader())
                    {
                        SQReader.Read();
                        imageByte = (byte[])SQReader[tableName + "ImgObj"];
                        pictureBox1.Image = new Bitmap(byteArrayToImage(imageByte),pictureBox1.Width , pictureBox1.Height);
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }

        private void CBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Очистка предыдущего выбора
            CBox2.Items.Clear();
            Array.Clear(ThemesList, 0, 49);
            CBox3.Items.Clear();
            Array.Clear(ImagesList, 0, 49);

            tableName = Convert.ToString(CBox1.SelectedItem).Replace(' ', '_').Replace("'", "UC39UC");
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
                        //Заполнение ComboBox2 строками из базы данных
                        for (int i = 0; SQReader.Read(); i++)
                        {
                            ThemesList[i] += SQReader[tableName + "Th"];
                            CBox2.Items.Add(ThemesList[i].Replace("UC39UC", "'"));
                        }
                        SQReader.Close();
                    }
                }
                try
                {
                    using (SQLiteCommand cmd = db.CreateCommand())
                    {
                        cmd.CommandText = "select " + tableName + "ImgName" + " from " + tableName + " where " + tableName + "ImgName != ''";
                        using (SQLiteDataReader SQReader = cmd.ExecuteReader())
                        {
                            for (int i = 0; SQReader.Read(); i++)
                            {
                                ImagesList[i] += SQReader[tableName + "ImgName"];
                                CBox3.Items.Add(ImagesList[i].Replace("UC39UC", "'"));
                            }
                            SQReader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                db.Close();
            }
        }

        private void CBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            richTextBox1.Visible = true;
            richTextBox1.Text = "";
            themeName = Convert.ToString(CBox2.SelectedItem).Replace("'", "UC39UC");
            tableName = Convert.ToString(CBox1.SelectedItem).Replace(' ', '_').Replace("'", "UC39UC");
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
                        themeText = null;
                        SQReader.Close();
                    }
                }
                db.Close();
            }
        }

        private void Directory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                CenterToScreen();
            }
        }
    }
}
