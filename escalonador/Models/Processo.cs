using System;
using System.ComponentModel;

namespace EscalonadorDeProcessos.Models
{
    public class Processo : INotifyPropertyChanged
    {     
        public event PropertyChangedEventHandler PropertyChanged;

        private int _ordem { get; set; }
        private string _descricao { get; set; }
        private int _tempo { get; set; }
        private int _tempoExecutado;

        public int Ordem { get { return _ordem; } set { _ordem = value; NotifyPropertyChanged(); } }
        public string Descricao { get; set; }
        public string Processador { get; set; }
        public int Tempo { get { return _tempo; } set { _tempo = value; NotifyPropertyChanged(); } }
        public int TempoExecutado { get { return _tempoExecutado; } set { _tempoExecutado = value; NotifyPropertyChanged(); } }
        
        private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public Processo(int ordem, string descricao, int tempo, EstadoProcesso estado)
        {
            Ordem = ordem;
            Descricao = descricao;
            Tempo = tempo;
            TempoExecutado = 0;
            Estado = estado;
        }         

        public EstadoProcesso Estado { get; set; }
    }
}