using System;
using System.Collections.Generic;
using System.Text;

namespace AppPaolo.Models {
    public class PersonaModel {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public PersonaModel(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
