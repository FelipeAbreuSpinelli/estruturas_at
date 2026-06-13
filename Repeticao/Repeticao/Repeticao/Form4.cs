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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnBack3_Click(object sender, EventArgs e)
        {
            Form1 FormInicio = new Form1();
            FormInicio.Show();
            this.Close();
        }

        private void BtnFor_Click(object sender, EventArgs e)
        {
            int num = 0;
            BoxFor.Items.Clear();
            for (num = 0; num <= 10; num++)
            {
                int calc = num * num;
                BoxFor.Items.Add(num + "X" + num + " = " + calc);
            }
        }
    }
}
