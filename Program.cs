using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
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

            Console.WriteLine("Obrigado por Utilizar nossos serviços.");
            Console.WriteLine();
        }

        private static void ListarSeries()
        {
                Console.WriteLine("Listar séries");
                var lista = repositorio.Lista();

                if (lista.Count == 0)
                {
                    Console.WriteLine("Nenhuma série cadastrada no momento.");
                    return;
                }
                foreach (var serie in lista)                
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
                }
        }
        private static void InserirSerie()
        {
        Console.WriteLine("Inserir nova série no catalogo.");

        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
              Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
              Console.Write("Digite o gênero entre as opções acima: ");
              int entradaGenero = int.Parse(Console.ReadLine());

              Console.Write("Digite o Titulo da série: ");
              string entradaTitulo = Console.ReadLine();

              Console.Write("Digite ano de lançamento da série: ");
              int entradaAno = int.Parse(Console.ReadLine());

              Console.WriteLine("Digite a descrição da série: ");
              string entradaDescricao = Console.ReadLine();

              Serie novaSerie = new Serie(id: repositorio.NextId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);
              repositorio.Insert(novaSerie);
        }
        private static void AtualizarSerie()
        {
              Console.WriteLine("Digite o ID da série: ");
              int indiceSerie = int.Parse(Console.ReadLine());
                
              foreach (int i in Enum.GetValues(typeof(Genero)))
              {
                 Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
              }
                 Console.WriteLine("Digite o gênero entre as opções acima: ");
                 int entradaGenero = int.Parse(Console.ReadLine());

                 Console.WriteLine("Digite o Titulo da série: ");
                 string entradaTitulo = Console.ReadLine();

                 Console.WriteLine("Digite ano de lançamento da série: ");
                 int entradaAno = int.Parse(Console.ReadLine());

                 Console.WriteLine("Digite a descrição da série: ");
                 string entradaDescricao = Console.ReadLine();

                 Serie atualizaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);
                repositorio.Update(indiceSerie, atualizaSerie);
        }
        private static void ExcluirSerie()
        {
                Console.Write("Digite a Id da série para ser exluida: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                repositorio.DeletebyId(indiceSerie);
        }
        private static void VisualizarSerie()
        {
                Console.WriteLine("Digite o Id da série para visualização: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                var serie = repositorio.ReturnbyId(indiceSerie);
                Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario()
        {
                Console.WriteLine();
                Console.WriteLine("DIO Séries. Oque deseja assistir hoje?");
                Console.WriteLine("Informe a opção desejada: ");

                Console.WriteLine("1 - Listar séries"); 
                Console.WriteLine("2 - Inserir nova série");
                Console.WriteLine("3 - Atualizar série");
                Console.WriteLine("4 - Excluir série");
                Console.WriteLine("5 - Visualizar série");
                Console.WriteLine("C - Limpar tela");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
        }
               
    }
}