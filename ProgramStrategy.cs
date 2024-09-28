// See https://aka.ms/new-console-template for more information
using DesignPatternsCSharp.Imposto;

//IMPOSTOS-------------------------------------------------------------------
// Console.WriteLine("==Solucao com Strategy Pattern - Impostos ==");

// var orcamento = new Orcamento(500);
// var calculadora = new CalculadorDeImposto();

// //supondo que a pessoa clicou em ICMS
// Imposto icms = new ICMS();
// Imposto iss = new ISS();

// calculadora.Calcular(icms, orcamento);
//---------------------------------------------------------------------------

//INVESTIMENTOS--------------------------------------------------------------
/*
Independente do lucro, a classe realizador de investimento deve retirar no final 25% de impostos
Preciso ter um Saldo, dentro de uma Conta;
Preciso ter várias estratégias de investimento
*/
//1: Criar conta
// var conta = new Conta(1000);

// PerfilInvestimento perfil = new Arrojado();
// var realizador = new RealizadorDeInvestimentos();
// realizador.RealizarInvestimento(perfil, conta);

//2: Realizar investimento

//passo 1: remover para uma classe calculadora
//calcular o imposto para ICMS e ISS
//digite o imposo a ser calculado [1] [2]

//classe pouco coeasa, motivos:
/* 
1 - dentro da mesma class estou: lendo informacoes, calculando imposto,
e conhecendo regras específicas para  cada impospo
*/


// Console.ReadKey();
