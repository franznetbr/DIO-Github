using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
                var indiceAluno =0;
              string opcaoUsuario = ObterOpcaoUsuario();
            
                while (opcaoUsuario.ToUpper() != "X")
                {
                    switch (opcaoUsuario)
                    {
                        case "1":

                            Console.WriteLine("Informe o nome do alunos");
                            var aluno = new Aluno();
                            aluno.Nome = Console.ReadLine();

                            Console.WriteLine("Informe a nota do alunos");
                            
                            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                                 
                                 {
                                 aluno.Nota = nota;
                                 }
                                 else
                                 {
                                      throw new ArgumentException("a nota deve ser decimal");
                                 }
                                 alunos[indiceAluno] = aluno;
                                    indiceAluno++;

                            //TODO: adicionar aluno
                            break;
                        case "2":
                            foreach(var a in alunos )
                            Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                           
                            break;
                        case "3":
                            decimal notaTotal = 0;
                            var nrAlunos = 0;

                            for (int i=0; i < alunos.Length; i++)
                            {
                                if (!string.IsNullOrEmpty(alunos[i].Nome))
                                {
                                    notaTotal = notaTotal + alunos[i].Nota;
                                    nrAlunos++;
                                }
                            }

                            var mediaGeral = notaTotal / nrAlunos;
                            Console.WriteLine($"MÉDIA GERAL: {mediaGeral}");
                        break;                
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
           
                     opcaoUsuario = ObterOpcaoUsuario();
                }
             }

            private static string ObterOpcaoUsuario()
            {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Lista alunos");
            Console.WriteLine("3- Caucular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;                
         }
    }
}
