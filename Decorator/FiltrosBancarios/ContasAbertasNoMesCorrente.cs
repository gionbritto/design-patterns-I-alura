public class ContasAbertasNoMesCorrente : FiltroContasDecorator
{


    public ContasAbertasNoMesCorrente()
    {
    }

    public ContasAbertasNoMesCorrente(FiltroContasDecorator outroFiltroConta)
        : base(outroFiltroConta)
    {
    }
    
    protected override IList<Conta> Filtra(IList<Conta> contas)
    {
        IList<Conta> filtrada = new List<Conta>();
        foreach (Conta c in contas)
        {
            if (c.DataAbertura.Month == DateTime.Now.Month) filtrada.Add(c);
        }

        foreach (Conta c in Proximo(contas))
        {
            filtrada.Add(c);
        }

        return filtrada;
    }
}
