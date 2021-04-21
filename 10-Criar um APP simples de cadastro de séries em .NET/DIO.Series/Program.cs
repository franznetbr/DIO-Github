using System;

namespace DIO.Series
{
    class Program
    {
        //Função "List" para armazenar os dados dos teste em memoria, pois não possui uma base de dados para armazenamento.
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
        //Bloco de opção do usuário ao entrar no menu do programa.
        string opcaoUsuario = ObterOpcaoUsuario();
        
        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                ListarSeries();
                break;
                case "2":
                InserirSerie();
                break;
                case "3":
                AtualizarSerie();
                break;
                case "4":
                ExcluirSerie();
                break;
                case "5":
                VisualizarSerie();
                break;
                case "C":
                Console.Clear();
                break;

                default:
                    throw new ArgumentOutOfRangeException();
            }  
            opcaoUsuario = ObterOpcaoUsuario();
        }

         Console.WriteLine("Obrigado por utilizar nossos serviços. ");
             Console.ReadLine();  
        }
        //Execução do bloco do Método ListarSeries, caso seja escolhido a opção 5 no menu. 
        //"Console.ReadLine" em todos os blocos, recebe a entrada do usuário.
           private static void ListarSeries()
            {
            Console.WriteLine("Listar séries");
            
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série cadastrada");
                return;
            }
            foreach (var serie in lista)
            {
            var excluido = serie.retornaExcluido();
               Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "Status: *Excluido*" : "Status *Ativo*")); 
            }
        }
         //Execução do bloco do Método Inseerir, caso seja escolhido a opção 2 no menu.        
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));

            }
            Console.Write("Digite o genero conforme opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

        //Istanciando a classe Conta para objeto "novaConta" efentuando uma conversão de entrada da classe TipoConta
        //para "entradaTipoConta" e entrada de dados no "enum" na conta correta da classe TipoConta.

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                        genero: (Genero)entradaGenero,
                        titulo: entradaTitulo,
                        ano: entradaAno,
                        descricao: entradaDescricao);

             repositorio.Insere(novaSerie);
        } 
            private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);

           }
           private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);

           }
            private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));

            }
            Console.Write("Digite o genero conforme opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

        //Istanciando a classe Conta para objeto "novaConta" efentuando uma conversão de entrada da classe TipoConta
        //para "entradaTipoConta" e entrada de dados no "enum" na conta correta da classe TipoConta.

            Serie atualizaSerie = new Serie(id: indiceSerie,
                        genero: (Genero)entradaGenero,
                        titulo: entradaTitulo,
                        ano: entradaAno,
                        descricao: entradaDescricao);

             repositorio.Atualiza(indiceSerie, atualizaSerie);
        } 


          //Menu - Execução do bloco do Método ObterOpcaoUsuario ao iniciar o programa. 
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            //Execução do bloco Método ObterOpcaoUsuario ao iniciar o programa, é chamada no Topo e retorna a opção do usuário. 
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
