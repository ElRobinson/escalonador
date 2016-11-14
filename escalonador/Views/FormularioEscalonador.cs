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

        private BindingSource customersBindingSource = new BindingSource();

        private void PreencherValoresATela()
        {
            foreach (var estado in Enum.GetValues(typeof(EstadoProcesso)))
                ComboStatus.Items.Add(estado);

           
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
        
        private void AdicionarConfiguracao(object sender, EventArgs e)
        {
            Controller.CriarProcessador(TxtTempoProcessador.Text, TxtNucleosProcessador.Text);
            AtualizarProcessadoresNaTela();
        }

        private void AtualizarProcessosNaTela()
        {
            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(c => c.Estado != EstadoProcesso.Espera).ToList());   
            GridProcessos.DataSource = customersBindingSource.DataSource;

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(c => c.Estado == EstadoProcesso.Espera).ToList());
            GridProcessosEmEspera.DataSource = customersBindingSource.DataSource;
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
            //Controller.ExecutarProcessos(ComboTipoProcessador.Text);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarProcessosNaTela();
        }
    }
}