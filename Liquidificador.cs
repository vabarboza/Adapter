using System;
using System.Threading;

namespace Adapter {
  class Liquidificador : Tomada, IAparelho {

    public String Liga() {
      this.Ligado = true;
      Console.WriteLine("O liquidificador está ligado");
      this.AdicionadoAlimento();
      this.Misturando();
      this.Parando();
      return this.Desliga();
    }


    public String Desliga() {
      this.Ligado = false;
      return "O liquidificador está desligado";
    }

    public void AdicionadoAlimento() {
      Console.WriteLine("\tAdicionando alimento no liquidificador...");
      Thread.Sleep(2000);
      Console.WriteLine("\tAdicionado...");
    }
    private void Misturando() {
      Thread.Sleep(1000);
      Console.WriteLine("\tBatendo os alimentos...");
    }
    private void Parando() {
      Thread.Sleep(1000);
      Console.WriteLine("\tDesligando o liquidificador...");
    }

  }
}
