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
        }

        private void listaNumereTB_TextChanged(object sender, EventArgs e)
        {
            String stringSir = listaNumereTB.Text;
            if(String.IsNullOrWhiteSpace(stringSir))
            {
                numarPPTB.Text = "0";
                return;
            }
            String[] subsiruri = stringSir.Split(',');

            listaNumere = new List<UInt64>();

            foreach (String subsir in subsiruri)
            {
                UInt64 numar;
                if (UInt64.TryParse(subsir.Trim(), out numar))
                {
                    listaNumere.Add(numar);
                }
                else
                {
                    numarPPTB.Text = "Eroare in sirul dat!";
                    return;
                }
            }

            numarPPTB.Text = alg.numaraPatratePerfecte(listaNumere).ToString();
        }
    }
}
