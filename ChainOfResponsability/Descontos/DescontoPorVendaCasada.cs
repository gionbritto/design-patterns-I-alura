public class DescontoPorVendaCasada : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Calcula(Orcamento orcamento)
    {


        if (AconteceuVendaCasadaEm(orcamento))
        {
            return orcamento.Valor * 0.05;
        }

        return Proximo.Calcula(orcamento);
    }

    private bool AconteceuVendaCasadaEm(Orcamento orcamento){
        return Existe("LAPIS", orcamento) && Existe("CANETA", orcamento);
    }

    private static bool Existe(string nomeItem, Orcamento orcamento)
    {
        foreach (var item in orcamento.Itens)
        {
            if (item.Nome.Equals(nomeItem))
                return true;
        }

        return false;
    }
}