using System;
using System.Globalization;
using System.Security.Principal;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1}", produto1, preco1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("\n");
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine("\n");
            Console.WriteLine($"Media com oito casas decimais: {media.ToString("F8", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Arredondado (três casas decimais): {media.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Separador decimal invariant culture: {media.ToString("F3")}");
        
        }
    }
}
