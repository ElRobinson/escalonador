using System.Collections.Generic;
using System.Windows.Forms;

namespace EscalonadorDeProcessos.Controllers
{
    public class Controller
    {
        protected List<Form> Views { get; set; }
        public virtual Form MainView => Views[0];

        public Controller()
        {
            Views = new List<Form>();
        }

        public void AddView(Form view)
        {
            Views.Add(view);
        }
    }
}