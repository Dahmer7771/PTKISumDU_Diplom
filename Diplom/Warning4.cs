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
    public partial class Warning4 : Form
    {
        private string DBName;
        private EditTheDirectory refFormEditDir;

        public Warning4(EditTheDirectory refFormEditDir, string DBName)
        {
            InitializeComponent();
            this.Show();
            this.refFormEditDir = refFormEditDir;
            this.DBName = DBName;
        }

        private void BYes_Click(object sender, EventArgs e)
        {
            if(refFormEditDir.CBoxCh.Text != "")
            {
                string tableDelete = Convert.ToString(refFormEditDir.CBoxCh.SelectedItem).Replace(' ', '_').Replace("'", "UC39UC");

                using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                {
                    db.Open();
                    using (SQLiteCommand cmd = db.CreateCommand())
                    {
                        cmd.CommandText = "drop table " + tableDelete;
                        using (SQLiteDataReader SQReader = cmd.ExecuteReader())
                        {
                            for (int i = 0; SQReader.Read(); i++)
                            {
                                refFormEditDir.ChaptersList[i] += SQReader["name"];
                                refFormEditDir.CBoxCh.Items.Add(refFormEditDir.ChaptersList[i]);
                            }
                            SQReader.Close();
                        }
                    }
                    db.Close();
                }
                refFormEditDir.CBoxCh.Items.Clear();
                refFormEditDir.CBoxCh.SelectedText = "";
                refFormEditDir.CBoxCh.Text = "";
                refFormEditDir.CBoxTh.Items.Clear();
                refFormEditDir.CBoxTh.Text = "";
                refFormEditDir.richTextBox1.Text = "";

                refFormEditDir.RefreshChapters();
                MessageBox.Show("Глава видалена!");
            }
            else
            {
                MessageBox.Show("Виберiть главу!");
            }

            this.Close();
        }

        private void BNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
