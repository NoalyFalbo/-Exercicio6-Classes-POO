using System;
using System.Globalization;

namespace exercicioClasses6
{

  class Program
  {

    static void Main(string[] args)
    {

      Console.Clear();

      Funcionario func = new Funcionario();

      Console.WriteLine("Nome: ");
      func.Nome = Console.ReadLine();
      Console.WriteLine("Salario Bruto: ");
      func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Imposto: ");
      func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine();
      Console.WriteLine("Funcionário: " + func);

      Console.WriteLine();
      Console.WriteLine("Deseja aumentar o salario em qual porcentagem? ");
      double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      func.AumentarSalario(porcent);

      Console.WriteLine();
      Console.WriteLine("Dados atualizados: " + func);

    }
  }
}