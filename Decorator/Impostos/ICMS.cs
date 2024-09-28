namespace DesignPatternsCSharp.Decorator;
public class ICMSDecorator : ImpostoDecorator
{
    public ICMSDecorator(ImpostoDecorator outroImposto)
    : base(outroImposto)
    {
    }
    protected override double Calcular(Orcamento orcamento)
    {
        return (orcamento.Valor * 0.05) + 50 + CalculoDoOutroImposto(orcamento);
    }
}