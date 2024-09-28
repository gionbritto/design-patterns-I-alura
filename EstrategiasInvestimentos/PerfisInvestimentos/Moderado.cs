
public class Moderado : PerfilInvestimento
{
    public double Investir(double saldoConta)
    {
        var acertividadeDaOperacao = OperarInvestimento();
        Console.WriteLine($"Acertividade em Moderado: {acertividadeDaOperacao}");
        if (acertividadeDaOperacao > 50)
        {
            return saldoConta * 0.025;
        }

        return saldoConta * 0.007;
    }

    private static int OperarInvestimento()
    {
        return new Random().Next(101);
    }


    //     private Random random;    
    // public Moderado() 
    // {
    //     this.random = new Random();
    // } 
    // public double calcula(Conta conta) 
    // {
    //     if(random.Next(2) == 0) 
    //         return conta.Saldo * 0.025;
    //     else 
    //         return conta.Saldo * 0.007;
    // }
}