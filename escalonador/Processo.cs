using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace escalonador
{


    class Processo
    {        
        public int ordem
        {
            get
            {
                return ordem;
            }
            set
            {
                this.ordem = ordem;
            }
        }
        public string descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                this.descricao = descricao;
            }

        }
        public int tempo
        {
            get
            {
                return tempo;
            }
            set
            {
                this.tempo = tempo;
            }

        }
        public string status
        {
            get
            {
                return status;
            }
            set
            {
                this.status = status;
            }
        }
        public string processador
        {
            get
            {
                return processador;
            }
            set
            {
                this.processador = processador;
            }
        }
        public int lala { get; set; }
        public static Thread run()
        {
            while (true)
            {

            }
        }

        public void teste1()
        {
            var thread = new Thread(new TesteT().teste());

            thread.Start();

        }
    }

    public class TesteT
    {
        public ThreadStart teste()
        {
            throw new NotImplementedException();
        }
    }
}
