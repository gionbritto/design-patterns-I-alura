public abstract class FiltroContasDecorator
{

    public FiltroContasDecorator()
    {
        OutroFiltro = null;
    }

    public FiltroContasDecorator(FiltroContasDecorator outroFiltro)
    {
        OutroFiltro = outroFiltro;
    }

    public FiltroContasDecorator OutroFiltro { get; set; }
    protected abstract IList<Conta> Filtra(IList<Conta> contas);

    protected IList<Conta> Proximo(IList<Conta> contas){
        return OutroFiltro.Filtra(contas);
    }
}