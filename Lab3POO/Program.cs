using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3POO
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            string respuesta;//Menu
            string respuesta1;//Desea comprar?

            GestorSuper a = new GestorSuper();
            //Arreglar que si tiene cierto rol se agregue automaticamente a la lista

            //Jefe 1
            Persona Matias = new Persona("Matias", "202053068", "Rojas", "10/07/1999", "Chilena", "Jefe");
            a.AgregaJefe(Matias);
            Matias.AgregaSueldo();
            Matias.AgregaHorario();
            //Producto 1
            Producto Cafe = new Producto("Capuccino", 4000, "Starbucks", 20);
            a.AgregaProducto(Cafe);

            Console.WriteLine("Bienvenido a la página Web de SuperMercados20");
            while (true)
            {
                Console.WriteLine("Menú: Elija un valor numérico porfavor");
                Console.WriteLine(" ");
                Console.WriteLine("1) Ver trabajadores");
                Console.WriteLine("2) Ver productos");
                Console.WriteLine("3) Salir");
                respuesta = Console.ReadLine();
                if (respuesta == "1")
                {
                    a.InfoJ();
                    a.InfoE();
                    a.InfoA();
                    a.InfoC();
                }
                if (respuesta == "2")
                {
                    a.VerProductos();
                    while (true)
                    {
                        Console.WriteLine("¿Desea comprar alguno?");
                        respuesta1 = Console.ReadLine();
                        //if (respuesta1 == "Si")
                        //{
                        //Cual desea, mostrar precio, seguro?, if si {crear metodo: quitar stock}
                        //}
                        if (respuesta1 == "No")
                        {
                            break;
                        }
                    }
                }
                if (respuesta == "3")
                {
                    Console.WriteLine("Saliendo...");
                    break;
                }
            }
        }
    }
}
