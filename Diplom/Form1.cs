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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CBox1.SelectedIndexChanged += CBox1_SelectedIndexChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBox1.SelectedIndex == CBox1.Text[0])
            {
                MessageBox.Show("1");
            }
            else
            {
                MessageBox.Show("0");
            }
        }

    }
}
