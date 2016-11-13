using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

        public void CriarProcesso(string descricao, int tempo, EstadoProcesso estado = EstadoProcesso.Novo)
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
            Task processo;

            switch (tipo)
            {
                case TipoProcessador.Simples:
                    {
                        processo = new Task(ExecutarProcessosPorMetodoSimples);
                        break;
                    }
                case TipoProcessador.RoundRobin:
                    {
                        processo = new Task(ExecutarProcessosPorMetodoRoundRobin);
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
                    }
            }

            processo.Start();
        }

        private async void ExecutarProcessosPorMetodoRoundRobin()
        {
            var listaDeThreads = new List<Thread>();
            while (!TodosProcessosForamProntos())
            {
                var processoAtual = Processos.FirstOrDefault(p =>
                    p.Estado.Equals(EstadoProcesso.Novo) || p.Estado.Equals(EstadoProcesso.Espera)
                );

                if (processoAtual != null)
                {
                    foreach (var processador in Processadores)
                    {
                        Task.Run(() => ExecutarProcessoEmProcessador(processoAtual, processador));
                    }

                    Thread.Sleep(Processadores.Sum(p => p.TempoQuantum * p.MaxDeProcessos));
                }
            }

            Processos.ToList().ForEach(p => p.Estado = EstadoProcesso.Encerrado);
        }

        private async void ExecutarProcessosPorMetodoSimples()
        {
            var listaDeThreads = new List<Thread>();
            while (!TodosProcessosForamProntos())
            {
                var processoAtual = Processos.FirstOrDefault(p =>
                    p.Estado.Equals(EstadoProcesso.Novo) || p.Estado.Equals(EstadoProcesso.Espera)
                );

                while (processoAtual != null && !processoAtual.Estado.Equals(EstadoProcesso.Pronto))
                {
                    foreach (var processador in Processadores)
                    {
                        Task.Run(() => ExecutarProcessoEmProcessador(processoAtual, processador));
                    }

                    Thread.Sleep(Processadores.Sum(p => p.TempoQuantum * p.MaxDeProcessos));
                }
            }

            Processos.ToList().ForEach(p => p.Estado = EstadoProcesso.Encerrado);
        }

        private async void ExecutarProcessoEmProcessador(Processo processo, Processador processador)
        {
            var novoTempo = (processo.TempoExecutado + processador.TempoQuantum);
            processo.Estado = EstadoProcesso.EmExecucao;
            processo.TempoExecutado = novoTempo < processo.Tempo ? novoTempo : processo.Tempo;

            if (processo.Tempo > processo.TempoExecutado)
            {
                processo.Estado = EstadoProcesso.Espera;
            }
            else
            {
                processo.Estado = EstadoProcesso.Pronto;
            }
        }

        private bool TodosProcessosForamProntos()
        {
            return ProcessosComEstado(EstadoProcesso.Pronto).Count.Equals(Processos.Count);
        }

        public bool TodosProcessosForamEncerrados()
        {
            return ProcessosComEstado(EstadoProcesso.Encerrado).Count.Equals(Processos.Count);
        }

        private IList<Processo> ProcessosComEstado(EstadoProcesso estado)
        {
            return Processos.Where(p => p.Estado.Equals(estado)).ToList();
        }
    }
}