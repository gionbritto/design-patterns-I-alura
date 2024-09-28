namespace DesignPatternsCSharp.Imposto;
public class ICCC : Imposto
{
    public double Calcular(Orcamento orcamento)
    {
        if(orcamento.Valor > 3000){
            return (orcamento.Valor * 0.08) + 30;
        }

        if(orcamento.Valor >= 1000 && orcamento.Valor <= 3000){
            return orcamento.Valor * 0.07;
        }

        return orcamento.Valor * 0.05;
    }
}