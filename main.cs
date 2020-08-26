using System;

/*2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final*/

class EX02Class {

  public static void Main (string[] args) {
    Console.WriteLine("-------------------------------");
    Console.WriteLine("100  Cachorro quente   R$ 1,70 ");
    Console.WriteLine("101  Bauru Simples     R$ 2,30 ");
    Console.WriteLine("102  Bauru com ovo     R$ 2,60 ");
    Console.WriteLine("103  Hamburguer        R$ 2,40 ");
    Console.WriteLine("104  Cheeseburguer     R$ 2,50 ");
    Console.WriteLine("105  Refrigerenate     R$ 1,00 ");
    Console.WriteLine("-------------------------------");

    int codigo;
    int qntd; 

    Console.Write("Digite o codigo do produto: ");
    codigo = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade: ");
    qntd = int.Parse(Console.ReadLine());

    double vlrTotal = Valor(codigo,qntd);
    Console.Write("Valor da sua compra é : R${0}",vlrTotal);

  }

  public static double Valor(int codigo, int qntd){
    double total=0;

    if(codigo == 100){
      total = 1.70 * qntd;
    }else if(codigo == 101){
      total = 2.30 * qntd;
    }else if(codigo == 102){
      total = 2.60 * qntd;
    }else if(codigo == 103){
      total = 2.40 * qntd;
    }else if(codigo == 104){
      total = 2.50 * qntd;
    }else if(codigo == 105){
      total = 1.00 * qntd;
    }else{
      Console.Write("Codigo invalido!! ");
    }

    return total;
  }


}