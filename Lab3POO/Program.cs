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
            string respuesta;


            string NombreJefe;
            string ApellidoJefe;
            string RutJefe;
            string FNJefe;
            string NacJefe;

            string NombreCajero1;
            string ApellidoCajero1;
            string RutCajero1;
            string FNCajero1;
            string NacCajero1;

            string NombreProducto;
            string MarcaProducto;
            string StockProducto;
            string grsProducto;
            string PrecioProducto;
            string ltsProducto;

            string compra1;
            string compra2;
            string compra3;
            string compra4;
            string compra5;

            string cuantos1;
            string cuantos2;
            string cuantos3;
            string cuantos4;
            string cuantos5;

            string cuantos7;

            string cliente1;
            string cajero1;
            string cliente2;
            string cajero2;
            string cliente3;
            string cajero3;
            string cliente4;
            string cajero4;
            string cliente5;
            string cajero5;




            string respuestaprimera;//Interactivo o Bonus (Random)


            GestorSuper a = new GestorSuper();

            //Agrego nombres a lista
            a.AN();
            //Agrego apellidos a lista
            a.AA();
            //Agrego Productos

            //Defino Empleados:

            //Defino Jefe
            Console.WriteLine("1) Programa Principal");
            Console.WriteLine("2) Bonus");

            respuestaprimera = Console.ReadLine();
            if (respuestaprimera == "2")
            {


                Persona Jefe1 = new Persona(a.DN(), a.DA(), "203948576", "Jefe", "10/07/1999", "Chilena"); ;
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

                //Productos liquidos
                Producto Cafe1 = new Producto("Capuccino", 4000, "Starbucks", 20, 0.4, "l");
                a.AgregaProductol(Cafe1);
                Producto Cafe2 = new Producto("Mocha", 4000, "Starbucks", 20, 0.4, "l");
                a.AgregaProductol(Cafe2);
                Producto Leche2 = new Producto("Leche Natural SemiDescremada", 700, "Colun", 20, 1.0, "l");
                a.AgregaProductol(Leche2);

                Producto Bebida1 = new Producto("Pap", 1200, "Bilz y Pap", 20, 1.5, "l");
                a.AgregaProductol(Bebida1);
                Producto Bebida2 = new Producto("Bilz", 1200, "Bilz y Pap", 20, 1.5, "l");
                a.AgregaProductol(Bebida2);
                Producto Bebida3 = new Producto("Coca-Cola", 1200, "Coca-Cola", 20, 2.0, "l");
                a.AgregaProductol(Bebida3);

                Producto Leche1 = new Producto("Leche Natural Entera", 1200, "Colun", 20, 1.0, "l");
                a.AgregaProductol(Leche1);

                Producto Agua1 = new Producto("Benedictino", 800, "Coca-Cola", 20, 0.8, "l");
                a.AgregaProductol(Agua1);
                Producto Agua2 = new Producto("Cachantun", 820, "Coca-Cola", 20, 0.8, "l");
                a.AgregaProductol(Agua2);
                Producto Jugo1 = new Producto("Naranja", 800, "Watts", 20, 0.8, "l");
                a.AgregaProductol(Jugo1);

                //Productos Solidos
                Producto Almuerzo1 = new Producto("Arroz con Pollo", 3200, "SM20", 20, 0.4, "s");
                a.AgregaProductos(Almuerzo1);
                Producto Almuerzo2 = new Producto("Pollo con papas fritas", 3000, "SM20", 20, 0.4, "s");
                a.AgregaProductos(Almuerzo2);
                Producto Almuerzo3 = new Producto("Tallarines con carne", 3000, "SM20", 20, 0.4, "s");
                a.AgregaProductos(Almuerzo3);

                Producto Sandwich1 = new Producto("Sandwich Ave Mayo", 1200, "SM20", 20, 0.2, "s");
                a.AgregaProductos(Sandwich1);
                Producto Sandwich2 = new Producto("Barros Luco", 1200, "SM20", 20, 0.2, "s");
                a.AgregaProductos(Sandwich2);

                Producto Mantequilla1 = new Producto("Mantequilla", 1000, "Colun", 20, 0.2, "s");
                a.AgregaProductos(Mantequilla1);
                Producto Mantequilla2 = new Producto("Mantequilla", 1200, "Soprole", 20, 0.2, "s");
                a.AgregaProductos(Mantequilla2);

                Producto Pan1 = new Producto("Pan Marraqueta", 1000, "SM20", 20, 1.0, "s");
                a.AgregaProductos(Pan1);
                Producto Pan2 = new Producto("Pan de Molde", 820, "Bimbo", 20, 0.5, "s");
                a.AgregaProductos(Pan2);
                Producto Queso1 = new Producto("Queso Gouda", 800, "Colun", 20, 0.2, "s");
                a.AgregaProductos(Queso1);
            }













            if (respuestaprimera == "1")
            {
                //Web Super
                {
                    while (true)
                    {
                        Console.WriteLine("Menú: Elija un valor numérico porfavor");
                        Console.WriteLine(" ");
                        Console.WriteLine("1) COMENZAR Compra");
                        Console.WriteLine("2) Ver productos");
                        Console.WriteLine("3) Ver trabajadores");
                        Console.WriteLine("4) Salir");
                        respuesta = Console.ReadLine();
                        if (respuesta == "3")
                        {
                            a.InfoJ();
                            a.InfoE();
                            a.InfoA();
                            a.InfoC();
                        }
                        if (respuesta == "2")
                        {
                            Console.WriteLine("Productos Liquidos:");
                            a.VerProductosl();
                            Console.WriteLine(" ");
                            Console.WriteLine("Productos Solidos:");
                            a.VerProductoss();
                        }






                        if (respuesta == "1")
                        {
                            //Se crea al jefe
                            Console.WriteLine("Creacion Jefe");
                            Console.WriteLine("Ingrese Nombre del Jefe:");
                            NombreJefe = Console.ReadLine();
                            Console.WriteLine("Ingrese Apellido del Jefe:");
                            ApellidoJefe = Console.ReadLine();
                            Console.WriteLine("Ingrese RUT del Jefe:");
                            RutJefe = Console.ReadLine();
                            Console.WriteLine("Ingrese Fecha de Nacimiento del Jefe:");
                            FNJefe = Console.ReadLine();
                            Console.WriteLine("Ingrese Nacionalidad del Jefe:");
                            NacJefe = Console.ReadLine();
                            Persona Jefe = new Persona(NombreJefe, ApellidoJefe, RutJefe, "Jefe", FNJefe, NacJefe);
                            a.AgregaJefe(Jefe);

                            //Se crean cajeros
                            int i1;
                            Console.WriteLine("Creacion Cajeros (a lo menos 1)");
                            Console.WriteLine("¿Cuantos desea ingresar?");
                            cuantos1 = Console.ReadLine();
                            int intcuantos1 = System.Convert.ToInt32(cuantos1);
                            if (intcuantos1 == 0)
                            {
                                Console.WriteLine("Siguiente");
                            }
                            if (intcuantos1 > 0)
                            {
                                for (i1 = 1; i1 <= intcuantos1; i1++)
                                {
                                    Console.WriteLine("Ingrese Nombre del Cajero " + " " + i1);
                                    NombreCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellido del Cajero " + " " + i1);
                                    ApellidoCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese RUT del Cajero" + " " + i1);
                                    RutCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Fecha de Nacimiento del Cajero" + " " + i1);
                                    FNCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Nacionalidad del Cajero" + " " + i1);
                                    NacCajero1 = Console.ReadLine();
                                    Persona Cajero1 = new Persona(NombreCajero1, ApellidoCajero1, RutCajero1, "Cajero", FNCajero1, NacCajero1);
                                    a.AgregaCajero(Cajero1);
                                }
                            }
                            //Se crean a los auxiliares

                            int i2;
                            Console.WriteLine("Creacion Auxiliares");
                            Console.WriteLine("¿Cuantos desea ingresar?");
                            cuantos2 = Console.ReadLine();
                            int intcuantos2 = System.Convert.ToInt32(cuantos2);
                            if (intcuantos2 == 0)
                            {
                                Console.WriteLine("Siguiente");
                            }
                            if (intcuantos2 > 0)
                            {
                                for (i2 = 1; i2 <= intcuantos2; i2++)
                                {
                                    Console.WriteLine("Ingrese Nombre del Auxiliar" + " " + i2);
                                    NombreCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellido del Auxiliar" + " " + i2);
                                    ApellidoCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese RUT del Auxiliar" + " " + i2);
                                    RutCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Fecha de Nacimiento del Auxiliar" + " " + i2);
                                    FNCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Nacionalidad del Auxiliar" + " " + i2);
                                    NacCajero1 = Console.ReadLine();
                                    Persona Auxiliar1 = new Persona(NombreCajero1, ApellidoCajero1, RutCajero1, "Auxiliar", FNCajero1, NacCajero1);
                                    a.AgregaAuxiliar(Auxiliar1);
                                }
                            }

                            //Se crea el supervisor
                            int i3;
                            Console.WriteLine("Creacion Supervisor");
                            Console.WriteLine("¿Cuantos desea ingresar?");
                            cuantos3 = Console.ReadLine();
                            int intcuantos3 = System.Convert.ToInt32(cuantos3);
                            if (intcuantos3 == 0)
                            {
                                Console.WriteLine("Siguiente");
                            }
                            if (intcuantos3 > 0)
                            {
                                for (i3 = 1; i3 <= intcuantos3; i3++)
                                {
                                    Console.WriteLine("Ingrese Nombre del Supervisor" + " " + i3);
                                    NombreCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellido del Supervisor" + " " + i3);
                                    ApellidoCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese RUT del Supervisor" + " " + i3);
                                    RutCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Fecha de Nacimiento del Supervisor" + " " + i3);
                                    FNCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Nacionalidad del Supervisor" + " " + i3);
                                    NacCajero1 = Console.ReadLine();
                                    Persona Auxiliar1 = new Persona(NombreCajero1, ApellidoCajero1, RutCajero1, "Supervisor", FNCajero1, NacCajero1);
                                    a.AgregaSupervisor(Auxiliar1);
                                }
                            }
                            //Se crean a los clientes
                            int i7;
                            Console.WriteLine("Creacion Clientes (a lo menos 1)");
                            Console.WriteLine("¿Cuantos desea ingresar?");
                            cuantos7 = Console.ReadLine();
                            int intcuantos7 = System.Convert.ToInt32(cuantos7);
                            if (intcuantos7 == 0)
                            {
                                Console.WriteLine("Siguiente");
                            }
                            if (intcuantos7 > 0)
                            {
                                for (i7 = 1; i7 <= intcuantos7; i7++)
                                {
                                    Console.WriteLine("Ingrese Nombre del Cliente" + " " + i7);
                                    NombreCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellido del Cliente" + " " + i7);
                                    ApellidoCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese RUT del Cliente" + " " + i7);
                                    RutCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Fecha de Nacimiento del Cliente" + " " + i7);
                                    FNCajero1 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Nacionalidad del Cliente" + " " + i7);
                                    NacCajero1 = Console.ReadLine();
                                    Persona Cliente = new Persona(NombreCajero1, ApellidoCajero1, RutCajero1, "Cliente", FNCajero1, NacCajero1);
                                    a.AgregaCliente(Cliente);
                                }
                            }


                            //Se crean los productos liquidos
                            int i4;
                            Console.WriteLine("Creacion Productos Liquidos");
                            Console.WriteLine("¿Cuantos desea ingresar?");
                            cuantos4 = Console.ReadLine();
                            int intcuantos4 = System.Convert.ToInt32(cuantos4);
                            if (intcuantos4 == 0)
                            {
                                Console.WriteLine("Siguiente");
                            }
                            if (intcuantos4 > 0)
                            {
                                for (i4 = 1; i4 <= intcuantos4; i4++)
                                {
                                    Console.WriteLine("Ingrese Nombre del Producto" + " " + i4);
                                    NombreProducto = Console.ReadLine();
                                    Console.WriteLine("Ingrese Marca del Producto" + " " + i4);
                                    MarcaProducto = Console.ReadLine();
                                    Console.WriteLine("Ingrese el Precio del Producto" + " " + i4);
                                    PrecioProducto = Console.ReadLine();
                                    int intPrecioProducto = System.Convert.ToInt32(PrecioProducto);
                                    Console.WriteLine("Ingrese Stock del Producto" + " " + i4);
                                    StockProducto = Console.ReadLine();
                                    int intStockProducto = System.Convert.ToInt32(StockProducto);
                                    Console.WriteLine("Ingrese Litros");
                                    ltsProducto = Console.ReadLine();
                                    double dblts = System.Convert.ToDouble(ltsProducto);
                                    Producto Liquido1 = new Producto(NombreProducto, intPrecioProducto, MarcaProducto, intStockProducto, dblts, "l");
                                    a.AgregaProductol(Liquido1);
                                }
                            }
                            //Se crean los productos solidos
                            int i5;
                            Console.WriteLine("Creacion Productos Solidos");
                            Console.WriteLine("¿Cuantos desea ingresar?");
                            cuantos5 = Console.ReadLine();
                            int intcuantos5 = System.Convert.ToInt32(cuantos5);
                            if (intcuantos5 == 0)
                            {
                                Console.WriteLine("Siguiente");
                            }
                            if (intcuantos5 > 0)
                            {
                                for (i5 = 1; i5 <= intcuantos5; i5++)
                                {
                                    Console.WriteLine("Ingrese Nombre del Producto" + " " + i5);
                                    NombreProducto = Console.ReadLine();
                                    Console.WriteLine("Ingrese Marca del Producto" + " " + i5);
                                    MarcaProducto = Console.ReadLine();
                                    Console.WriteLine("Ingrese el Precio del Producto" + " " + i5);
                                    PrecioProducto = Console.ReadLine();
                                    int intPrecioProducto = System.Convert.ToInt32(PrecioProducto);
                                    Console.WriteLine("Ingrese Stock" + " " + i5);
                                    StockProducto = Console.ReadLine();
                                    int intStockProducto = System.Convert.ToInt32(StockProducto);
                                    Console.WriteLine("Ingrese Gramos");
                                    grsProducto = Console.ReadLine();
                                    double dbgrsProducto = System.Convert.ToDouble(grsProducto);
                                    Producto Solido1 = new Producto(NombreProducto, intPrecioProducto, MarcaProducto, intStockProducto, dbgrsProducto, "s");
                                    a.AgregaProductos(Solido1);
                                }
                            }






                            //Comienza la compra

                            Console.WriteLine(" ");
                            Console.WriteLine("Compra numero 1");
                            cliente1 = a.EleccionCliente();
                            cajero1 = a.EleccionCajero();
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Buenos dias" + " " + cliente1);
                            Console.WriteLine(" ");
                            Console.WriteLine("Usted esta siendo atendido por" + " " + cajero1);
                            Console.WriteLine(" ");
                            while (true)
                            {
                                Console.WriteLine("¿Que tipo de producto desea comprar?");
                                compra1 = Console.ReadLine();
                                {
                                    if (compra1 == "Liquido")
                                    {
                                        a.VerProductosl();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto l1 in a.productoslB)
                                            {
                                                if (l1.Name == compra2)
                                                {
                                                    l1.CompraProducto();
                                                    l1.InformacionP();
                                                    a.Compras1(l1);
                                                }
                                                else
                                                {
                                                    break;
                                                }

                                            }
                                            break;
                                        }
                                    }
                                    if (compra1 == "Solido")
                                    {
                                        a.VerProductoss();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto s1 in a.productossB)
                                            {
                                                if (s1.Name == compra2)
                                                {
                                                    s1.CompraProducto();
                                                    s1.InformacionP();
                                                    a.Compras1(s1);
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }

                                    if (compra1 == "Nada mas")
                                    {
                                        Console.WriteLine(cajero1 + ": Gracias por su compra" + " " + "Sr/Sra" + " " + cliente1);
                                        Console.WriteLine("Usted lleva:");
                                        a.InfoCompras1();
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Compra numero 2");
                            cliente2 = a.EleccionCliente();
                            cajero2 = a.EleccionCajero();
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Buenos dias" + " " + cliente2);
                            Console.WriteLine(" ");
                            Console.WriteLine("Usted esta siendo atendido por" + " " + cajero2);
                            Console.WriteLine(" ");
                            while (true)
                            {
                                Console.WriteLine("¿Que tipo de producto desea comprar?");
                                compra1 = Console.ReadLine();
                                {
                                    if (compra1 == "Liquido")
                                    {
                                        a.VerProductosl();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto l1 in a.productoslB)
                                            {
                                                if (l1.Name == compra2)
                                                {
                                                    l1.CompraProducto();
                                                    l1.InformacionP();
                                                    a.Compras2(l1);
                                                }
                                                else
                                                {
                                                    break;
                                                }

                                            }
                                            break;
                                        }
                                    }
                                    if (compra1 == "Solido")
                                    {
                                        a.VerProductoss();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto s1 in a.productossB)
                                            {
                                                if (s1.Name == compra2)
                                                {
                                                    s1.CompraProducto();
                                                    s1.InformacionP();
                                                    a.Compras2(s1);
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }

                                    if (compra1 == "Nada mas")
                                    {
                                        Console.WriteLine(cajero2 + ": Gracias por su compra" + " " + "Sr/Sra" + " " + cliente2);
                                        Console.WriteLine("Usted lleva:");
                                        a.InfoCompras2();
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Compra numero 3");
                            cliente3 = a.EleccionCliente();
                            cajero3 = a.EleccionCajero();
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Buenos dias" + " " + cliente3);
                            Console.WriteLine(" ");
                            Console.WriteLine("Usted esta siendo atendido por" + " " + cajero3);
                            Console.WriteLine(" ");
                            while (true)
                            {
                                Console.WriteLine("¿Que tipo de producto desea comprar?");
                                compra1 = Console.ReadLine();
                                {
                                    if (compra1 == "Liquido")
                                    {
                                        a.VerProductosl();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto l1 in a.productoslB)
                                            {
                                                if (l1.Name == compra2)
                                                {
                                                    l1.CompraProducto();
                                                    l1.InformacionP();
                                                    a.Compras3(l1);
                                                }
                                                else
                                                {
                                                    break;
                                                }

                                            }
                                            break;
                                        }
                                    }
                                    if (compra1 == "Solido")
                                    {
                                        a.VerProductoss();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto s1 in a.productossB)
                                            {
                                                if (s1.Name == compra2)
                                                {
                                                    s1.CompraProducto();
                                                    s1.InformacionP();
                                                    a.Compras3(s1);
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }

                                    if (compra1 == "Nada mas")
                                    {
                                        Console.WriteLine(cajero3 + ": Gracias por su compra" + " " + "Sr/Sra" + " " + cliente3);
                                        Console.WriteLine("Usted lleva:");
                                        a.InfoCompras3();
                                        break;
                                    }
                                }
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Compra numero 4");
                            cliente4 = a.EleccionCliente();
                            cajero4 = a.EleccionCajero();
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Buenos dias" + " " + cliente4);
                            Console.WriteLine(" ");
                            Console.WriteLine("Usted esta siendo atendido por" + " " + cajero4);
                            Console.WriteLine(" ");
                            while (true)
                            {
                                Console.WriteLine("¿Que tipo de producto desea comprar?");
                                compra1 = Console.ReadLine();
                                {
                                    if (compra1 == "Liquido")
                                    {
                                        a.VerProductosl();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto l1 in a.productoslB)
                                            {
                                                if (l1.Name == compra2)
                                                {
                                                    l1.CompraProducto();
                                                    l1.InformacionP();
                                                    a.Compras4(l1);
                                                }
                                                else
                                                {
                                                    break;
                                                }

                                            }
                                            break;
                                        }
                                    }
                                    if (compra1 == "Solido")
                                    {
                                        a.VerProductoss();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto s1 in a.productossB)
                                            {
                                                if (s1.Name == compra2)
                                                {
                                                    s1.CompraProducto();
                                                    s1.InformacionP();
                                                    a.Compras4(s1);
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }

                                    if (compra1 == "Nada mas")
                                    {
                                        Console.WriteLine(cajero4 + ": Gracias por su compra" + " " + "Sr/Sra" + " " + cliente4);
                                        Console.WriteLine("Usted lleva:");
                                        a.InfoCompras4();
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Compra numero 5");
                            cliente5 = a.EleccionCliente();
                            cajero5 = a.EleccionCajero();
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Buenos dias" + " " + cliente5);
                            Console.WriteLine(" ");
                            Console.WriteLine("Usted esta siendo atendido por" + " " + cajero5);
                            Console.WriteLine(" ");
                            while (true)
                            {
                                Console.WriteLine("¿Que tipo de producto desea comprar?");
                                compra1 = Console.ReadLine();
                                {
                                    if (compra1 == "Liquido")
                                    {
                                        a.VerProductosl();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto l1 in a.productoslB)
                                            {
                                                if (l1.Name == compra2)
                                                {
                                                    l1.CompraProducto();
                                                    l1.InformacionP();
                                                    a.Compras5(l1);
                                                }
                                                else
                                                {
                                                    break;
                                                }

                                            }
                                            break;
                                        }
                                    }
                                    if (compra1 == "Solido")
                                    {
                                        a.VerProductoss();
                                        while (true)
                                        {
                                            Console.WriteLine("¿Cual desea?");
                                            compra2 = Console.ReadLine();
                                            foreach (Producto s1 in a.productossB)
                                            {
                                                if (s1.Name == compra2)
                                                {
                                                    s1.CompraProducto();
                                                    s1.InformacionP();
                                                    a.Compras5(s1);
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }

                                    if (compra1 == "Nada mas")
                                    {
                                        Console.WriteLine(cajero5 + ": Gracias por su compra" + " " + "Sr/Sra" + " " + cliente5);
                                        Console.WriteLine("Usted lleva:");
                                        a.InfoCompras5();
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("El dia de hoy se vendio:");
                            a.CompratotalPrecio();
                            Console.WriteLine(cajero1 + " vendio:");
                            a.InfoCompras1();
                            Console.WriteLine(cajero2 + " vendio:");
                            a.InfoCompras2();
                            Console.WriteLine(cajero3 + " vendio:");
                            a.InfoCompras3();
                            Console.WriteLine(cajero4 + " vendio:");
                            a.InfoCompras4();
                            Console.WriteLine(cajero5 + " vendio:");
                            a.InfoCompras5();
                        }


                        if (respuesta == "4")
                        {
                            Console.WriteLine("Saliendo...");
                            break;
                        }
                    }
                }
            }
        }
    }
}
