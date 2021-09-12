using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adapter {
    class Lavadora : Tomada, IAparelho {

        public String Liga () {
            this.Ligado = true;
            Console.WriteLine ("A lavadora está lavando roupas");
            this.Lavar ();
            this.Centrifugar ();
            this.Enxaguar ();
            this.Centrifugar ();
            this.Enxaguar ();
            this.Centrifugar ();
            return this.Desliga ();
        }


        public String Desliga () {
            this.Ligado = false;
            return "Agora a lavadora está desligada";
        }
        public void Lavar () {
            Console.WriteLine ("\tAdicionando água e sabão em pó...");
            Thread.Sleep (2000);
            Console.WriteLine ("\tLavando...");
        }
        private void Enxaguar () {
            Thread.Sleep (1000);
            Console.WriteLine ("\tEnxaguando...");
        }
        private void Centrifugar () {
            Thread.Sleep (1000);
            Console.WriteLine ("\tCentrifugando...");
        }

    }
}
