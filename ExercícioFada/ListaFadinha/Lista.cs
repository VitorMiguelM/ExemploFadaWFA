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
                Fada fada = new Fada()
                {
                    Nome = txtNome.Text,
                    Familia = cbFamilia.SelectedItem.ToString(),
                    Cor = cbCor.SelectedItem.ToString(),
                    CorDaAsa = cbCorDaAsa.SelectedItem.ToString(),
                    Elemento = cbElemento.SelectedItem.ToString(),
                    Sexo = txtSexo.Text,
                     
                };
                fadas.Add(fada);
                MessageBox.Show("Salvo com sucesso");
                AdicionarFadaNaTabela(fada);
            }
            catch
            {

            }
        }

        private void AdicionarFadaNaTabela(Fada fada)
        {
            dgvLista.Rows.Add(new Object[] { fada.Nome, fada.Familia, fada.Elemento, fada.Sexo, });
        }

        public void LimparCampos()
        {
            txtNome.Text = "";
            cbFamilia.SelectedItem = "";
            cbCor.SelectedItem = "";
            cbCorDaAsa.SelectedItem = "";
            cbElemento.SelectedItem = "";
            txtSexo.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvLista.Rows.Count == 0)
            {
                MessageBox.Show("Adicione uma fada !");
                return;
            }

            if (dgvLista.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo");
                return;
            }

            int linhaSelecionada = dgvLista.CurrentRow.Index;

            string nomeFada = dgvLista.Rows[linhaSelecionada].Cells[0].Value.ToString();
           
            fadas.Remove(fadas.Find(x => x.Nome == nomeFada));
        }

        private void btnCadastroRapido1_Click(object sender, EventArgs e)
        {
            Fada fada = new Fada(txtNome.Text, cbFamilia.SelectedItem, cbCor.SelectedItem);
        }

        
    }
}
