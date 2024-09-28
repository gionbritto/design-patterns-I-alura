namespace DesignPatternsCSharp.Imposto;
public class ICMS : Imposto
{
    public double Calcular(Orcamento orcamento)
    {
        return (orcamento.Valor * 0.05) + 50;
    }
}