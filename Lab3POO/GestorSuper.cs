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
        //Array de productos
        public List<Producto> productos = new List<Producto> { };
        //Lista de clientes
        public List<Persona> clientes = new List<Persona> { };
        //Lista de empleados
        public List<Persona> empleados = new List<Persona> { };
        //Lista de jefes
        public List<Persona> jefes = new List<Persona> { };
        //Lista de auxiliares
        public List<Persona> auxiliares = new List<Persona> { };

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
        public void AgregaEmpleado(Persona persona)
        {
            empleados.Add(persona);
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
        public void AgregaProducto(Producto producto)
        {
            productos.Add(producto);
        }





        //Metodos que entrega a todas las personas de sus respectivas listas
        public void InfoJ()
        {
            Console.WriteLine("Mostrando Jefes:");
            foreach (Persona ij in jefes)
            {
                Console.WriteLine(ij.Informacion());
            }
        }
        public void InfoE()
        {
            Console.WriteLine("Mostrando Empleados:");
            foreach (Persona ie in empleados)
            {
                Console.WriteLine(ie.Informacion());
            }
        }
        public void InfoA()
        {
            Console.WriteLine("Mostrando Auxiliares");
            foreach (Persona ia in auxiliares)
            {
                Console.WriteLine(ia.Informacion());
            }
        }
        public void InfoC()
        {
            Console.WriteLine("Mostrando Clientes:");
            foreach (Persona ic in clientes)
            {
                Console.WriteLine(ic.Informacion());
            }
        }
        //Metodo para ver Productos
        public void VerProductos()
        {
            foreach (Producto ip in productos)
            {
                Console.WriteLine(ip.InformacionP());
            }
        }

    }
}
