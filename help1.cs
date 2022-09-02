using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.All2
{
    internal class help1
    {
        public void Start()
        {
            int descuentoTotal = 0;
            float precio_a_pagar = 0;
            Console.WriteLine("Cual es su Genero 'Hombre' o 'Mujer'");
            string genero = Console.ReadLine(); 
            Console.WriteLine("Cual especialidad elegira: ");
            Console.WriteLine("1. Cardiologia"); 
            Console.WriteLine("2. Oftalmologia"); 
            Console.WriteLine("3. Dermatologia");

            int especialidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Usted tiene mas de 3 hijos?: Si o No");
            string masDe3Hijos = Console.ReadLine();

            switch (genero)
            {
                case "Hombre":
                    switch (especialidad)
                    {
                        case 1:
                            descuentoTotal = 10;
                            break;
                        case 2:
                            descuentoTotal = 7;
                            break;
                        case 3:
                            descuentoTotal = 12;
                            break;
                    }
                    break;
                case "Mujer":
                    switch (especialidad)
                    {
                        case 1:
                            descuentoTotal = 15;
                            break;
                        case 2:
                            descuentoTotal = 10;
                            break;
                        case 3:
                            descuentoTotal = 5;
                            break;
                    }
                    break; 
            }
           


            Console.WriteLine("Monto total a pagar: ");
            precio_a_pagar = Convert.ToSingle(Console.ReadLine());

            float descuento = (precio_a_pagar*descuentoTotal)/100;
            precio_a_pagar -= descuento;

            if (masDe3Hijos.Equals("Si") || masDe3Hijos.Equals("si"))
            {
                precio_a_pagar -= 5.0f;
            }

            Console.WriteLine("Monto con descuentos: " + precio_a_pagar);

        }



    }
}
