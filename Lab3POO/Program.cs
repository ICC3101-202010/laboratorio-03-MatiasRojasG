﻿using System;
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
            //Agrego nombres a lista
            a.AN();
            //Agrego apellidos a lista
            a.AA();
            //Agrego Productos
            //a.AP();
            //Defino Empleados:

            //Defino Jefe
            Persona Jefe1 = new Persona(a.DN(), a.DA(),"203948576", "Jefe", "10/07/1999", "Chilena"); ;
            a.AgregaJefe(Jefe1);
            //Defino Auxiliar
            Persona Auxiliar1 = new Persona(a.DN(), a.DA(), "193874978", "Auxiliar", "12/12/1992", "Chilena");
            Persona Auxiliar2 = new Persona(a.DN(), a.DA(), "154869872", "Auxiliar", "8/09/1989", "Venezolana");
            a.AgregaAuxiliar(Auxiliar1);
            a.AgregaAuxiliar(Auxiliar2);
            //Defino Empleados
            Persona Empleado1 = new Persona(a.DN(), a.DA(), "174958378", "Cajero", "14/04/1998", "Chilena");
            a.AgregaCajero(Empleado1);
            Persona Empleado2 = new Persona(a.DN(), a.DA(), "174487378", "Cajero", "17/03/1995", "Argentina");
            a.AgregaCajero(Empleado2);
            Persona Empleado3 = new Persona(a.DN(), a.DA(), "184736498", "Cajero", "9/09/1988", "Alemana");
            a.AgregaCajero(Empleado3);
            //Defino Supervisor
            Persona Supervisor1 = new Persona(a.DN(), a.DA(), "154958988", "Cajero", "14/04/1979", "Venezolana");
            a.AgregaCajero(Supervisor1);


            //Defino Clientes
            Persona Cliente1 = new Persona(a.DN(), a.DA(), "185689327", "Cliente", "12/05/1984", "Chilena");
            a.AgregaCliente(Cliente1);
            Persona Cliente2 = new Persona(a.DN(), a.DA(), "159869327", "Cliente", "12/09/1994", "Chilena");
            a.AgregaCliente(Cliente2);
            Persona Cliente3 = new Persona(a.DN(), a.DA(), "137989334", "Cliente", "10/05/1979", "Chilena");
            a.AgregaCliente(Cliente3);
            Persona Cliente4 = new Persona(a.DN(), a.DA(), "127698872", "Cliente", "10/08/1994", "Chilena");
            a.AgregaCliente(Cliente4);
            Persona Cliente5 = new Persona(a.DN(), a.DA(), "118779877", "Cliente", "2/05/1964", "Chilena");
            a.AgregaCliente(Cliente5);
            Persona Cliente6 = new Persona(a.DN(), a.DA(), "122289327", "Cliente", "11/05/1984", "Argentina");
            a.AgregaCliente(Cliente6);
            Persona Cliente7 = new Persona(a.DN(), a.DA(), "124739827", "Cliente", "10/05/1984", "Argentina");
            a.AgregaCliente(Cliente7);
            Persona Cliente8 = new Persona(a.DN(), a.DA(), "133569328", "Cliente", "11/05/1990", "Venezolana");
            a.AgregaCliente(Cliente8);
            Persona Cliente9 = new Persona(a.DN(), a.DA(), "133289322", "Cliente", "11/01/1994", "Estado Unidense");
            a.AgregaCliente(Cliente9);
            Persona Cliente10 = new Persona(a.DN(), a.DA(), "199887327", "Cliente", "29/05/1979", "Estado Unidense");
            a.AgregaCliente(Cliente10);
            Persona Cliente11 = new Persona(a.DN(), a.DA(), "213775647", "Cliente", "28/11/2002", "Española");
            a.AgregaCliente(Cliente11);
            Persona Cliente12 = new Persona(a.DN(), a.DA(), "218769872", "Cliente", "4/11/2002", "Española");
            a.AgregaCliente(Cliente12);
            Persona Cliente13 = new Persona(a.DN(), a.DA(), "203748327", "Cliente", "20/03/1999", "Francesa");
            a.AgregaCliente(Cliente13);
            Persona Cliente14 = new Persona(a.DN(), a.DA(), "204056079", "Cliente", "17/06/1999", "Alemana");
            a.AgregaCliente(Cliente14);
            Persona Cliente15 = new Persona(a.DN(), a.DA(), "222289327", "Cliente", "11/05/2005", "Alemana");
            a.AgregaCliente(Cliente15);

            //Producto 1
            Producto Cafe = new Producto("Capuccino", 4000, "Starbucks", 20);
            a.AgregaProducto(Cafe);







            //Web Super

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
