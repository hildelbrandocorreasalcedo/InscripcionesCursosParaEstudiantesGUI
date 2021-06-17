using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Pensionado : Persona
    {
        public string Carrera { get; set; }

        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Apellido};{Sexo};{Carrera};{Telefono}";
        }
    }
}
