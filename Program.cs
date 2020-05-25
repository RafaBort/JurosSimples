using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o capital...");
            string capital = Console.ReadLine();

            Console.WriteLine("Digite taxa dos juros...");
            string taxa = Console.ReadLine();

            Console.WriteLine("Digite o tempo...");
            string tempo = Console.ReadLine();

            Double capital1 = Convert.ToDouble(capital);
            Double taxa1 = Convert.ToDouble(taxa);
            Double tempo1 = Convert.ToDouble(tempo);

            Double juros = capital1 * taxa1 * tempo1;
            Double montante = capital1 + juros;

            Console.WriteLine("juros:... " + juros);
            Console.WriteLine("montante: " + montante);

        }
    }
}
