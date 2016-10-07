namespace EscalonadorDeProcessos.Models
{
    public class Processo
    {
        public int Ordem { get; set; }
        public string Descricao { get; set; }
        public int Tempo { get; set; }
        public EstadoProcesso Estado { get; set; }
        public string Processador { get; set; }
    }
}
