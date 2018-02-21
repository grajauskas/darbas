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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Iskviecia lentele kur vyks skaicevimai//
        private void button1_Click(object sender, EventArgs e)
        {
           var iRankas = new Atl_i_rankas();
           iRankas.ShowDialog();

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Iskviecia lentele kur vyks skaicevimai//
        private void button2_Click(object sender, EventArgs e)
        {
            var antPoperiaus = new Atl_ant_pop();
            antPoperiaus.ShowDialog();
        }
    }
}
