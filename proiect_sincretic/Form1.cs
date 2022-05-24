using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_sincretic
{
    public partial class Form1 : Form
    {
        Algoritm alg;
        List<UInt64> listaNumere;

        public Form1()
        {
            InitializeComponent();
            alg = new Algoritm();

            listaNumere = new List<UInt64>();
            listaNumere.AddRange(new UInt64[] { 32, 64, 16, 8, 9, 13});
            MessageBox.Show(alg.numaraPatratePerfecte(listaNumere).ToString());
        }
    }
}
