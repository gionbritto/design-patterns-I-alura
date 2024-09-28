public class Conta
{
    public Conta(double saldo)
    {
        Saldo = saldo;
    }

    public Conta(double saldo, DateTime dataAbertura)
    {
        Saldo = saldo;
        DataAbertura = dataAbertura;
    }

    public Conta(double saldo, string titular, string agencia, string numeroConta)
    {
        Saldo = saldo;
        Titular = titular;
        Agencia = agencia;
        NumeroConta = numeroConta;
    }

    public double Saldo { get; private set; }
    public string Titular { get; private set; }
    public string Agencia { get; private set; }
    public string NumeroConta { get; private set; }
    public DateTime DataAbertura { get; private set; }

    public void AtualizarSaldo(double novoSaldo)
    {
        Saldo = novoSaldo;
    }
}