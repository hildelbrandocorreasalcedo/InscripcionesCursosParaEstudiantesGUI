using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class EstudianteService
    {
        private readonly EstudianteRepository estudianteRepository;
        private readonly EstudianteRepository CursoRepository;
        public EstudianteService()
        {
            estudianteRepository = new EstudianteRepository();
            CursoRepository = new EstudianteRepository();
        }

        public string GuardarCurso(Candidatos curso)
        {
            try
            {
                if (CursoRepository.BuscarCurso(curso.Codigo) == null)
                {
                    CandidatoRepository.GuardarCandidato(curso);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                return $"El Codigo{curso.NumeroTarjeton} ya se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de Datos: " + e.Message;
            }
        }

        public string EliminarCurso(string codigo)
        {
            try
            {
                if (CursoRepository.BuscarCurso(codigo) != null)
                {
                    CursoRepository.EliminarCurso(codigo);
                    return $"El curso con codigo {codigo} ha sido eliminada satisfacatoriamente";
                }
                return $"El codigo{codigo} no se encuentra registrada, por favor verifique los datos";
            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }

        public string ModificarCurso(Candidatos curso)
        {
            try
            {
                if (CursoRepository.BuscarCurso(curso.Codigo) != null)
                {

                    CursoRepository.ModificarCurso(curso);
                    return $"El curso con codigo {curso.NumeroTarjeton} ha sido modificada satisfacatoriamente";
                }
                return $"El codigo {curso.Codigo} no se encuentra registrada, por favor verifique los datos";
            }
            catch (Exception e)
            {
                return "Error de datos" + e.Message;
            }
        }
        public RespuestaBusqueda BuscarCurso(string Codigo)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                Cursos curso = CursoRepository.BuscarCurso(Codigo);
                if (curso == null)
                {
                    respuesta.Mensaje = $"El Curso con Codigo {Codigo} no se encuentra registrado";
                    respuesta.Curso = null;
                }
                else
                {
                    respuesta.Curso = curso;
                    respuesta.Mensaje = "Curso encontrado\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.Curso = null;
                respuesta.Error = true;
            }
            return respuesta;
        }

        public RespuestaConsulta ConsultarTodosCurso()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                IList<Cursos> Cursoss = CursoRepository.ConsultarTodosCurso();
                if (Cursoss.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de candidatos";
                    respuesta.Cursos = Cursoss;
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                    respuesta.Cursos = null;
                }
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: " + e.Message;
                respuesta.Cursos = null;
            }
            return respuesta;
        }

        public ConsultaCandidatoResponse ConsultarTodosCursoDtg()
        {
            try
            {
                List<Cursos> curso = CursoRepository.ConsultarTodosCursoDtg();
                if (curso != null)
                {
                    return new ConsultaCandidatoResponse(curso);
                }
                else
                {
                    return new ConsultaCandidatoResponse("El Curso buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {

                return new ConsultaCandidatoResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public class ConsultaCandidatoResponse
        {
            public List<Cursos> Curso { get; set; }
            public string Message { get; set; }

            public ConsultaCandidatoResponse(List<Cursos> curso)
            {
                Curso = new List<Cursos>();
                Curso = curso;
            }
            public ConsultaCandidatoResponse(string message)
            {
                Message = message;
            }
        }
        //////////////////////////////////------------------------///////////////////////////////////////
        /////////////////////////////////------Estudiantes-------///////////////////////////////////////
        ////////////////////////////////------------------------///////////////////////////////////////
        public string Guardar(Estudiante estudiante)
        {
            try
            {

                if (estudianteRepository.Buscar(estudiante.Identificacion) == null)
                {
                    estudianteRepository.Guardar(estudiante);
                    return $"se han guardado Satisfactoriamente los datos de: {estudiante.Nombre} ";
                }
                else
                {
                    return $"Lo sentimos, con la Identificación {estudiante.Identificacion} ya se encuentra registrada";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }
        }

        public EstudianteResponse BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                Estudiante estudiante = estudianteRepository.Buscar(identificacion);
                if (estudiante != null)
                {
                    return new EstudianteResponse(estudiante);
                }
                else
                {
                    return new EstudianteResponse($"La persona con la identificación {identificacion} no se encuentra registrada");
                }
            }
            catch (Exception e)
            {
                return new EstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultaVacia()
        {
            try
            {
                return new ConsultaEstudianteResponse("Escoja una Opción de Filtrado");
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultaVaciaBuscarDtg()
        {
            try
            {
                return new ConsultaEstudianteResponse("Escriba la identificacion a buscar");
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultaNoEncontradaIdentificacion()
        {
            try
            {
                return new ConsultaEstudianteResponse("La identificacion buscada no se encuentra, vuelva a intentarlo con otra identificacion");
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultarTodos()
        {
            try
            {
                List<Estudiante> estudiante = estudianteRepository.ConsultarTodos();
                if (estudiante != null)
                {
                    return new ConsultaEstudianteResponse(estudiante);
                }
                else
                {
                    return new ConsultaEstudianteResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse ConsultarActivo(string estado)
        {
            try
            {
                List<Estudiante> estudiantes = estudianteRepository.FiltrarActivo(estado);
                if (estudiantes != null)
                {
                    return new ConsultaEstudianteResponse(estudiantes);
                }
                else
                {
                    return new ConsultaEstudianteResponse("el estudiante buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {

                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }


        public ConsultaEstudianteResponse ConsultarInactivo(string estado)
        {
            try
            {
                List<Estudiante> estudiantes = estudianteRepository.FiltrarInactivo(estado);
                if (estudiantes != null)
                {
                    return new ConsultaEstudianteResponse(estudiantes);
                }
                else
                {
                    return new ConsultaEstudianteResponse("el estudiante buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public ConsultaEstudianteResponse BuscarDtg(string identificacion)
        {
            try
            {
                List<Estudiante> estudiantes = estudianteRepository.BuscarDtg(identificacion);
                if (estudiantes != null)
                {
                    return new ConsultaEstudianteResponse(estudiantes);
                }
                else
                {
                    return new ConsultaEstudianteResponse($"La persona con la identificación {identificacion} no se encuentra registrada");
                }
            }
            catch (Exception e)
            {
                return new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public int TotalizarEstado()
        {
            return estudianteRepository.TaotalizarEstado();
        }

        public int ContarActivos()
        {
            return estudianteRepository.ContarActivos();
        }

        public int ContarInactivos()
        {
            return estudianteRepository.ContarInactivos();
        }
    }
    public class EstudianteResponse
    {
        public Estudiante Estudiante { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public EstudianteResponse(Estudiante estudiante)
        {
            Estudiante = new Estudiante();
            Estudiante = estudiante;
            Encontrado = true;
        }
        public EstudianteResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }

    public class ConsultaEstudianteResponse
    {
        public List<Estudiante> Estudiante { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public ConsultaEstudianteResponse(List<Estudiante> estudiante)
        {
            Estudiante = new List<Estudiante>();
            Estudiante = estudiante;
            Encontrado = true;
        }
        public ConsultaEstudianteResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }

}
