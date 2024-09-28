// //TEMPLATE METHOD
// //RELATORIO CONTAS----------------------------------------------
// //contas
// using System.Runtime.CompilerServices;

// var conta1 = new Conta(1000, "Giovanne", "0001", "2304892");
// var conta2 = new Conta(3443.10, "Giselle", "0003", "876456");
// var conta3 = new Conta(546030.02, "Thayná", "123", "8764567");
// var conta4 = new Conta(867950.40, "Maria", "652", "2347456");
// var listaContas = new List<Conta> { conta1, conta2, conta3, conta4 };
// //relatório simples
// // var relatorio1 = new RelatorioSimples();
// // var relatorio2 = new RelatorioComplexo();

// var listaRelatorios = BuildDelegateList();
// foreach (var rel in listaRelatorios)
// {
//     rel.Invoke(listaContas);
// }


// Action<List<Conta>>[] BuildDelegateList()
// {
//     return
//     [
//         new RelatorioSimples().ExibirRelatorio,
//         new RelatorioComplexo().ExibirRelatorio,
//     ];
// }











// //CALCULADOR DE IMPOSTOS----------------------------------------------
// // using DesignPatternsCSharp.Imposto;

// // var calculador = new CalculadorDeImpostoTemplateMethod();
// // var orcamento = new Orcamento(500);
// // //teste ICPP
// // System.Console.WriteLine("Teste ICPP:");
// // var icpp = new ICPP();
// // calculador.Calcular(icpp, orcamento);

// // //teste ICKV
// // System.Console.WriteLine("Teste ICKV:");
// // var ikcv = new IKCV();
// // calculador.Calcular(ikcv, orcamento);

// //teste 1
// // Teste ICPP:
// // Imposto a ser calculado[ICPP]
// // Imposto calculado: 25
// // Teste ICKV:
// // Calculando: IKCV
// // Imposto a ser calculado[IKCV]
// // Imposto calculado: 30