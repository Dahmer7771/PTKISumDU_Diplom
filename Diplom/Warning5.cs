using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiploma
{
    public partial class Warning5 : Form
    {
        private EditTheDirectory refFormEditDir;
        private CreatingNewDB refFormCreatingNewDB;
        private string refForm;

        public Warning5(EditTheDirectory refFormEditDir)
        {
            InitializeComponent();
            this.refFormEditDir = refFormEditDir;
            refForm = "EditDir";
            this.Show();
        }

        public Warning5(CreatingNewDB refFormCreatingNewDB)
        {
            InitializeComponent();
            this.refFormCreatingNewDB = refFormCreatingNewDB;
            refForm = "CreatingNewDB";
            this.Show();
        }

        private void BYes_Click(object sender, EventArgs e)
        {
            if(refForm == "EditDir")
            {
                this.Close();
                refFormEditDir.Close();
            }
            else
            {
                this.Close();
                refFormCreatingNewDB.Close();
            }
        }

        private void BNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
