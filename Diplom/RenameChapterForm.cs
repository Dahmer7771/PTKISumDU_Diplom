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
    public partial class RenameChapterForm : Form
    {
        private EditTheDirectory refFormEditDir;
        private string oldChName;
        private string DBName;
        private string NewChName;

        public RenameChapterForm(EditTheDirectory refFormEditDir, string oldChName, string DBName)
        {
            InitializeComponent();
            this.Show();

            this.refFormEditDir = refFormEditDir;
            this.oldChName = oldChName;
            this.DBName = DBName;
        }

        private void RenameChapterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refFormEditDir.Show();
            refFormEditDir.CBoxCh.Text = "";
            Array.Clear(refFormEditDir.ThemesList, 0, 49);
            refFormEditDir.RefreshChapters();
        }

        private void BRenameChConfirm_Click(object sender, EventArgs e)
        {
            DBName = DBName.Replace(' ', '_');
            NewChName = TBNewChName.Text.Replace(' ', '_');
            oldChName = oldChName.Replace(' ', '_');

            try
            {
                using (SQLiteConnection db = new SQLiteConnection("Data Source = Subjects/" + DBName + ".db; Version = 3"))
                {
                    db.Open();
                    using (SQLiteCommand cmd = db.CreateCommand())
                    {
                        cmd.CommandText = "alter table " + oldChName + " rename to " + NewChName;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "PRAGMA foreign_keys = 0;" +
                        "CREATE TABLE sqlitestudio_temp_table AS SELECT * FROM " + NewChName + ";" +
                        "DROP TABLE " + NewChName + ";" +
                        "CREATE TABLE " + NewChName + "(" + NewChName + "Th" + " VARCHAR(300)," + NewChName + "Str" + " VARCHAR(10000));" +
                        "INSERT INTO " + NewChName + "(" + NewChName + "Th" + "," + NewChName + "Str" + ") " +
                        "SELECT " + oldChName + "Th" + "," + oldChName + "Str" + " FROM sqlitestudio_temp_table;" +
                        "DROP TABLE sqlitestudio_temp_table;" +
                        "PRAGMA foreign_keys = 1; ";
                        cmd.ExecuteNonQuery();
                    }
                    db.Close();
                }

                refFormEditDir.CBoxTh.Items.Clear();

                MessageBox.Show("Глава перейменована успiшно!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
