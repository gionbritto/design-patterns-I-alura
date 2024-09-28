
using DesignPatternsCSharp.Imposto;

public class CalculadorDeImpostoTemplateMethod
{
    public void Calcular(Imposto imposto, Orcamento orcamento)
    {
        
        //Código
        var impostoCalculado = imposto.Calcular(orcamento);
        Console.WriteLine("Imposto a ser calculado[" + imposto.GetType().Name + "]");
        Console.WriteLine("Imposto calculado: " + impostoCalculado);
    }
}