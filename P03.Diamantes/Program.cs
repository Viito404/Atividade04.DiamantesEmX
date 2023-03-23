namespace P03.Diamantes
{
     internal class Program
     {
          static int numero;

          static string GerarMenu()
          {
               Console.Clear();
               Console.WriteLine("===============================");
               Console.WriteLine("\nDiamantes em X\n");
               Console.WriteLine("===============================");

               Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");
               string opcao;
               opcao = Console.ReadLine().ToUpper();
               return opcao;
          }

          static void PegarNumero(string mensagem)
          {
               Console.Clear();
               Console.Write(mensagem);
               numero = Convert.ToInt32(Console.ReadLine());
               Console.ResetColor();

               while (numero % 2 == 0)
               {
                    Console.Clear();
                    Console.Write("Digite um número válido!\n\n");
                    Console.Write(mensagem);
                    numero = Convert.ToInt32(Console.ReadLine());
               }
          }

          static void ConstruirDiamante()
          {
               Console.ForegroundColor = ConsoleColor.Blue;
               for (int i = 0; i < numero; i++)
               {
                    int espaco = Math.Abs(numero / 2 - i);
                    int x = numero - 2 * espaco;

                    for (int p = 0; p < espaco; p++)
                    {
                         Console.Write(" ");
                    }
                    for (int p = 0; p < x; p++)
                    {
                         Console.Write("X");
                    }
                    Console.WriteLine();
               }
               Console.ReadLine();
               Console.ResetColor();
          }

          static void Main(string[] args)
          {
               do
               {
                    string opcao = GerarMenu();

                    if (opcao == "S")
                    {
                         Console.WriteLine("\nSaindo...");
                         break;
                    }

                    PegarNumero("Entre com um valor ímpar:\n> ");
                    Console.Write("\n\n");
                    ConstruirDiamante();

               } while (true);
          }
     }
}