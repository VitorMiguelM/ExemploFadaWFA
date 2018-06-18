using ExercícioFada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaFadinha
{
    public partial class Lista : Form
    {
        List<Fada> fadas = new List<Fada>();

        public Lista()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fada fadas = new Fada();
                string Nome = txtNome.Text;
                string Familia = cbFamilia.SelectedItem.ToString();
                string Cor = cbCor.SelectedItem.ToString();
                string CorDaAsa = cbCorDaAsa.SelectedItem.ToString();
                string Elemento = cbElemento.SelectedItem.ToString();

                
            }
            catch
            {

            }
        }

        private void AdicionarFadaNaTabalha()
        {

        }

       

        

    }
}
