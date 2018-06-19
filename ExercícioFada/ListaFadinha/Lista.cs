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
           
            
            Fada fada = new Fada()
                {
                    Nome = txtNome.Text,
                    Familia = cbFamilia.SelectedItem.ToString(),
                    Cor = cbCor.SelectedItem.ToString(),
                    CorDaAsa = cbCorDaAsa.SelectedItem.ToString(),
                    Elemento = cbElemento.SelectedItem.ToString(),
                    Mulher = ckbMulherCr.Checked,
                     
                };
        fadas.Add(fada);
        AdicionarFadaNaTabela(fada);
        MessageBox.Show("Salvo com sucesso");
        LimparCampos();
           
            

            
        }

        private void AdicionarFadaNaTabela(Fada fada)
        {
            dgvLista.Rows.Add(new Object[] { fada.Nome, fada.Familia, fada.Elemento, fada.Mulher, });
        }

        private void AdicionarFadaNaTabelaCr1(Fada fada)
        {
            dgvLista.Rows.Add(new Object[] {fada.Nome, fada.Familia, fada.Cor });

        }

        private void AdicionarFadaNaTabelaCr2(Fada fada)
        {
            dgvLista.Rows.Add(new Object[] { fada.Nome, fada.Cor, fada.Mulher });
        }
        public void LimparCampos()
        {
            txtNome.Text = "";
            cbFamilia.SelectedItem = "";
            cbCor.SelectedItem = "";
            cbCorDaAsa.SelectedItem = "";
            cbElemento.SelectedItem = "";
            
            
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
            Fada fada = new Fada(txtNomeCr1.Text, cbFamiliaCr.SelectedItem.ToString(), cbCorCr1.SelectedItem.ToString())
            {
                
            };
            AdicionarFadaNaTabelaCr1(fada);
            MessageBox.Show("Cadastrado com sucesso !");
        }

        private void btnCadastroRapido2_Click(object sender, EventArgs e)
        {
            Fada fada = new Fada(txtNomeCr2.Text, cbCorCr2.SelectedItem.ToString(), ckbMulherCr.Checked);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha, por favor!");
                return;
            }

            if (dgvLista.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada, por favor !");
                return;
            }

            int linhaSelecionada = dgvLista.CurrentRow.Index;

            string nomeFada = dgvLista.Rows[linhaSelecionada].Cells[0].Value.ToString();

            fadas.Remove(fadas.Find(x => x.Nome == nomeFada));

        }

        


        
    }
}
