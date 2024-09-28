
using DesignPatternsCSharp.Imposto;

public class CalculadorDeImposto
{
    public void Calcular(Imposto imposto, Orcamento orcamento)
    {
        //REsponsabilidade desta class:
        //Receber o imposto e o valor e "apresentá-lo na tela
        /*
        Anotações: Esta classe é responsável (pelo seu nome) em calcular
        impostos (fazer chamadas para as regras), mas ela não é responsável por definir
        quem vai ser o imposto.
        "A classe calcular não tem que conhecer quais são os impostos" pois
        ao conhecer, caso haja modificação ou inclusão, ela precisará ser editada.

        Dependa da interface e não da classe concreta.
        Se a regra de impostos mudar (ficar mais complexa e precisar de mais parametros),
        a ideia é que eu não precise mexer em "quem" calcula, e sim na estratégia de calculo
        ou seja, o responsável pelo calculo, que é:
        Ou quem está solicitando, 
        ou quem é o detentor da regra de calculo (que seria o If)
        */
        
        //Código
        var impostoCalculado = imposto.Calcular(orcamento);
        Console.WriteLine("Imposto a ser calculado[" + imposto.GetType().Name + "]");
        Console.WriteLine("Imposto calculado: " + impostoCalculado);
        //Código

        // if ("ICMS".Equals(imposto))
        // {
        //     //calcula icms
        //     new ICMS().Calcular(orcamento);
            
        // }
        // else if ("ISS".Equals(imposto))
        // {
        //     // calcula iss
            
        // }

        // return valorCalculado;
    }
}