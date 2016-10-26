using System.Linq;
using System.Collections.Generic;

namespace EscalonadorDeProcessos.Models
{
    public class Escalonador
    {
        public IList<Processo> Processos { get; }
        public IList<Processador> Processadores { get; }

        public Escalonador()
        {
            Processos = new List<Processo>();
            Processadores = new List<Processador>();
        }

        public void CriarProcesso(string descricao, int tempo, EstadoProcesso estado)
        {
            var ordem = Processos.Count == 0 ? 0 : Processos.Max(p => p.Ordem) + 1;
            Processos.Add(new Processo(ordem, descricao, tempo, estado));
        }

        public void CriarProcessador(int tempo, int nucleos)
        {
            Processadores.Add(new Processador(tempo, nucleos));
        }

        public void LimparProcessadores()
        {
            Processadores.Clear();
        }
    }
}
