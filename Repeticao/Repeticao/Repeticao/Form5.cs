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
    public partial class LsbMostraForEach : Form
    {
        public LsbMostraForEach()
        {
            InitializeComponent();
        }

        private void BtnBack4_Click(object sender, EventArgs e)
        {
            Form1 FormInicio = new Form1();
            FormInicio.Show();
            this.Close();
        }

        private void BtnForEach_Click(object sender, EventArgs e)
        {

            string[] frases = {"Convocação da Seleção Brasileira:"
            , "Alisson-Liverpool","Ederson-Fenerbahçe", "Weverton-Grêmio"
            ,"Marquinhos-PSG","Léo Pereira-Flamengo","Bremer-Juventus","Gabriel magalhães-Arsenal","Ibañez-Al Ahli"
            , "Wesley-Roma","Danilo-Flamengo", "Alex Sandro-Flamengo", "Douglas Santos-Zenit"
            ,"Bruno Guimarães-Newcastle","Casemiro-Manchester United","Danilo Santos-Botafogo","Fabinho-Al Itihadd","Lucas Paquetá-Flamengo"
            ,"Endrick-Lyon","Gabriel Martinelli-Arsenal","Igor Thiago-Brentford","Luiz Henrique-Zenit","Matheus Cunha-Manchester United"
            ,"Neymar Júnior-Santos","Raphinha-Barcelona","Rayan-Bornemouth","Vinícius Júnior-Real Madrid"};
            BoxForEach.Items.Clear();
            foreach (string messages in frases)
            {
                BoxForEach.Items.Add(messages);
            }
        }
    }
}
