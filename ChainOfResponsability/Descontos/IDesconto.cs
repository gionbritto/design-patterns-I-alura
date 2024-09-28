public interface IDesconto
{
    public IDesconto Proximo { get; set; }
    double Calcula(Orcamento orcamento);
}