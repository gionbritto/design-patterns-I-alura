public class Arrojado : PerfilInvestimento
{
    public double Investir(double saldoConta)
    {
        var acertividadeDaOperacao = OperarInvestimento();
        Console.WriteLine($"Acertividade em Arrojado: {acertividadeDaOperacao}");
        if (acertividadeDaOperacao <= 20)
        {
            return saldoConta * 0.05;
        }

        if (acertividadeDaOperacao >= 20 && acertividadeDaOperacao <= 50)
        {
            return saldoConta * 0.03;
        }

        return saldoConta * 0.006;
    }

    private static int OperarInvestimento()
    {
        return new Random().Next(101);
    }
}