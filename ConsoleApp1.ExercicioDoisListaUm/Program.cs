using System;

namespace ConsoleApp1.ExercicioDoisListaUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Padaria Hotpão");
            Console.WriteLine("Pães e Broas mais baratos da cidade");
            Console.WriteLine("");
            while (true)
             {
                
                const decimal PrecoDoPao = 0.12m;     // const double PrecoDoPao = 0.12m; 
                const decimal PrecoDaBroa = 1.50m;    // const double PrecoDaBroa = 1.50m; 

                decimal valorPaes, valorBroas, total = 0.0m;
                decimal poupanca;

                Console.Write("Digite a quantidade de pães vendidos (R$ 0,12)? ");
                int paesVendidos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de broas vendidas (R$ 1,50)? ");
                int broasVendidas = Convert.ToInt32(Console.ReadLine());

                valorPaes = paesVendidos * PrecoDoPao;
                valorBroas = broasVendidas * PrecoDaBroa;

                total = valorPaes + valorBroas;
                poupanca = total * 0.1m;

                Console.Write("O total apurado foi: R$" + total);
                Console.Write("O que vai para a poupança: R$" + poupanca);

                Console.ReadKey();

            }while(true);
        }
    }
}
