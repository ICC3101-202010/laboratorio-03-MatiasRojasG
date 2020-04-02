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
        public List<Producto> productosl = new List<Producto> { };
        public List<Producto> productoss = new List<Producto> { };
        //Lista de clientes
        public List<Persona> clientes = new List<Persona> { };
        //Lista de empleados
        public List<Persona> cajeros = new List<Persona> { };
        //Lista de jefes
        public List<Persona> jefes = new List<Persona> { };
        //Lista de auxiliares
        public List<Persona> auxiliares = new List<Persona> { };
        //Lista de nombres
        public List<string> nombres = new List<string> { };
        //Lista de apellidos
        public List<string> apellidos = new List<string> { };




        //Constructor vacio
        public GestorSuper()
        {

        }
        //Agrega persona a cliente
        public void AgregaCliente(Persona persona)
        {
            clientes.Add(persona);
        }
        //Agrega persona a empleado
        public void AgregaCajero(Persona persona)
        {
            cajeros.Add(persona);
        }
        //Agrega persona a jefes
        public void AgregaJefe(Persona persona)
        {
            jefes.Add(persona);
        }
        //Agrega persona a auxiliares
        public void AgregaAuxiliar(Persona persona)
        {
            auxiliares.Add(persona);
        }
        //Agrega producto
        public void AgregaProductol(Producto producto)
        {
            productosl.Add(producto);
        }
        public void AgregaProductos(Producto producto)
        {
            productoss.Add(producto);
        }




        //Defino nombre
        public string DN()
        {
            var random = new Random();
            int index = random.Next(nombres.Count);
            return nombres[index];
        }
        public string DA()
        {
            var random = new Random();
            int index = random.Next(apellidos.Count);
            return apellidos[index];
        }






        //Añado nombres a su lista
        public void AN()
        {
            nombres.Add("Miguel");
            nombres.Add("Arturo");
            nombres.Add("Jorge");
            nombres.Add("Armando");
            nombres.Add("Luis");
            nombres.Add("Adolfo");
            nombres.Add("Eufemiano");
            nombres.Add("Carlos");
            nombres.Add("Alejandro");
            nombres.Add("Gabriel");
            nombres.Add("Mariana");
            nombres.Add("Beatriz");
            nombres.Add("Helen");
            nombres.Add("Maria");
            nombres.Add("Paola");
            nombres.Add("Paulina");
            nombres.Add("Luisa");
            nombres.Add("Marta");
            nombres.Add("Pilar");
            nombres.Add("Trinidad");
            nombres.Add("Juan");
            nombres.Add("David");
        }
        //Añado apellidos a su lista
        public void AA()
        {
            apellidos.Add("Pallares");
            apellidos.Add("Cervero");
            apellidos.Add("Parras");
            apellidos.Add("Rius");
            apellidos.Add("Funes");
            apellidos.Add("Escrig");
            apellidos.Add("Larraz");
            apellidos.Add("Sendra");
            apellidos.Add("Alamillo");
            apellidos.Add("Lloveras");
            apellidos.Add("Sotelo");
            apellidos.Add("Pacheco");
            apellidos.Add("Arias");
            apellidos.Add("Garcia");
            apellidos.Add("Mena");
            apellidos.Add("Rouco");
            apellidos.Add("Coleto");
            apellidos.Add("Valderrama");
            apellidos.Add("Soldevila");
            apellidos.Add("Arnau");
            apellidos.Add("Berenguer");
            apellidos.Add("Zabala");
        }








        //Metodos que entrega a todas las personas de sus respectivas listas
        public void InfoJ()
        {
            Console.WriteLine("Mostrando Jefes:");
            foreach (Persona ij in jefes)
            {
                Console.WriteLine(ij.Informacion());
            }
            Console.WriteLine(" ");
        }
        public void InfoE()
        {
            Console.WriteLine("Mostrando Empleados:");
            foreach (Persona ie in cajeros)
            {
                Console.WriteLine(ie.Informacion());
            }
            Console.WriteLine(" ");
        }
        public void InfoA()
        {
            Console.WriteLine("Mostrando Auxiliares");
            foreach (Persona ia in auxiliares)
            {
                Console.WriteLine(ia.Informacion());
            }
            Console.WriteLine(" ");
        }
        public void InfoC()
        {
            Console.WriteLine("Mostrando Clientes:");
            foreach (Persona ic in clientes)
            {
                Console.WriteLine(ic.Informacion());
            }
            Console.WriteLine(" ");
        }
        //Metodo para ver Productos
        public void VerProductosl()
        {
            foreach (Producto ip in productosl)
            {
                Console.WriteLine(ip.InformacionP());
            }
        }
        public void VerProductoss()
        {
            foreach (Producto ind in productoss)
            {
                Console.WriteLine(ind.InformacionP());
            }
        }
        public void Compra(Persona cliente, Producto producto)
        {
            //Cliente Compra
            //Resta producto de la lista
        }

    }
}
