namespace DesignPatternsCSharp.Decorator;
public abstract class ImpostoDecorator
{
    //transformar em uma classe abstrata
    //ter uma possbilidade de ter outro imposto como propriedade e receber como construtor
    //Ter um metodo para calcular proximo retornando o double
    //Ter também um construtor default
    public ImpostoDecorator()
    {
        OutroImposto = null;
    }
    public ImpostoDecorator(ImpostoDecorator outroImposto)
    {
        OutroImposto = outroImposto;
    }

    protected ImpostoDecorator OutroImposto { get; set; }
    protected abstract double Calcular(Orcamento orcamento);
    protected double CalculoDoOutroImposto(Orcamento orcamento){
        if(orcamento == null ) return 0;

        return OutroImposto.Calcular(orcamento);
    }
}