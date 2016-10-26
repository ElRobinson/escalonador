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
            Escalonador.CriarProcesso(descricao, int.Parse(tempoDeVida), (EstadoProcesso) Enum.Parse(typeof (EstadoProcesso), status));
        }

        public void ValidaProcesso(string descricao, string tempoDeVida, string status)
        {
            if (descricao.Length > 1)
            {
                if (!status.Equals(""))
                {
                    if (tempoDeVida.Length > 0)
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
            else
            {
                MessageBox.Show("### erro, descrição inválida");
            }
        }

        public IList<Processo> ListarProcessos()
        {
            return Escalonador.ListarProcessos();
        }
    }
}