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
        private readonly string FileNameCursos = "Curso.txt";

        public IList<Cursos> cursos;
        public EstudianteRepository()
        {
            cursos = new List<Cursos>();
        }

        public void GuardarCandidato(Cursos curso)
        {

            FileStream file = new FileStream(FileNameCursos, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{curso.Codigo};{curso.Nombre};{curso.CupoTotal};{curso.CupoDisponible}");
            writer.Close();
            file.Close();
        }

        public IList<Cursos> ConsultarTodosCursos()
        {
            FileStream fileStream = new FileStream(FileNameCursos, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Cursos curso = MapearCandidato(linea);
                cursos.Add(curso);
            }
            lector.Close();
            fileStream.Close();
            return cursos;
        }
        public List<Cursos> ConsultarTodosCursoDtg()
        {
            List<Cursos> cursos = new List<Cursos>();
            FileStream fileStream = new FileStream(FileNameCursos, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Cursos curso = MapearCandidato(linea);
                cursos.Add(curso);
            }
            lector.Close();
            fileStream.Close();
            return cursos;
        }

        public Cursos MapearCandidato(string linea)
        {
            Cursos curso = new Curso();
            string[] datos = linea.Split(';');
            curso.Codigo = datos[0];
            curso.Nombre = datos[1];
            curso.CupoTotal = int.Parse(datos[2]);
            curso.CupoDisponible = int.Parse(datos[3]);
            return curso;
        }


        public void EliminarCandidato(string codigo)
        {
            cursos.Clear();
            cursos = ConsultarTodosCursos();
            FileStream fileStream = new FileStream(FileNameCursos, FileMode.Create);
            fileStream.Close();
            foreach (var item in cursos)
            {
                if (item.NumeroTarjeton != codigo)
                {
                    GuardarCandidato(item);
                }
            }
        }

        public void ModificarCandidato(Cursos candidato)
        {
            cursos.Clear();
            cursos = ConsultarTodosCursos();
            FileStream fileStream = new FileStream(FileNameCursos, FileMode.Create);
            fileStream.Close();
            foreach (var item in cursos)
            {
                if (item.NumeroTarjeton != candidato.NumeroTarjeton)
                {
                    GuardarCandidato(item);
                }
                else
                {
                    GuardarCandidato(candidato);
                }
            }
        }

        public Cursos BuscarCandidato(string numeroTarjeton)
        {
            cursos.Clear();
            cursos = ConsultarTodosCursos();
            Cursos curso = new Curso();
            foreach (var item in cursos)
            {
                if (item.NumeroTarjeton.Equals(numeroTarjeton))
                {
                    return item;
                }
            }
            return null;
        }
        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////------Estudiantes-------///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////
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
