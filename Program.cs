using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__4__exc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double eleitores, brancos, nulos, validos;
            double porcentagem_brancos, porcentagem_nulos, porcentagem_validos;

            Console.WriteLine("Digite a quantidade de eleitores: ");
                eleitores = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos em branco: ");
                brancos = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos nulos: ");
                nulos = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos válidos: ");
                validos = double.Parse(Console.ReadLine());

            porcentagem_brancos = (brancos*100) / eleitores;
            porcentagem_nulos = (nulos * 100) / eleitores;
            porcentagem_validos = (validos * 100) / eleitores;

            Console.WriteLine("O percentual de votos em branco são: "+ porcentagem_brancos+"%");
            Console.WriteLine("O percentual de votos nulos são: "+ porcentagem_nulos+"%");
            Console.WriteLine("O percentual de votos válidos são: "+ porcentagem_validos+"%");
            Console.ReadKey();


        }   
    }
}
