using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.All2
{
    internal class help2
    {
        public void Start()
        {
            Console.WriteLine("Adivinanzas correctas:");
            int adivinanzasCorrectas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Edad del ganador:");
            int edad = Convert.ToInt32(Console.ReadLine());

            int premio = 0;


            bool mayordeedad = edad > 18 ? true : false;
             
            if (adivinanzasCorrectas < 3)
            {
                if (mayordeedad)
                {
                    premio = 30;
                }
                else
                {
                    premio = 50;
                }
            }
            else
            {
                if (mayordeedad)
                {
                    premio = 50;
                }
                else
                {
                    premio = 80;
                }
            }


            premio += edad * 5;

            premio += adivinanzasCorrectas * 2;

            Console.WriteLine("El ganador recibio: " + premio);

        }



    }
}
