namespace EscalonadorDeProcessos.Models
{
    public class Processo
    {
        public Processo()
        {
        }

        public Processo(int ordem, string descricao, int tempo, EstadoProcesso estado)
        {
            Ordem = ordem;
            Descricao = descricao;
            Tempo = tempo;
            Estado = estado;
        }

        public int Ordem { get; set; }
        public string Descricao { get; set; }
        public int Tempo { get; set; }
        public EstadoProcesso Estado { get; set; }
        public string Processador { get; set; }
    }
}
