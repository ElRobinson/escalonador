using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EscalonadorDeProcessos.Models;

namespace EscalonadorDeProcessos.Controllers
{
    public class FormularioEscalonadorController : Controller
    {
        private Escalonador Escalonador { get; }

        public FormularioEscalonadorController()
        {
            Escalonador = new Escalonador();
        }

        public void CriarProcesso(string descricao, string tempoDeVida, string status)
        {
            if (ProcessoEhValido(descricao, tempoDeVida, status))
            {
                Escalonador.CriarProcesso(descricao, int.Parse(tempoDeVida),
                    (EstadoProcesso) Enum.Parse(typeof (EstadoProcesso), status));
            }
        }

        public bool ProcessoEhValido(string descricao, string tempoDeVida, string status)
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
            return Escalonador.ListarProcessos();
        }
    }
}