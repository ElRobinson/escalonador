using System;
using System.Collections.Generic;
using System.Linq;
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

        public async void ExecutarProcessos(TipoProcessador tipo)
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

        private async Task ExecutarProcessosPorMetodoRoundRobin()
        {
            throw new NotImplementedException();
        }

        private async Task ExecutarProcessosPorMetodoSimples()
        {
            var tempoSobraDeExecucao = 0;
            while (!TodosProcessosForamProntos())
            {
                var processoAtual = Processos.FirstOrDefault(p => p.Estado.Equals(EstadoProcesso.Novo));

                processoAtual.Estado = EstadoProcesso.EmExecucao;

                while (processoAtual.Tempo > processoAtual.TempoExecutado)
                {
                    var tempoGanhoDeExecucao = ExecucaoDeProcessadoresSimples() + tempoSobraDeExecucao;
                    if (processoAtual.Tempo <= processoAtual.TempoExecutado + tempoGanhoDeExecucao)
                    {
                        processoAtual.TempoExecutado += tempoGanhoDeExecucao;
                        if (processoAtual.Tempo == processoAtual.TempoExecutado)
                        {
                            processoAtual.Estado = EstadoProcesso.Pronto;
                        }
                    }
                    else
                    {
                        tempoSobraDeExecucao = (processoAtual.TempoExecutado + tempoGanhoDeExecucao) - processoAtual.Tempo;
                        processoAtual.TempoExecutado = processoAtual.Tempo;
                    }
                }
            }

            Processos.ToList().ForEach(p => p.Estado = EstadoProcesso.Encerrado);
        }

        private int ExecucaoDeProcessadoresSimples()
        {
            return Processadores.Aggregate(0, (lastValue, p) => lastValue + (p.MaxDeProcessos * p.TempoQuantum) + 1);
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