public enum Formato 
{
    XML,
    CSV,
    PORCENTO
}
public class Requisicao
{
    public Requisicao(Formato formato)
    {
        Formato = formato;
    }
    public Formato Formato { get; private set; }
}