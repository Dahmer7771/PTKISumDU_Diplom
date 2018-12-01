using System;
using System.Windows.Forms;

namespace MyDiploma
{
    public partial class CreatingDBName : Form
    {
        StartWindow refFormStartWindow;
        bool valid;
        string DBName;
        private string subjectsPath = "Subjects/";
        private string[] subjects;

        public CreatingDBName(StartWindow refForm)
        {
            InitializeComponent();

            this.refFormStartWindow = refForm;
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            valid = true;

            subjects = System.IO.Directory.GetFiles(subjectsPath, "*.db");

            for (int i = 0; i < subjects.Length; i++)
            {
                subjects[i] = subjects[i].Replace("Subjects/", "");
                subjects[i] = subjects[i].Replace(".db", "");
            }

            for(int i = 0; i < subjects.Length; i++)
            {
                if(subjects[i] == TBNewDBName.Text)
                {
                    valid = false;
                    break;
                }
            }

            foreach (char ch in TBNewDBName.Text)
            {
                if (ch >= 97 && ch <= 122 || 
                    ch >= 65 && ch <= 90 || 
                    ch >= 1040 && ch <= 1103 || 
                    ch >= 1168 && ch <= 1169 || 
                    ch == 1028 || ch == 1108 || 
                    ch == 1031 || 
                    ch == 1111 ||
                    ch == 1110 ||
                    ch >= 48 && ch <= 57||
                    ch == 95 ||
                    ch == 32 ||
                    ch == 39)
                {
                    continue;
                }
                else
                {
                    valid = false;
                }
            }

            if(valid == false || TBNewDBName.Text == "")
            {
                MessageBox.Show("Неправильно введено iм'я!");
            }
            else
            {
                DBName = TBNewDBName.Text;
                CreatingNewDB NewDB = new CreatingNewDB(refFormStartWindow, DBName);
                NewDB.Show();
                this.Hide();
            }
        }

        private void CreatingDBName_FormClosed(object sender, FormClosedEventArgs e)
        {
            refFormStartWindow.Show();
        }
    }
}
