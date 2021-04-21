using System;
using System.Collections.Generic;

namespace DIO.bank
{
    //Prática .NET
    //Programa desenvolvido manualmente com instruções do professor Eliézer Zarpelão - apoio da - Digital Innovation one.
    class Program
    {
        //Função "List" para armazenar os dados dos testes em memória, pois não possui uma base de dados para armazenamento.
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
        //Bloco de opção do usuário ao entrar no menu do programa.
        string opcaoUsuario = ObterOpcaoUsuario();
        
        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                ListarContas();
                break;
                case "2":
                InserirConta();
                break;
                case "3":
                Transferir();
                break;
                case "4":
                Sacar();
                break;
                case "5":
                Depositar();
                break;
                case "C":
                Console.Clear();
                break;

                default:
                    throw new ArgumentOutOfRangeException();
            }  
            opcaoUsuario = ObterOpcaoUsuario();                      
            }   
             Console.Write("Obrigado por utilizar nossos serviços. ");
             Console.ReadLine();  
        }
        //Execução do bloco do Método depositar, caso seja escolhido a opção 5 no menu. 
        //"Console.ReadLine" em todos os blocos, recebe a entrada do usuário.
           private static void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado $: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }
        //Execução do bloco do Método Transferir, caso seja escolhido a opção 3 no menu.  
        private static void Transferir()
        {
            Console.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser trasferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }
        //Execução do bloco do Método Sacar, caso seja escolhido a opção 4 no menu. 
        private static void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado $: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
        }
        //Execução do bloco do Método Listar Contas. 
        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
        //For será executado se existir pelo menos uma conta, a conta que estiver na posição do vetor [i].
        //será exibida pelo método ToString ao chamar Console.WriteLine(conta), a posição do "i" será substituída em {0}.
            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }           
        } 
        //Execução do bloco do Método Inserir, caso seja escolhido a opção 2 no menu.        
        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para Conta Físoca ou 2 para Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());
        //Instanciando a classe Conta para objeto "novaConta" efetuando uma conversão de entrada da classe TipoConta
        //para "entradaTipoConta" e entrada de dados no "enum" na conta correta da classe TipoConta.
            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                        saldo: entradaSaldo,
                        credito: entradaCredito,
                        nome: entradaNome);

             listContas.Add(novaConta);
        } 
        //Menu - Execução do bloco do Método ObterOpcaoUsuario ao iniciar o programa. 
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferência");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            //Execução do bloco Método ObterOpcaoUsuario ao iniciar o programa, é chamada no Topo e retorna à opção do usuário. 
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
         
    }

       
    }
