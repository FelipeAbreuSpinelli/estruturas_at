using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repeticao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack2_Click(object sender, EventArgs e)
        {
            Form1 FormInicio = new Form1();
            FormInicio.Show();
            this.Close();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            int num = 250;
            int i = 1;

            BoxWhile.Items.Clear();
            while (i <= 50)
            {
                int resultado = num * i / 100;
                BoxWhile.Items.Add(i + "% de " + num + " = " + resultado);
                i++;
            }
            {

            }
        }
    }
 }