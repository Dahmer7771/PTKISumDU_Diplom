using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyDiploma
{
    public partial class Warning1 : Form
    {
        private StartWindow refFormStartWindow;
        private string selItem;

        public Warning1(StartWindow refFormStartWindow, string selItem)
        {
            InitializeComponent();

            this.Show();
            this.refFormStartWindow = refFormStartWindow;
            this.selItem = selItem.Replace(' ', '_');
        }

        private void Warning_Load(object sender, EventArgs e)
        {

        }

        private void BYes_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileInfo = new FileInfo("Subjects/" + selItem + ".db");
                fileInfo.Delete();
                this.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
