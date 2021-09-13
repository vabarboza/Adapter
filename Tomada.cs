using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    class Tomada {
        private bool ligado;
        public bool Ligado {
            get {
                return this.ligado;
            }
            set {
                this.ligado = value;
                Console.WriteLine (">>> {0}Ligando Aparelho", this.ligado ? "" : "Des");
            }
        }
    }
}
