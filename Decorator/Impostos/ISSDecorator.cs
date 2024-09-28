namespace DesignPatternsCSharp.Decorator;

public class ISSDecorator : ImpostoDecorator
{
    public ISSDecorator(ImpostoDecorator outroImposto)
        : base(outroImposto)
    {        
    }

    protected override double Calcular(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
    }
}