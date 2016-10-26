namespace EscalonadorDeProcessos.Models
{
    public class Processador
    {
        public Processador()
        {
        }

        public Processador(int tempoQuantum, int maxDeProcessos)
        {
            TempoQuantum = tempoQuantum;
            MaxDeProcessos = maxDeProcessos;
        }

        public int TempoQuantum { get; set; }
        public int MaxDeProcessos { get; set; }
    }
}