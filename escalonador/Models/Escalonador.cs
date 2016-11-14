using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EscalonadorDeProcessos.Models
{
    public class Escalonador
    {
        public IList<Processo> Processos { get; }
        public IList<Processador> Processadores { get; }
        public List<Thread> threads = new List<Thread>();

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

            threads.Add(new Thread(() =>
            {
                ThreadProcessador(Processadores.Last());
            }));

            threads[Processadores.Count - 1].Start();
        }

        public void ThreadProcessador(Processador processador)
        {
            int processadorNum = Processadores.Count - 1;

            while (true)
            {
                Thread.Sleep(2000);

                if (!Processos.Where(c => c.Estado == EstadoProcesso.Pronto).Any())
                    continue;
                
                var processo = Processos.Where(c => c.Estado == EstadoProcesso.Pronto).First();
                    
                processo.Estado = EstadoProcesso.EmExecucao;               
                processo.Processador = "Processador " + processadorNum;

                for (int i = 0; i < processador.TempoQuantum; i++)
                {
                    Thread.Sleep(200);

                    processo.Tempo--;                 

                    if (processo.Tempo == 0)
                    {
                        processo.Estado = EstadoProcesso.Encerrado;
                        Processos.Remove(processo);
                        break;
                    }
                }
                                
                if (processo.Estado != EstadoProcesso.Encerrado)
                {
                    processo.Estado = EstadoProcesso.Pronto;
                    processo.Processador = string.Empty;

                    Processos.Remove(processo);
                    Processos.Add(processo);
                }               
            }
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