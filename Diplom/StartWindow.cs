using System;
using System.Windows.Forms;
using System.IO;

namespace MyDiploma
{
    public partial class StartWindow : Form
    {
        private string subjectsPath = "Subjects/";
        private string[] subjects;

        public void RefreshList()
        {
            LBSubjects.Items.Clear();
            subjects = System.IO.Directory.GetFiles(subjectsPath, "*.db");
            for (int i = 0; i < subjects.Length; i++)
            {
                subjects[i] = subjects[i].Replace("Subjects/", "");
                subjects[i] = subjects[i].Replace(".db", "");
                subjects[i] = subjects[i].Replace('_', ' ');
                LBSubjects.Items.Add(subjects[i]);
            }
        }

        public StartWindow()
        {
            InitializeComponent();

            if (!System.IO.Directory.Exists(subjectsPath))
            {
                DirectoryInfo di = System.IO.Directory.CreateDirectory(subjectsPath);
            }
        }

        private void BOpen_Click(object sender, EventArgs e)
        {
            if (LBSubjects.Text != "")
            {
                Directory Directory = new Directory(this, (string)LBSubjects.SelectedItem);
                Directory.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Виберiть довiдник");
            }
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            CreatingDBName CreateDBName = new CreatingDBName(this);
            CreateDBName.Show();
            this.Hide();
        }

        private void BDeleteDB_Click(object sender, EventArgs e)
        {
            if(LBSubjects.Text != "")
            {
                Warning1 Warning1 = new Warning1(this, Convert.ToString(LBSubjects.SelectedItem));
                RefreshList();
            }
            else
            {
                MessageBox.Show("Виберiть довiдник!");
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void BEditDB_Click(object sender, EventArgs e)
        {
            if (LBSubjects.Text != "")
            {
                EditTheDirectory EditTheDirectory = new EditTheDirectory(this, Convert.ToString(LBSubjects.SelectedItem));
                EditTheDirectory.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Виберiть довiдник!");
            }
        }
    }
}
