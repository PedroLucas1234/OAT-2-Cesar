using System;
public class Program {
  public static void Main() {
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0) {
      Console.WriteLine("O número {0} é par.", numero);
    } else {
      Console.WriteLine("O número {0} é ímpar.", numero);
    }
  }
}
