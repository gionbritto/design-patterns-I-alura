using DesignPatternsCSharp.Imposto;

public class ICPP : CalculoImpostoPadraoTemplateMethod
{
    // public double Calcular(Orcamento orcamento)
    // {
    //     if (orcamento.Valor > 500)
    //     {
    //         return orcamento.Valor * 0.07;
    //     }
    //     else
    //     {
    //         return orcamento.Valor * 0.05;
    //     }
    // }
    protected override double CalculoImpostoMaximo(Orcamento orcamento)
    {
        return orcamento.Valor * 0.07;
    }

    protected override double CalculoImpostoMinimo(Orcamento orcamento)
    {
        return orcamento.Valor * 0.05;
    }

    protected override bool DeveCalcularImpostoMaximo(Orcamento orcamento)
    {
        return orcamento.Valor > 500;
    }
}

public class IKCV : CalculoImpostoPadraoTemplateMethod
{
    // public double Calcular(Orcamento orcamento)
    // {        
    //     if (orcamento.Valor > 500 && ExisteItemSuperiorA100(orcamento.Itens))
    //     {
    //         return orcamento.Valor * 0.10;
    //     }
    //     else
    //     {
    //         return orcamento.Valor * 0.06;
    //     }
    // }

    protected override double CalculoImpostoMaximo(Orcamento orcamento)
    {
        return orcamento.Valor * 0.10;
    }

    protected override double CalculoImpostoMinimo(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }

    protected override bool DeveCalcularImpostoMaximo(Orcamento orcamento)
    {
        return orcamento.Valor > 500 && ExisteItemSuperiorA100(orcamento.Itens);
    }

    private bool ExisteItemSuperiorA100(List<ItemPedido> itens)
    {
        foreach (var item in itens)
        {
            if (item.Valor > 100)
            {
                return true;
            }
        }
        return false;
    }
}

public class IHIT : CalculoImpostoPadraoTemplateMethod
{
    protected override double CalculoImpostoMaximo(Orcamento orcamento)
    {
        return (orcamento.Valor * 0.13) + 100;
    }

    protected override double CalculoImpostoMinimo(Orcamento orcamento)
    {
        return orcamento.Valor * (orcamento.Itens.Count * 0.01);
    }

    protected override bool DeveCalcularImpostoMaximo(Orcamento orcamento)
    {
        return ExisteDoisItensComMesmoNome(orcamento);
    }

    private bool ExisteDoisItensComMesmoNome(Orcamento orcamento)
    {
        foreach(var item in orcamento.Itens){
            var qtdItens = orcamento.Itens.Where(i => i.Nome.Equals(item.Nome)).Count();
            if(qtdItens > 1){
                return true;
            }
        }

        return false;
    }
}

public abstract class CalculoImpostoPadraoTemplateMethod : Imposto
{
    public double Calcular(Orcamento orcamento)
    {
        if (DeveCalcularImpostoMaximo(orcamento))
        {
            return CalculoImpostoMaximo(orcamento);
        }
        else
        {
            return CalculoImpostoMinimo(orcamento);
        }
    }

    protected abstract double CalculoImpostoMinimo(Orcamento orcamento);

    protected abstract double CalculoImpostoMaximo(Orcamento orcamento);

    protected abstract bool DeveCalcularImpostoMaximo(Orcamento orcamento);
}