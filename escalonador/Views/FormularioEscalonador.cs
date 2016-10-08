using System;
using System.Linq;
using System.Windows.Forms;
using EscalonadorDeProcessos.Controllers;
using EscalonadorDeProcessos.Models;

namespace EscalonadorDeProcessos.Views
{
    public partial class FormularioEscalonador : Form
    {
        protected FormularioEscalonadorController Controller { get; set; }
        public FormularioEscalonador()
        {
            InitializeComponent();
            PreencherValoresATela();
            Controller = new FormularioEscalonadorController();
        }

        private void PreencherValoresATela()
        {
            foreach (var estado in Enum.GetValues(typeof (EstadoProcesso)))
            {
                ComboStatus.Items.Add(estado);
            }
        }

        private void CriarProcessoAleatorio(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PausarProcessos(object sender, EventArgs e)
        {

        }

        private void CriarProcesso(object sender, EventArgs e)
        {
            Controller.CriarProcesso(TxtDescricaoProcesso.Text, TxtTempoProcesso.Text, ComboStatus.Text);
            AtualizarProcessosNaTela();
        }

        private void AtualizarProcessosNaTela()
        {
            GridNaoProcessados.DataSource = null;
            GridNaoProcessados.DataSource = Controller.ListarProcessos().ToList();
            GridNaoProcessados.Refresh();
        }

        public void ValidaDados() {
            if (TxtDescricaoProcesso.Text.Length > 1)
            {
                if (!ComboStatus.SelectedItem.Equals(""))
                {
                    if (TxtTempoProcesso.Text.Length > 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("### erro, tempo inválido ###");
                    }
                }
                else
                {
                    MessageBox.Show("### erro, prioridade inválida ###");
                }
            }
            else {
                MessageBox.Show("### erro, descrição inválida");
            }
        }

        public void LimpaTela() {
            TxtDescricaoProcesso.Text = "";
            ComboStatus.SelectedIndex = 0;
            TxtTempoProcesso.Text = "";
        }

        public void CriaProcesso() {

        }

        private void FinalizarProcessos(object sender, EventArgs e)
        {

        }

        private void AdicionarConfiguracao(object sender, EventArgs e)
        {

        }
    }

    
}


