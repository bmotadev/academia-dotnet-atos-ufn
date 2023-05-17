using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula14Poo
{
    internal class Motocicleta : Veiculo
    {
        public override void Ligar()
        {
            Console.WriteLine("Moto ligada");
        }
    }
}
