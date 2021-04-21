/**
3/3 - Pink e Cérebro
 * 
 *
 * Desafio:
 * - Pink e Cérebro dividem um apartamento e estão juntos 
 * 24h por dia desde o começo da pandemia. Para passar o tempo, 
 * Pink cria problemas matemáticos para Cérebro resolver, o 
 * último deles foi uma lista de números com a seguinte pergunta: 
 * quantos números da lista são múltiplos de 2, 3, 4 e 5?
 * 
 * - Apesar de parecer simples, porém, quando a lista contém muitos 
 * números, Cérebro se confunde e acaba errando alguns cálculos.
 * 
 * - Ajude Cérebro a resolver o desadio de Pink.
 * 
 * Entrada:
 * - A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), 
 * representando a quantidade de números na lista de Pink.
 * 
 * - A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando 
 * os números da lista de Pink.
 * 
 * Saída:
 * - Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes 
 * na lista. Observe a formatação da saída nos exemplos, pois ela deve 
 * ser seguida rigorosamente.
 */
using System; 

class minhaClasse {

    static void Main(string[] args) { 

                int tv = int.Parse(Console.ReadLine());
      
        //declare suas variaveis aqui 
    string animado = Console.ReadLine();
    string[] desenho = animado.Split(' ');
    int div2 = 0;
    int div3 = 0;
    int div4 = 0;
    int div5 = 0;    

        //    string[] n = Console.ReadLine().Split();

      //continue a solução
    for ( int i = 0; i < tv; i++) {
      int n = int.Parse(desenho[i]);
    
      if (n % 2 == 0) {
        div2 += 1;
      }
    
      if(n % 3 == 0) {
        div3 += 1;
      }
    
      if (n % 4 == 0) {
        div4 += 1;
      }
    
      if(n % 5 == 0) {
        div5 += 1;
      }
    }
            Console.WriteLine("{0} Multiplo(s) de 2",  div2  );
            Console.WriteLine("{0} Multiplo(s) de 3",  div3  );
            Console.WriteLine("{0} Multiplo(s) de 4",  div4  );
            Console.WriteLine("{0} Multiplo(s) de 5",  div5  );
    
    }

}
***********************************************************************************