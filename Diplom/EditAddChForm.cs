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
    public partial class EditAddChForm : Form
    {
        private EditTheDirectory refFormEditDir;
        private string DBName;
        bool valid;
        string addChapter;

        public EditAddChForm(EditTheDirectory refFormEditDir, string DBName)
        {
            InitializeComponent();
            this.Show();

            this.refFormEditDir = refFormEditDir;
            this.DBName = DBName;
        }

        private void BEditAddCh_Click(object sender, EventArgs e)
        {
            valid = true;

            foreach (char ch in TBEditAddCh.Text)
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

            if (valid == false || TBEditAddCh.Text == "")
            {
                MessageBox.Show("Неправильно введена назва глави!");
            }
            else
            {
                DBName = DBName.Replace(' ', '_');
                addChapter = TBEditAddCh.Text.Replace(' ', '_');
                addChapter = addChapter.Replace("'", "UC39UC");

                using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                {
                    db.Open();
                    using (SQLiteCommand cmd = db.CreateCommand())
                    {
                        cmd.CommandText = "CREATE TABLE " + addChapter + " (" + addChapter + "Th VARCHAR (300)," + addChapter + "Str VARCHAR(10000)," + addChapter + "ImgName VARCHAR(1000)," + addChapter + "ImgObj BLOB);";
                        cmd.ExecuteNonQuery();
                    }
                    db.Close();
                }
                TBEditAddCh.Text = "";
                MessageBox.Show("Глава створена!");
                this.Close();
            }
        }

        private void EditAddChForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refFormEditDir.Show();
            refFormEditDir.CBoxTh.Text = "";
            refFormEditDir.richTextBox1.Text = "";
            refFormEditDir.CBoxTh.Items.Clear();
            refFormEditDir.RefreshChapters();
        }
    }
}
