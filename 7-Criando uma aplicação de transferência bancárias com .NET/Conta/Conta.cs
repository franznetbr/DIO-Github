using System;

namespace DIO.bank
{
    public class Conta
    {
        //Atributos privados da classe conta.
        private TipoConta TipoConta {get; set; }
        private string Nome {get; set; }
        private double Saldo {get; set; }
        private double Credito {get; set; }

    //Construtor da classe Conta contendo 4 parâmetros. 
    public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
            this.TipoConta = tipoConta;
                this.Saldo = saldo;
                this.Credito = credito;
                this.Nome = nome;               
        }
    //Método Sacar, se saldo menos a solicitação do saque for menor que o negativo de crédito, saldo insuficiente.
    //Retorna falso, caso contrário continua o processo de saque.
    public bool Sacar(double valorSaque)
    {
        if (this.Saldo - valorSaque < (this.Credito *-1))
        {
                Console.WriteLine("Saldo insuficiente!");
                return false;
        }
        this.Saldo -= valorSaque;
        //Exibe as referência de Nome e Saldo de acordo com a descrição da string {0} e {1}.
        Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        return true;
    }
    public void Depositar(double valorDeposito)
    {
        this.Saldo += valorDeposito;
         Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);    
    }
    
    //Método Transferir está reutilizando o método "Sacar" para validar o saldo de transferência.
    //pois no método "Sacar" já existe uma validação de saldo e depósito não possui validação.
    public void Transferir(double valorTransferencia, Conta contaDestino)
    {
    if (this.Sacar(valorTransferencia)){
            contaDestino.Depositar(valorTransferencia);
            }
        }
    //Sobrescrevendo o método ToString com override da classe principal para retornar como string.
    //Método ToString() também é bastante utilizado para gravar logs da aplicação.
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
             retorno += "Nome " + this.Nome + " | ";
              retorno += "Saldo " + this.Saldo + " | ";
               retorno += "Crédito " + this.Credito + " | ";
                return retorno;
        }
    }
}
