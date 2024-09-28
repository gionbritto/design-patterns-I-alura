public class CalculadorDeDesconto
{
    public double Calcula(Orcamento orcamento)
    {
        //A ideia é criar a cadeia de regras, atribuir e mandar rodar.
        var desconto1 = new CalculoDescontoMaisQueCincoItens();
        var desconto2 = new CalculoDescontoMaiorQueQuinhetosReais();
        var desconto3 = new DescontoPorVendaCasada();
        var semDesconto = new SemDesconto();

        desconto1.Proximo = desconto2;
        desconto2.Proximo = desconto3;
        desconto3.Proximo = semDesconto;

        return desconto1.Calcula(orcamento);
    }
}