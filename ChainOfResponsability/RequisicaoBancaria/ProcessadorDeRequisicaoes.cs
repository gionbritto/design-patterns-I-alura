public class ProcessadorDeRequisicaoes
{
    public void ProcessarRequisicao(Conta conta, Requisicao requisicao)
    {
        var p1 = new ProcessadorXml();
        var p2 = new ProcessadorCsv();
        var p3 = new ProcessadorPorcento();
        var processadorNaoDefinido = new ProcessadorNaoEncontrado();

        p1.Proximo = p2;
        p2.Proximo = p3;
        p3.Proximo = processadorNaoDefinido;

        var resultado = p1.Processar(conta, requisicao);

        Console.WriteLine(resultado);
    }
}


public class ProcessadorPorcento : IProcessaodor
{
    public ProcessadorPorcento()
    {
    }

    public IProcessaodor Proximo { get; set; }

    public string Processar(Conta conta, Requisicao requisicao)
    {
        if(requisicao.Formato.Equals(Formato.PORCENTO)){
            return "Imprimindo conta com dados PORCENTO: " +
            $"Titular: {conta.Saldo}";
        }

        return Proximo.Processar(conta, requisicao);
    }
}

public class ProcessadorCsv : IProcessaodor
{
    public ProcessadorCsv()
    {
    }

    public IProcessaodor Proximo { get; set; }

    public string Processar(Conta conta, Requisicao requisicao)
    {
        if(requisicao.Formato.Equals(Formato.CSV)){
            return "Imprimindo conta com dados CSV: " +
            $"Titular: {conta.Saldo}";
        }

        return Proximo.Processar(conta, requisicao);
    }
}

public class ProcessadorXml : IProcessaodor
{
    public ProcessadorXml()
    {
    }

    public IProcessaodor Proximo { get; set; }

    public string Processar(Conta conta, Requisicao requisicao)
    {
        if(requisicao.Formato.Equals(Formato.XML)){
            return "Imprimindo conta com dados XML: " +
            $"Titular: {conta.Saldo}";
        }

        return Proximo.Processar(conta, requisicao);
    }
}

public class ProcessadorNaoEncontrado : IProcessaodor
{
    public ProcessadorNaoEncontrado()
    {
    }

    public IProcessaodor Proximo { get; set; }

    public string Processar(Conta conta, Requisicao requisicao)
    {
        return "Formato não identificado";
    }
}


public interface IProcessaodor
{
    public IProcessaodor Proximo { get; set; }
    public string Processar(Conta conta, Requisicao requisicao);
}
//RESPOSTA DO INSTRUTOR:
// interface Resposta 
// {
//     void Responde(Requisicao req, Conta conta);
//     Resposta OutraResposta { get; set; }
// }

// class RespostaEmXml : Resposta 
// {
//     public Resposta OutraResposta { get; set; }

//     public void Responde(Requisicao req, Conta conta) 
//     {
//         if(req.Formato == Formato.XML) 
//         {
//             Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
//         }
//         else 
//         {
//             OutraResposta.Responde(req, conta);
//         }
//     }  
// }

// class RespostaEmCsv : Resposta 
// {
//     public Resposta OutraResposta { get; set; }

//     public void Responde(Requisicao req, Conta conta) 
//     {
//         if(req.Formato == Formato.CSV) 
//         {
//             Console.WriteLine(conta.Titular + ";" + conta.Saldo);
//         }
//         else 
//         {
//             OutraResposta.Responde(req, conta);
//         }
//     }
// }

// class RespostaEmPorcento : Resposta 
// {
//     private Resposta OutraResposta { get; set; }

//     public void Responde(Requisicao req, Conta conta) 
//     {
//         if(req.Formato == Formato.PORCENTO) 
//         {
//             Console.WriteLine(conta.Titular + "%" + conta.Saldo);
//         }
//         else 
//         {
//             OutraResposta.Responde(req, conta);
//         }
//     }
// }