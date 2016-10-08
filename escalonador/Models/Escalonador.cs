using System.Linq;
using System.Collections.Generic;

namespace EscalonadorDeProcessos.Models
{
    public class Escalonador
    {
        private IList<Processo> Processos { get; set; }

        public Escalonador()
        {
            Processos = new List<Processo>();
        }

        public void CriarProcesso(string descricao, int tempo, EstadoProcesso estado)
        {
            var ordem = Processos.Count == 0 ? 0 : Processos.Max(p => p.Ordem) + 1;
            Processos.Add(new Processo(ordem, descricao, tempo, estado));
        }

        public IList<Processo> ListarProcessos()
        {
            return Processos;
        }
    }
}
