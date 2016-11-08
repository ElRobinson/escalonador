using EscalonadorDeProcessos.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscalonadorDeProcessos.Controllers
{
    public class FormularioEscalonadorController : Controller
    {
        public FormularioEscalonadorController()
        {
            Escalonador = new Escalonador();
        }

        private Escalonador Escalonador { get; }

        public void CriarProcessador(string tempo, string nucleos)
        {
            if (ProcessadorEhValido(tempo, nucleos))
            {
                Escalonador.CriarProcessador(int.Parse(tempo), int.Parse(nucleos));
            }
        }

        public void CriarProcesso(string descricao, string tempoDeVida, string status)
        {
            if (ProcessoEhValido(descricao, tempoDeVida, status))
            {
                Escalonador.CriarProcesso(descricao, int.Parse(tempoDeVida),
                    (EstadoProcesso)Enum.Parse(typeof(EstadoProcesso), status));
            }
        }

        private bool ProcessadorEhValido(string tempo, string nucleos)
        {
            var processadorEhValido = true;

            if (tempo.Length < 1)
            {
                processadorEhValido = false;
                MessageBox.Show("### erro, tempo inválido ###");
            }

            if (nucleos.Length <= 0)
            {
                processadorEhValido = false;
                MessageBox.Show("### erro, nucleos inválido ###");
            }

            return processadorEhValido;
        }

        private bool ProcessoEhValido(string descricao, string tempoDeVida, string status)
        {
            var processoEhValido = true;

            if (descricao.Length < 1)
            {
                processoEhValido = false;
                MessageBox.Show("### erro, descrição inválida");
            }

            if (status.Equals(""))
            {
                processoEhValido = false;
                MessageBox.Show("### erro, prioridade inválida ###");
            }

            if (tempoDeVida.Length <= 0)
            {
                processoEhValido = false;
                MessageBox.Show("### erro, tempo inválido ###");
            }

            return processoEhValido;
        }

        public IList<Processo> ListarProcessos()
        {
            return Escalonador.Processos;
        }

        public void LimparProcessadores()
        {
            Escalonador.LimparProcessadores();
        }

        public IList<Processador> ListarProcessadores()
        {
            return Escalonador.Processadores;
        }

        public void ExecutarProcessos(string tipoProcessador)
        {
            Escalonador.ExecutarProcessos((TipoProcessador)Enum.Parse(typeof(TipoProcessador), tipoProcessador));
        }

        public bool TodosProcessosForamEncerrados()
        {
            return Escalonador.TodosProcessosForamEncerrados();
        }
    }
}