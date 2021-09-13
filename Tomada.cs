using System;

namespace Adapter {
  class Tomada {
    private bool ligado;
    public bool Ligado {
      get {
        return this.ligado;
      }
      set {
        this.ligado = value;
        Console.WriteLine(">>> {0}Ligando Aparelho", this.ligado ? "" : "Des");
      }
    }
  }
}
