/**
Aumento de Salário
 Desafio
    A empresa ABC resolveu conceder um aumento de salários a seus 
 funcionários de acordo com a tabela abaixo:
 Salário            |       Percentual de Reajuste
 0 - 400.00         |       15%
 400.01 - 800.00    |       12%
 800.01 - 1200.00   |       10%
 1200.01 - 2000.00  |       7%
 Acima de 2000.00   |       4%

    Leia o salário do funcionário e calcule e mostre o novo salário, 
 bem como o valor de reajuste ganho e o índice reajustado, em percentual.
 Entrada
    A entrada contém apenas um valor de ponto flutuante, que pode ser maior 
 ou igual a zero, com duas casas decimais.
 Saída
    Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o 
 percentual de reajuste ganho, conforme exemplo abaixo.
**/

using System; 
using System.Globalization;

class minhaClasse {

    static void Main(string[] args) { 

            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());
          
                       //insira os valores corretos de acordo com o enunciado

            if(salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15; 
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100.0) /salario;
            }
            else if (salario > 400.01 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100.0) / salario;
            }
            else if (salario > 800.01 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100.0) / salario;
            }
            else if (salario > 1200.01 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100.0) / salario;
            }
            else 
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
			          percentual = ((novoSalario - salario) * 100.0) / salario;
            }
			          
			          Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }

      }