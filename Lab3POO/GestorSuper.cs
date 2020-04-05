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
        int numr;


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






        //Añado nombres a su lista
        public void AN()
        {
            nombresB.Add("Miguel");
            nombresB.Add("Arturo");
            nombresB.Add("Jorge");
            nombresB.Add("Armando");
            nombresB.Add("Luis");
            nombresB.Add("Adolfo");
            nombresB.Add("Eufemiano");
            nombresB.Add("Carlos");
            nombresB.Add("Alejandro");
            nombresB.Add("Gabriel");
            nombresB.Add("Mariana");
            nombresB.Add("Beatriz");
            nombresB.Add("Helen");
            nombresB.Add("Maria");
            nombresB.Add("Paola");
            nombresB.Add("Paulina");
            nombresB.Add("Luisa");
            nombresB.Add("Marta");
            nombresB.Add("Pilar");
            nombresB.Add("Trinidad");
            nombresB.Add("Juan");
            nombresB.Add("David");
        }
        //Añado apellidos a su lista
        public void AA()
        {
            apellidosB.Add("Pallares");
            apellidosB.Add("Cervero");
            apellidosB.Add("Parras");
            apellidosB.Add("Rius");
            apellidosB.Add("Funes");
            apellidosB.Add("Escrig");
            apellidosB.Add("Larraz");
            apellidosB.Add("Sendra");
            apellidosB.Add("Alamillo");
            apellidosB.Add("Lloveras");
            apellidosB.Add("Sotelo");
            apellidosB.Add("Pacheco");
            apellidosB.Add("Arias");
            apellidosB.Add("Garcia");
            apellidosB.Add("Mena");
            apellidosB.Add("Rouco");
            apellidosB.Add("Coleto");
            apellidosB.Add("Valderrama");
            apellidosB.Add("Soldevila");
            apellidosB.Add("Arnau");
            apellidosB.Add("Berenguer");
            apellidosB.Add("Zabala");
        }




        public void InfoCompras1()
        {
            foreach (Producto product in compras1)
            {
                Console.WriteLine(product.InformacionP());
                preciototalcompra1 += product.Precio;
            }
            Console.WriteLine("Precio Total: "+preciototalcompra1);
        }
        public void InfoCompras2()
        {
            foreach (Producto product in compras2)
            {
                Console.WriteLine(product.InformacionP());
                preciototalcompra2 += product.Precio;
            }
            Console.WriteLine("Precio Total: " + preciototalcompra2);
        }
        public void InfoCompras3()
        {
            foreach (Producto product in compras3)
            {
                Console.WriteLine(product.InformacionP());
                preciototalcompra3 += product.Precio;
            }
            Console.WriteLine("Precio Total: " + preciototalcompra3);
        }
        public void InfoCompras4()
        {
            foreach (Producto product in compras4)
            {
                Console.WriteLine(product.InformacionP());
                preciototalcompra4 += product.Precio;
            }
            Console.WriteLine("Precio Total: " + preciototalcompra4);
        }
        public void InfoCompras5()
        {
            foreach (Producto product in compras5)
            {
                Console.WriteLine(product.InformacionP());
                preciototalcompra5 += product.Precio;
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
                Console.WriteLine(ij.Informacion());
            }
            Console.WriteLine(" ");
        }
        public void InfoE()
        {
            Console.WriteLine("Mostrando Cajeros:");
            foreach (Persona ie in cajerosB)
            {
                Console.WriteLine(ie.Informacion());
            }
            Console.WriteLine(" ");
        }
        public void InfoA()
        {
            Console.WriteLine("Mostrando Auxiliares");
            foreach (Persona ia in auxiliaresB)
            {
                Console.WriteLine(ia.Informacion());
            }
            Console.WriteLine(" ");
        }
        public void InfoC()
        {
            Console.WriteLine("Mostrando Clientes:");
            foreach (Persona ic in clientesB)
            {
                Console.WriteLine(ic.Informacion());
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
        public void Compra(Persona cliente, Producto producto)
        {
            //Cliente Compra
            //Resta producto de la lista
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
