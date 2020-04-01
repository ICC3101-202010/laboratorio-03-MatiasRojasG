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

        public string Name
        {
            get { return name; }
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


        public Producto(string nombrep, int preciop, string marcap, int stockp)
        {
            name = nombrep;
            precio = preciop;
            marca = marcap;
            stock = stockp;
        }
        public string InformacionP()
        {
            return "Nombre: " + Name + " " + "Marca :" + Marca + " " + "Precio: " + Precio + " " + "Stock: " + Stock;
        }
    }
}
