using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDoWhile_Click(object sender, EventArgs e)
        {
            Form3 FormDoWhile = new Form3();
            FormDoWhile.Show();
            this.Hide();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            Form2 FormWhile = new Form2();
            FormWhile.Show();
            this.Hide();
        }

        private void BtnFor_Click(object sender, EventArgs e)
        {
            Form4 FormFor = new Form4();
            FormFor.Show();
            this.Hide();
        }

        private void BtnForEach_Click(object sender, EventArgs e)
        {
            LsbMostraForEach FormForEach = new LsbMostraForEach();
            FormForEach.Show();
            this.Hide();
        }
    }
}
