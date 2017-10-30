using System;

namespace EjercicioBanco
{
    public class Persona
    {
        public long DNI { get; set; }
        //public string Nombre { get; set; }
        
        public string nombre { get; set;}

        public string apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        public long dni {get; set;}

        public string mail {get; set;}
        
              public string NombreCompleto()
        {
            return string.Format("{0} {1}", this.nombre, this.apellido);
        }

    }
}
