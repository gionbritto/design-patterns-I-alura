public class Conservador : PerfilInvestimento
{
    public double Investir(double saldoConta)
    {
        return saldoConta * 0.008;
    }
}