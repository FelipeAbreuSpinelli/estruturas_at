using System.Windows.Forms;

namespace Condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string jogador20 = "Lucas Paquetá";
            string senha = "Hexa";


            if (jogador20 == Paquetatxt.Text && senha == Senhatxt.Text)
            {
                Form2 FormImg = new Form2();
                FormImg.ShowDialog();

            }
            else
            {
              MessageBox.Show("Jogador ou senha incorretos", "Digite Novamente",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question
              );
                Paquetatxt.Clear();
                Senhatxt.Clear();
                Paquetatxt.Focus();
            }
        }
    }
}