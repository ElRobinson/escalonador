using System;
using System.Collections.Generic;
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

        public IList<Processo> ListarProcessos()
        {
            return Escalonador.ListarProcessos();
        }
    }
}