using System;

namespace EscalonadorDeProcessos.Models
{
    public class Processo
    {
        private int _tempoExecutado;

        public Processo()
        {
        }

        public Processo(int ordem, string descricao, int tempo, EstadoProcesso estado)
        {
            Ordem = ordem;
            Descricao = descricao;
            Tempo = tempo;
            TempoExecutado = 0;
            Estado = estado;
        }

        public int Ordem { get; set; }
        public string Descricao { get; set; }
        public int Tempo { get; set; }

        public int TempoExecutado
        {
            get { return _tempoExecutado; }
            set
            {
                if (value > Tempo)
                {
                    throw new ArgumentException("TempoExecutado não pode ser maior que o Tempo!");
                }
                _tempoExecutado = value;
            }
        }

        public EstadoProcesso Estado { get; set; }
    }
}