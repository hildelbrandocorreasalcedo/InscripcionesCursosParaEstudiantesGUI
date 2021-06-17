using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;

namespace DAL
{
    public class EstudianteRepository
    {
        private readonly string FileName = "Estudiante.txt";
        public void Guardar(Estudiante estudiante)
        {

            FileStream file = new FileStream(FileName, FileMode.Open);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{estudiante.Identificacion};{estudiante.Nombre};{estudiante.Estado}");
            writer.Close();
            file.Close();
        }

        public Estudiante Buscar(string identificacion)
        {
            List<Estudiante> estudiantes = ConsultarTodos();
            foreach (var item in estudiantes)
            {
                if (Encontrado(item.Identificacion, identificacion))
                {
                    return item;
                }
            }
            return null;
        }

        private bool Encontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }

        private Estudiante Map(string linea)
        {
            Estudiante estudiante = new Estudiante();
            char delimiter = ';';
            string[] matrizEstudiante = linea.Split(delimiter);
            estudiante.Identificacion = matrizEstudiante[0];
            estudiante.Nombre = matrizEstudiante[1];
            estudiante.Estado = matrizEstudiante[2];


            return estudiante;
        }

        public List<Estudiante> ConsultarTodos()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Estudiante estudiante = Map(linea);
                estudiantes.Add(estudiante);
            }
            reader.Close();
            file.Close();
            return estudiantes;
        }

        public List<Estudiante> FiltrarActivo(string voto)
        {

            List<Estudiante> estudiantes = ConsultarTodos();
            List<Estudiante> estudiantesFiltradas =
                (from estudiante in estudiantes
                 where estudiante.Estado.Equals("AC")
                 select estudiante).ToList();
            return estudiantesFiltradas;
        }

        public List<Estudiante> FiltrarInactivo(string voto)
        {

            List<Estudiante> estudiantes = ConsultarTodos();
            List<Estudiante> estudiantesFiltradas =
                (from estudiante in estudiantes
                 where estudiante.Estado.Equals("IN")
                 select estudiante).ToList();
            return estudiantesFiltradas;
        }
        public List<Estudiante> BuscarDtg(string identificacion)
        {
            List<Estudiante> estudiantes = ConsultarTodos();
            List<Estudiante> estudiantesFiltradasBuscado =
                (from estudiante in estudiantes
                 where estudiante.Identificacion.Equals(identificacion)
                 select estudiante).ToList();
            return estudiantesFiltradasBuscado;
        }

        public int TaotalizarEstado()
        {
            return ConsultarTodos().Count();
        }       
        public int ContarActivos()
        {
            return ConsultarTodos().Where(p => p.Estado == "AC").Count();
        }
        public int ContarInactivos()
        {
            return ConsultarTodos().Where(p => p.Estado == "IN").Count();
        }
    }
}
