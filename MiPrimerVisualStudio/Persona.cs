using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerVisualStudio
{
    class Persona
    {
        //Set Get son los métodos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public string NombresCompletos { get; set; }

        //Procedimiento: Ejecuta sentencias
        public void AsignarNombresCompletos()
        {
            
            NombresCompletos = Nombre + " " + Apellido;
        }

        //Función: Retorna un valor
        public string DevolverNombresCompletos()
        {
            string nombreCompleto;
            nombreCompleto = Nombre + " " + Apellido;
            return nombreCompleto;
        }


       
        //1. Escribir la palabra prop
        //2. Presionar tap 2 veces
    }
}
