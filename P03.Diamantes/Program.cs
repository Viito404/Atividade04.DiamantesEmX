namespace P03.Diamantes
{
     internal class Program
     {                
          static void Main(string[] args)
          {
               DiamanteX diamante1 = new DiamanteX();

               do
               {
                    diamante1.opcao = diamante1.GerarMenu();
                    diamante1.Opcao = diamante1.opcao;
                    diamante1.numero = diamante1.PegarNumero("Entre com um valor ímpar:\n> ");                 
                    diamante1.ConstruirDiamante();

               } while (true);
          }
     }
}