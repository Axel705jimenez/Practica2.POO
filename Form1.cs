  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaclase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Delfin D;
            D = new Delfin();
            D.Piel = "Suave y gomosa";
            MessageBox.Show(D.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Marino m;
            m = new Marino();
            m.NombreDelAnimal = "Delfin";
            MessageBox.Show(m.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal a;
            a = new Animal();
            a.TipoDdeAnimal = "Mamifero";
            MessageBox.Show(a.ToString());
        }

        private void btnDelfin1_Click(object sender, EventArgs e)
        {
            Delfin D;
            D = new Delfin();
            D.Habitat = "Oceano";
            MessageBox.Show(D.ToString());
        }

    }
}
