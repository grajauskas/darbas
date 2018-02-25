using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis_Darbas
{
    public partial class Atl_i_rankas : Form
    {
        public Atl_i_rankas()
        {
            InitializeComponent();
        }

        private void textBoxSuma_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSkaicevimas_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToDouble(textBoxSuma.Text);
            var antras = 0.15;
            var trecias = 0.06;
            var ketvirtas = 0.03;
            var penktas = 0.30;
            var sestas = 0.002;
            var septintas = 0.005;

            var vmi = pirmas * antras;
            var sodSveikDrau = pirmas * trecias;
            var sodPencDrau = pirmas * ketvirtas;
            var iRankas = pirmas + (pirmas * antras) + (pirmas * trecias) + (pirmas * ketvirtas);
            var darbSodra = iRankas + (pirmas * penktas) + (pirmas * sestas) + (pirmas * septintas);

            textBoxSuma.Text = "";

            MessageBox.Show("Pajamų mokestis 15 % (VMI): " + vmi);
            MessageBox.Show("Sodra. Sveikatos draudimas 6 % (Sodra): " + sodSveikDrau);
            MessageBox.Show("Sodra. Pensijų ir soc. draudimas 3 % (Sodra): " + sodPencDrau);
            MessageBox.Show("Priskaičiuotas atlyginimas (ant popieriaus): " + iRankas);
            MessageBox.Show("Jusu darbo vietatos kaina darbdaviui: " + darbSodra);

        }

        private void Atl_i_rankas_Load(object sender, EventArgs e)
        {

        }
    }
}
