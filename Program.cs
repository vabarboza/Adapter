using System;

namespace Adapter {
  class Program {
    static void Main(string[] args) {

      IAparelho a = new Liquidificador();
      Console.WriteLine(a.Liga());
      //Console.WriteLine(a.Off());
      Console.WriteLine();
      a = new Lavadora();
      Console.WriteLine(a.Liga());
      Console.ReadKey();

    }
  }
}
