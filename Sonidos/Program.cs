using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Canciones Lago_musical = new Canciones();
            Lago_musical.Obtener_sonido();
            Lago_musical.Mostrar_resto_del_sonido();
            Console.Read();
        }

    }
}

