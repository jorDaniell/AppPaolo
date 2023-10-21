namespace AppPaolo.Models {
    public class PersonaModel : BaseModel {

        public string Nombre { get; set; }
        public int Edad { get; set; }

        public PersonaModel(string nombre, int edad) {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
