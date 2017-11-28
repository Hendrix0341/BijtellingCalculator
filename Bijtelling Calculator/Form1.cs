using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bijtelling_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int belastingschijf = 41;
            int catalogusPrice = Convert.ToInt32(textBox1.Text);
            int bijtellingKlasse = Convert.ToInt32(textBox2.Text);
            int totaleJaarBedrag = catalogusPrice / 100 * bijtellingKlasse;
            int maandBedrag = totaleJaarBedrag / 100 * belastingschijf / 12;
            textBox3.Text = maandBedrag.ToString();
        }
    }
}
