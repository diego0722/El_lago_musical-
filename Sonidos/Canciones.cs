using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonidos
{
    class Canciones
    {
        //0->Canción 1, 1->Canción 2, 2->Canción 3
        string[] Canciones_animales = { "brr, fiu, cric-cric, brrah", "pep, birip, trri-trri, croac", "bri-bri, plop, cric-cric, brrah" };

        string Sonido;

        string Cancion;

        public Canciones()
        {
            Sonido = "";
            Cancion = "";
        }

        public void Obtener_sonido()
        {
            do
            {

            } while (!Ingresar_sonido());
        }

        public void Mostrar_resto_del_sonido()
        {
            Console.Write(Resto_del_sonido());
        }

        private bool Ingresar_sonido()
        {
            Console.Write("Ingrese el sonido: ");
            Sonido = Console.ReadLine();
            return Existe_el_sonido();
        }

        private bool Existe_el_sonido()
        {
            for (int c = 0; c < Canciones_animales.Length; c++)
            {
                if ((", " + Canciones_animales[c] + ",").Contains(", " + Sonido + ","))
                {
                    Cancion = Canciones_animales[c];
                    return true;
                }

            }
            return false;
        }

        private string Resto_del_sonido()
        {
            int Desde = Cancion.IndexOf(Sonido) + (Sonido.Length) + 1;
            if (Cancion.Length - Desde > 0)
                return Cancion.Substring(Desde, Cancion.Length - Desde).Trim();
            else
                return "";
        }

    }
}
