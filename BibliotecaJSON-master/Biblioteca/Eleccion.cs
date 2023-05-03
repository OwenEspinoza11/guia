using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Eleccion : Form
    {
        public Eleccion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 pantalla = new Form1();
            this.Hide();
            pantalla.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("𝓔𝓢𝓣𝓐 𝓢𝓔𝓖𝓤𝓡𝓞 𝓓𝓔 𝓢𝓐𝓛𝓘𝓡?",
                       "Biblioteca JSON",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
