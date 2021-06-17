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

        public EstudianteService()
        {
            estudianteRepository = new EstudianteRepository();     
        }
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
