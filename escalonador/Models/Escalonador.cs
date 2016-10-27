using System;
using System.Collections.Generic;
using System.Linq;

namespace EscalonadorDeProcessos.Models
{
    public class Escalonador
    {
        public Escalonador()
        {
            Processos = new List<Processo>();
            Processadores = new List<Processador>();
        }

        public IList<Processo> Processos { get; }
        public IList<Processador> Processadores { get; }

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

        public void ExecutarProcessos(TipoProcessador tipo)
        {
            switch (tipo)
            {
                case TipoProcessador.Simples:
                {
                    ExecutarProcessosPorMetodoSimples();
                    break;
                }
                case TipoProcessador.RoundRobin:
                {
                    ExecutarProcessosPorMetodoRoundRobin();
                    break;
                }
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
                }
            }
        }

        private void ExecutarProcessosPorMetodoRoundRobin()
        {
            throw new NotImplementedException();
        }

        private void ExecutarProcessosPorMetodoSimples()
        {
            throw new NotImplementedException();
        }
    }
}