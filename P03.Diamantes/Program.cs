namespace P03.Diamantes
{
     internal class Program
     {
          static void Main(string[] args)
          {
               do
               {
                    #region Menu e opção de sair;

                    int n;
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("\nDiamantes em X\n");
                    Console.WriteLine("===============================");

                    Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");

                    string op;
                    op = Console.ReadLine();

                    if (op == "s" || op == "S")
                    {
                         Console.WriteLine("\nSaindo...");
                         break;
                    }

                    #endregion 

                    #region Verificação de números ímpares;

                    Console.Clear();
                    Console.Write("Digite um número ímpar:\n> ");
                    n = Convert.ToInt32(Console.ReadLine());

                    while (n % 2 == 0)
                    {
                         Console.Clear();
                         Console.Write("Digite um número válido!\n");
                         Console.Write("\nDigite um número ímpar:\n> ");
                         n = Convert.ToInt32(Console.ReadLine());
                    }

                    #endregion

                    #region Impressão de espaços e x paralelamente;

                    Console.Write("\n\n");
                    for (int i = 0; i < n; i++)
                    {
                         int es = Math.Abs(n / 2 - i);
                         int x = n - 2 * es;

                         for (int p = 0; p < es; p++)
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

                    #endregion

               } while (true);
          }
     }
}