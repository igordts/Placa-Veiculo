using System;

namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo ();
            v1.SetPlaca("ABC-1234");
            v1.SetCombustivel(255);
            Console.WriteLine("Placa V1: " + v1.GetPlaca());
            Console.WriteLine("Combustível dessa merda V1: " + v1.GetCombustivel());

            Veiculo v2 = new Veiculo();
            v2.SetPlaca("BCT-069");
            v2.SetCombustivel(999);
            Console.WriteLine("Placa V2: " + v2.GetPlaca());
            Console.WriteLine("Combustível dessa merda V2: " + v2.GetCombustivel());

            Veiculo v3 = new Veiculo();
            v3.SetPlaca("XXT-0022");
            v3.SetCombustivel(999);
            Console.WriteLine("Placa V3: " + v3.GetPlaca());
            Console.WriteLine("Combustível dessa merda V3: " + v3.GetCombustivel());
        }
    }
}
