using System;
using System.Linq;
using System.Windows.Forms;
using EscalonadorDeProcessos.Controllers;
using EscalonadorDeProcessos.Models;

namespace EscalonadorDeProcessos.Views
{
    public partial class FormularioEscalonador : Form
    {
        public FormularioEscalonador(FormularioEscalonadorController controller)
        {
            InitializeComponent();
            PreencherValoresATela();
            Controller = controller;
        }

        protected FormularioEscalonadorController Controller { get; set; }

        private void PreencherValoresATela()
        {
            foreach (var estado in Enum.GetValues(typeof (EstadoProcesso)))
            {
                ComboStatus.Items.Add(estado);
            }

            foreach (var tipo in Enum.GetValues(typeof (TipoProcessador)))
            {
                ComboTipoProcessador.Items.Add(tipo);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CriarProcesso(object sender, EventArgs e)
        {
            Controller.CriarProcesso(TxtDescricaoProcesso.Text, TxtTempoProcesso.Text, ComboStatus.Text);
            AtualizarProcessosNaTela();
            LimpaTela();
        }

        private void CriarProcessoAleatorio(object sender, EventArgs e)
        {
            var valorAleatorio = new Random().Next();
            var valorStatusAleatorio = new Random().Next(Enum.GetValues(typeof (EstadoProcesso)).Length);
            Controller.CriarProcesso($"Random - {valorAleatorio}", $"{valorAleatorio}",
                Enum.GetName(typeof (EstadoProcesso), valorStatusAleatorio));
            AtualizarProcessosNaTela();
        }

        private void PausarProcessos(object sender, EventArgs e)
        {
        }

        private void FinalizarProcessos(object sender, EventArgs e)
        {
        }

        private void AdicionarConfiguracao(object sender, EventArgs e)
        {
            Controller.CriarProcessador(TxtTempoProcessador.Text, TxtNucleosProcessador.Text);
            AtualizarProcessadoresNaTela();
        }

        private void AtualizarProcessosNaTela()
        {
            GridProcessosEmEspera.Rows.Clear();
            Controller.ListarProcessos()
                .ToList()
                .ForEach(
                    p => GridProcessosEmEspera.Rows.Add(p.Ordem, p.Descricao, p.Estado, p.Tempo));
            GridProcessosEmEspera.Update();
            GridProcessosEmEspera.Refresh();
        }

        private void AtualizarProcessadoresNaTela()
        {
            GridProcessadores.Rows.Clear();
            Controller.ListarProcessadores()
                .ToList()
                .ForEach(
                    p => GridProcessadores.Rows.Add(p.TempoQuantum, p.MaxDeProcessos));
            GridProcessadores.Update();
            GridProcessadores.Refresh();
        }

        public void LimpaTela()
        {
            TxtDescricaoProcesso.Text = "";
            ComboStatus.SelectedIndex = 0;
            TxtTempoProcesso.Text = "";
        }

        private void BtnLimparProcessador_Click(object sender, EventArgs e)
        {
            Controller.LimparProcessadores();
            AtualizarProcessadoresNaTela();
        }

        private void ExecutarProcessos(object sender, EventArgs e)
        {
            Controller.ExecutarProcessos(ComboTipoProcessador.Text);
        }
    }
}