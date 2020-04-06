using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3POO
{
    public class GestorSuper
    {
        //Lista de productos
        public List<Producto> productoslB = new List<Producto> { };
        public List<Producto> productossB = new List<Producto> { };
        //Lista de clientes
        public List<Persona> clientesB = new List<Persona> { };
        //Lista de empleados
        public List<Persona> cajerosB = new List<Persona> { };
        //Lista de jefes
        public List<Persona> jefesB = new List<Persona> { };
        //Lista de auxiliares
        public List<Persona> auxiliaresB = new List<Persona> { };
        //Lista de nombres
        public List<string> nombresB = new List<string> { };
        //Lista de apellidos
        public List<string> apellidosB = new List<string> { };
        //Lista Auxiliares
        public List<Persona> Supervisores = new List<Persona> { };
        //Lista compras hechas
        public List<Producto> compras1 = new List<Producto> { };
        //Lista precio total
        public List<int> preciototal1 = new List<int> { };

        public List<Producto> compras2 = new List<Producto> { };
        //Lista precio total
        public List<int> preciototal2= new List<int> { };

        public List<Producto> compras3 = new List<Producto> { };
        //Lista precio total
        public List<int> preciototal3 = new List<int> { };

        public List<Producto> compras4 = new List<Producto> { };
        //Lista precio total
        public List<int> preciototal4 = new List<int> { };

        public List<Producto> compras5 = new List<Producto> { };
        //Lista precio total
        public List<int> preciototal5 = new List<int> { };










        int preciototalcompra1;
        int preciototalcompra2;
        int preciototalcompra3;
        int preciototalcompra4;
        int preciototalcompra5;
        int preciototal;


        //Constructor vacio
        public GestorSuper()
        {

        }
        //Agrega la compra a la bolsa
        public void Compras1(Producto productoc)
        {
            compras1.Add(productoc);
            preciototal1.Add(productoc.Precio);
        }
        public void Compras2(Producto productoc)
        {
            compras2.Add(productoc);
            preciototal2.Add(productoc.Precio);
        }
        public void Compras3(Producto productoc)
        {
            compras3.Add(productoc);
            preciototal3.Add(productoc.Precio);
        }
        public void Compras4(Producto productoc)
        {
            compras4.Add(productoc);
            preciototal4.Add(productoc.Precio);
        }
        public void Compras5(Producto productoc)
        {
            compras5.Add(productoc);
            preciototal5.Add(productoc.Precio);
        }




        //Agrega persona a cliente
        public void AgregaCliente(Persona persona)
        {
            clientesB.Add(persona);
        }
        public void AgregaSupervisor(Persona persona)
        {
            Supervisores.Add(persona);
        }
        //Agrega persona a empleado
        public void AgregaCajero(Persona persona)
        {
            cajerosB.Add(persona);
        }
        //Agrega persona a jefes
        public void AgregaJefe(Persona persona)
        {
            jefesB.Add(persona);
        }
        //Agrega persona a auxiliares
        public void AgregaAuxiliar(Persona persona)
        {
            auxiliaresB.Add(persona);
        }
        //Agrega producto
        public void AgregaProductol(Producto producto)
        {
            productoslB.Add(producto);
        }
        public void AgregaProductos(Producto producto)
        {
            productossB.Add(producto);
        }




        //Defino nombre
        public string DN()
        {
            var random = new Random();
            int index = random.Next(nombresB.Count);
            return nombresB[index];
        }
        public string DA()
        {
            var random = new Random();
            int index = random.Next(apellidosB.Count);
            return apellidosB[index];
        }





        public void InfoCompras1()
        {
            preciototalcompra1 = 0;
            foreach (Producto product1 in compras1)
            {
                Console.WriteLine(product1.InformacionP());
                preciototalcompra1 += product1.Precio;
            }
            Console.WriteLine("Precio Total: "+preciototalcompra1);
        }
        public void InfoCompras2()
        {
            preciototalcompra2 = 0;
            foreach (Producto product2 in compras2)
            {
                Console.WriteLine(product2.InformacionP());
                preciototalcompra2 += product2.Precio;
            }
            Console.WriteLine("Precio Total: " + preciototalcompra2);
        }
        public void InfoCompras3()
        {
            preciototalcompra3 = 0;
      
            foreach (Producto product3 in compras3)
            {
                Console.WriteLine(product3.InformacionP());
                preciototalcompra3 += product3.Precio;
            }
            Console.WriteLine("Precio Total: " + preciototalcompra3);
        }
        public void InfoCompras4()
        {
            preciototalcompra4 = 0;
            foreach (Producto product4 in compras4)
            {
                Console.WriteLine(product4.InformacionP());
                preciototalcompra4 += product4.Precio;
            }
            Console.WriteLine("Precio Total: " + preciototalcompra4);
        }
        public void InfoCompras5()
        {
            preciototalcompra5 = 0;
            foreach (Producto product5 in compras5)
            {
                Console.WriteLine(product5.InformacionP());
                preciototalcompra5 += product5.Precio;
            }
            Console.WriteLine("Precio Total: " + preciototalcompra5);
        }
        public void CompratotalPrecio()
        {
            preciototal = preciototalcompra1 + preciototalcompra2 + preciototalcompra3 + preciototalcompra4 + preciototalcompra5;
            Console.WriteLine(preciototal);
        }


        //Metodos que entrega a todas las personas de sus respectivas listas
        public void InfoJ()
        {
            Console.WriteLine("Mostrando Jefes:");
            foreach (Persona ij in jefesB)
            {
                Console.WriteLine(ij.InformacionT());
            }
            Console.WriteLine(" ");
        }
        public void InfoE()
        {
            Console.WriteLine("Mostrando Cajeros:");
            foreach (Persona ie in cajerosB)
            {
                Console.WriteLine(ie.InformacionT());
            }
            Console.WriteLine(" ");
        }
        public void InfoA()
        {
            Console.WriteLine("Mostrando Auxiliares");
            foreach (Persona ia in auxiliaresB)
            {
                Console.WriteLine(ia.InformacionT());
            }
            Console.WriteLine(" ");
        }
        public void InfoC()
        {
            Console.WriteLine("Mostrando Clientes:");
            foreach (Persona ic in clientesB)
            {
                Console.WriteLine(ic.InformacionT());
            }
            Console.WriteLine(" ");
        }
        //Metodo para ver Productos
        public void VerProductosl()
        {
            foreach (Producto ip in productoslB)
            {
                Console.WriteLine(ip.InformacionP());
            }
        }
        public void VerProductoss()
        {
            foreach (Producto ind in productossB)
            {
                Console.WriteLine(ind.InformacionP());
            }
        }





        public string EleccionCliente()
        {
            var random1 = new Random();
            int index1 = random1.Next(clientesB.Count);
            return clientesB[index1].Name+" "+clientesB[index1].Apellido;
        }
        public string EleccionCajero()
        {
            var random2 = new Random();
            int index1 = random2.Next(cajerosB.Count);
            return cajerosB[index1].Name + " " + cajerosB[index1].Apellido;
        }
    }
}
