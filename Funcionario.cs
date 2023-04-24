using System.Globalization;

namespace exercicioClasses6
{
  public class Funcionario
  {
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
      return SalarioBruto - Imposto;
    }
    public void AumentarSalario(double porcentragem)
    {
      SalarioBruto = SalarioBruto + (SalarioBruto * porcentragem / 100.0);
    }
    public override string ToString()
    {
      return Nome
      + " , R$ "
      + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

    }
  }
}