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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 FormInicio = new Form1();
            FormInicio.Show();
            this.Close();
        }

        private void BtnDoWhile_Click(object sender, EventArgs e)
        {
            int num = 5;
            int result = 1;
            int i = num;


            do
            {
                result = result * i;
                i--;

            }
            while (i >= 1); 
             BoxDoWhile.Items.Clear();
            BoxDoWhile.Items.Add(num + "! =" + result);
        }
    }
}
