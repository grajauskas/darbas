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
    public partial class Atl_ant_pop : Form
    {
        public Atl_ant_pop()
        {
            InitializeComponent();
        }

        private void textBoxAntPop_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToDouble(textBoxAntPop.Text);
            var antras = 0.15;
            var trecias = 0.06;
            var ketvirtas = 0.03;

            var vmi = pirmas * antras;
            var sodSveikDrau = pirmas * trecias;
            var sodPencDrau = pirmas * ketvirtas;
            var antPop = pirmas - (pirmas * antras) - (pirmas * trecias) - (pirmas * ketvirtas);

            textBoxAntPop.Text = "";

            MessageBox.Show("Pajamų mokestis 15 % (VMI): " + vmi);
            MessageBox.Show("Sodra. Sveikatos draudimas 6 % (Sodra): " + sodSveikDrau);
            MessageBox.Show("Sodra. Pensijų ir soc. draudimas 3 % (Sodra): " + sodPencDrau);
            MessageBox.Show("Priskaičiuotas atlyginimas (i rankas): " + antPop);

        }

      
    }
}
