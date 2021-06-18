using ENTITY;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public void GuardarCurso(Cursos curso)
        {

            FileStream file = new FileStream(FileNameCursos, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{curso.Codigo};{curso.Nombre};{curso.CupoTotal};{curso.CupoDisponible}");
            writer.Close();
            file.Close();
        }

        public IList<Cursos> ConsultarTodosCurso()
        {
            FileStream fileStream = new FileStream(FileNameCursos, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Cursos curso = MapearCurso(linea);
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
                Cursos curso = MapearCurso(linea);
                cursos.Add(curso);
            }
            lector.Close();
            fileStream.Close();
            return cursos;
        }

        public Cursos MapearCurso(string linea)
        {
            Cursos curso = new Cursos();
            string[] datos = linea.Split(';');
            curso.Codigo = datos[0];
            curso.Nombre = datos[1];
            curso.CupoTotal = int.Parse(datos[2]);
            curso.CupoDisponible = int.Parse(datos[3]);
            return curso;
        }


        public void EliminarCurso(string codigo)
        {
            cursos.Clear();
            cursos = ConsultarTodosCurso();
            FileStream fileStream = new FileStream(FileNameCursos, FileMode.Create);
            fileStream.Close();
            foreach (var item in cursos)
            {
                if (item.Codigo != codigo)
                {
                    GuardarCurso(item);
                }
            }
        }

        public void ModificarCurso(Cursos curso)
        {
            cursos.Clear();
            cursos = ConsultarTodosCurso();
            FileStream fileStream = new FileStream(FileNameCursos, FileMode.Create);
            fileStream.Close();
            foreach (var item in cursos)
            {
                if (item.Codigo != curso.Codigo)
                {
                    GuardarCurso(item);
                }
                else
                {
                    GuardarCurso(curso);
                }
            }
        }

        public Cursos BuscarCurso(string codigo)
        {
            cursos.Clear();
            cursos = ConsultarTodosCurso();
            Cursos curso = new Cursos();
            foreach (var item in cursos)
            {
                if (item.Codigo.Equals(codigo))
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
