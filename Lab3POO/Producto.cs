using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3POO
{
    public class Producto
    {
        private string name;
        private int precio;
        private string marca;
        private int stock;
        private double lts;
        private string comp;

        public string Name
        {
            get { return name; }
        }
        public string Comp
        {
            get { return comp; }
        }
        public double Lts
        {
            get { return lts; }
        }

        public int Precio
        {
            get { return precio; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public int Stock
        {
            get { return stock; }
        }

        public Producto(string nombrep, int preciop, string marcap, int stockp, double ltsp, string l)
        {
            name = nombrep;
            precio = preciop;
            marca = marcap;
            stock = stockp;
            lts = ltsp;
            comp = l;
        }
        //Resta 1 al stock luego de la compra
        public int CompraProducto()
        {
            return stock -= 1;
        }


        public string InformacionP()
        {
            if (comp=="l")
            {
                return "Nombre: " + Name + " " + "Marca :" + Marca + " " + "Precio: " + Precio + " " + "Lts: " + Lts + " " + "Stock: " + Stock;
            }
            else
            {
                return "Nombre: " + Name + " " + "Marca :" + Marca + " " + "Precio: " + Precio + " " + "Gramos: " + Lts + " " + "Stock: " + Stock;
            }
            
        }
    }
}
