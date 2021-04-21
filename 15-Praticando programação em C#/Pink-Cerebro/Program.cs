using System;

namespace Pink_Cerebro{
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
}
