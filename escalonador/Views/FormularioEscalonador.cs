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

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(n => n.Estado != EstadoProcesso.Espera).ToList());
            GridProcessos.DataSource = customersBindingSource.DataSource;

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(n => n.Estado == EstadoProcesso.Espera).ToList());
            GridProcessosEmEspera.DataSource = customersBindingSource.DataSource;
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
            int r = 0;
            int c = 0;

            if (GridProcessos.Rows.Count > 0)
            {
                r = GridProcessos.CurrentRow.Index;
                c = GridProcessos.CurrentCell.ColumnIndex;
            }

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(n => n.Estado != EstadoProcesso.Espera).ToList());   
            GridProcessos.DataSource = customersBindingSource.DataSource;

            if (c > 0 && GridProcessos.Rows.Count > 0)
                GridProcessos.CurrentCell = GridProcessos.Rows[r].Cells[c];

            r = 0;
            c = 0;
            if (GridProcessosEmEspera.Rows.Count > 0)
            {
                r = GridProcessosEmEspera.CurrentRow.Index;
                c = GridProcessosEmEspera.CurrentCell.ColumnIndex;
            }

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(n => n.Estado == EstadoProcesso.Espera).ToList());
            GridProcessosEmEspera.DataSource = customersBindingSource.DataSource;

            if (c > 0 && GridProcessosEmEspera.Rows.Count>0)
                GridProcessosEmEspera.CurrentCell = GridProcessosEmEspera.Rows[r].Cells[c];
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
            Controller.ListarProcessos()
                .Where(c => c.Ordem == Convert.ToInt16(GridProcessosEmEspera.CurrentRow.Cells["grid2Ordem"].Value.ToString()))
                .First().Estado=EstadoProcesso.Pronto;

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(n => n.Estado == EstadoProcesso.Espera).ToList());
            GridProcessosEmEspera.DataSource = customersBindingSource.DataSource;

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(n => n.Estado != EstadoProcesso.Espera).ToList());
            GridProcessos.DataSource = customersBindingSource.DataSource;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarProcessosNaTela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Controller.ListarProcessos()
                  .Where(c => c.Ordem == Convert.ToInt16(GridProcessos.CurrentRow.Cells["grid1Ordem"].Value.ToString()))
                  .First().Estado == EstadoProcesso.EmExecucao)
            {
                MessageBox.Show("Aguarde o processo ser executado");
                return;
            }

            Controller.ListarProcessos()
                  .Where(c => c.Ordem == Convert.ToInt16(GridProcessos.CurrentRow.Cells["grid1Ordem"].Value.ToString()))
                  .First().Estado = EstadoProcesso.Espera;

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(n => n.Estado != EstadoProcesso.Espera).ToList());
            GridProcessos.DataSource = customersBindingSource.DataSource;

            customersBindingSource.DataSource = (Controller.ListarProcessos().Where(n => n.Estado == EstadoProcesso.Espera).ToList());
            GridProcessosEmEspera.DataSource = customersBindingSource.DataSource;
        }
    }
}