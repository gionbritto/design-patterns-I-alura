public class SaldoMenorQue100 : FiltroContasDecorator
{
    public SaldoMenorQue100()
    {        
    }
    
    public SaldoMenorQue100(FiltroContasDecorator outroFiltroConta)
        : base(outroFiltroConta)
    {
    }

    protected override IList<Conta> Filtra(IList<Conta> contas) 
    { 
        IList<Conta> filtrada = new List<Conta>(); 
        foreach (Conta c in contas) 
        { 
            if (c.Saldo < 100) filtrada.Add(c); 
        } 
        
        foreach (Conta c in Proximo(contas)) 
        { 
            filtrada.Add(c); 
        } 
        
        return filtrada; 
    }
}
