public class SaldoMaiorQue500Mil : FiltroContasDecorator {
    
    public SaldoMaiorQue500Mil()
    {        
    }
    
    public SaldoMaiorQue500Mil(FiltroContasDecorator outroFiltroConta)
        : base(outroFiltroConta)
    {
    }
      protected override IList<Conta> Filtra(IList<Conta> contas) 
    { 
        IList<Conta> filtrada = new List<Conta>(); 
        foreach (Conta c in contas) 
        { 
            if (c.Saldo > 500000) filtrada.Add(c); 
        } 
        
        foreach (Conta c in Proximo(contas)) 
        { 
            filtrada.Add(c); 
        } 
        
        return filtrada; 
    }
}
