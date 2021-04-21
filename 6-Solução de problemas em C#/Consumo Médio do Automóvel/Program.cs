using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int distancia;
            double combustivelGasto, consumoMedio;

            Console.WriteLine("Digite a distancia","\n");
            Console.WriteLine("\n");            
            distancia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o combustivel gasto","\n");
            Console.WriteLine("\n"); 
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = (distancia / combustivelGasto); //atribua a formula para que o codigo funcione corretamente
           
            if(consumoMedio >0) {
            Console.WriteLine("{0:0.000} km/l", consumoMedio);
            } else 
            
            {
            throw new ArgumentException("combustivel gasto não pode ser 0");
            }
    }

}