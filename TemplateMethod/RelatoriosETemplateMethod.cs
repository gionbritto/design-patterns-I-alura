public interface IRelatorio
{
    public void ExibirRelatorio(List<Conta> contas);
}

public abstract class RelatorioTemplate : IRelatorio
{
    public void ExibirRelatorio(List<Conta> contas)
    {
        ImprimirCabecalho();
        ImprimirCorpo(contas);
        ImprimirRodape();
    }

    protected abstract void ImprimirRodape();
    protected abstract void ImprimirCorpo(List<Conta> contas);
    protected abstract void ImprimirCabecalho();
}

public class RelatorioSimples : RelatorioTemplate
{
    protected override void ImprimirCabecalho()
    {
        System.Console.WriteLine("=========SIMPLES: CABEÇALHO - BANCO DO JOJO=========");

    }

    protected override void ImprimirCorpo(List<Conta> contas)
    {
        foreach (var conta in contas)
        {
            System.Console.WriteLine($"Titular: {conta.Titular} - Saldo: {conta.Saldo}");
        }
    }

    protected override void ImprimirRodape()
    {
        System.Console.WriteLine("------------------------31 97281721278----------------------------");
    }
}

public class RelatorioComplexo : RelatorioTemplate
{
    protected override void ImprimirCabecalho()
    {
        System.Console.WriteLine("=========COMPLEXO: CABEÇALHO - BANCO DO JOJO -  31 97281721278=========");
        System.Console.WriteLine("=========RUA ERCILIA ROCHA 123=========");
    }

    protected override void ImprimirCorpo(List<Conta> contas)
    {
        foreach (var conta in contas)
        {
            System.Console.WriteLine($"-----------");
            System.Console.WriteLine($"Titular: {conta.Titular} - Saldo: {conta.Saldo}");
            System.Console.WriteLine($"Agencia: {conta.Agencia} - Numero Conta: {conta.NumeroConta}");
            System.Console.WriteLine($"-----------");
        }
    }

    protected override void ImprimirRodape()
    {
        System.Console.WriteLine("--------------------------------------------------------------");
        System.Console.WriteLine("EMAIL: teste@teste.com - 27/09/2024");
        System.Console.WriteLine("--------------------------------------------------------------");
    }
}