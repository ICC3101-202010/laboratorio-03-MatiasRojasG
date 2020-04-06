using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3POO
{
    public class Persona
    {
        //Atributos Generales
        private string name;
        private string rut;
        private string apellido;
        private string fechanac;
        private string nacionalidad;
        //Atributos personales
        private string rol;
        private int sueldo;
        private string horario;

        //Metodos para devolver private
        public string Name
        {
            get { return name; }
        }
        public string RUT
        {
            get { return rut; }
        }
        public string Apellido
        {
            get { return apellido; }
        }
        public string FechaNac
        {
            get { return fechanac; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
        }
        public string Rol
        {
            get { return rol; }
        }
        public int Sueldo
        {
            get { return sueldo; }
        }
        public string Horario
        {
            get { return horario; }
        }

        //public Persona(string nombrE, string ruT, string apellidO, string fechanaC, string nacionalidaD, string roL)
        //{
        //    name = nombrE;
        //    rut = ruT;
        //    apellido = apellidO;
        //    fechanac = fechanaC;
        //    nacionalidad = nacionalidaD;
        //    rol = roL;
        //}
        public Persona(string namee, string apellidoo, string Rut, string ROL, string fechanacc, string nacionalidadd)
        {
            name = namee;
            apellido = apellidoo;
            rol = ROL;
            rut = Rut;
            fechanac = fechanacc;
            nacionalidad = nacionalidadd;
            if (Rol == "Jefe")
            {
            sueldo = 6000000;
            horario = "9:00am-6:00pm";
            }
            if (Rol == "Cajero")
            {
            sueldo = 1500000;
            horario = "9:00am-12:00pm, 1:30pm-9:30pm";
            }
            if (Rol == "Auxiliar")
            {
            sueldo = 800000;
            horario = "8:30am-12:00pm, 1:00pm-4:00pm, 5:00pm-9:30pm";
            }
            if (Rol == "Supervisor")
            {
            sueldo = 2500000;
            horario = "9:30am-9:00";
            }
            if (Rol=="Cliente")
            {
                sueldo = 0;
                horario = "No definido";
            }
        }



        //Metodo que muestra la info de la persona
        public string Informacion()
        {
            return "Nombre: " + Name + " " + Apellido;
        }
        public string InformacionT()
        {
            return "Nombre: " + Name + " " + Apellido+" "+"Rut: "+RUT+" "+" "+"Sueldo: "+Sueldo+" "+"Horario: "+Horario;
        }
    }
}