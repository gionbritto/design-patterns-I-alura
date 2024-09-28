
public class RealizadorDeInvestimentos
{
    private readonly double _impostoSobreInvestimento = 0.25;

    public void RealizarInvestimento(PerfilInvestimento perfilInvestimento, Conta conta)
    {
        var lucro = perfilInvestimento.Investir(conta.Saldo);
        var impostoASerRetido = lucro * _impostoSobreInvestimento;
        var lucroLiquido = lucro - impostoASerRetido;
        var novoSaldo = conta.Saldo + lucroLiquido;
        
        Console.WriteLine($"Seu saldo era de: R${conta.Saldo}");
        Console.WriteLine($"Perfil de Investidor: [{perfilInvestimento.GetType().Name}]");
        Console.WriteLine($"Lucro bruto: R${lucro}");
        Console.WriteLine($"Lucro Liq: R${lucroLiquido}");
        Console.WriteLine($"Impostos retidos: R${impostoASerRetido}");

        conta.AtualizarSaldo(novoSaldo);
        Console.WriteLine($"Novo Saldo: R${conta.Saldo}");
    }
}