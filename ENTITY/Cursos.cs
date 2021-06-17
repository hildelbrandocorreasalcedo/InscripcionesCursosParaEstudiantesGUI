using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cursos
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int CupoTotal { get; set; }
        public int CupoDisponible { get; set; }


        public Cursos()
        {

        }
        public Cursos(string codigo, string nombre, int cupoTotal, int cupoDisponible)
        {
            Codigo = codigo;
            Nombre = nombre;
            CupoTotal = cupoTotal;
            CupoDisponible = cupoDisponible;
        }
        public override string ToString()
        {
            return $"Cursos:{Codigo} Nombre: {Nombre} CupoTotal: {CupoTotal} CupoDisponible: {CupoDisponible} ";
        }
    }
}
