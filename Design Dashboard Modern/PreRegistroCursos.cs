using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace Design_Dashboard_Modern
{
    public partial class PreRegistroCursos : Form
    {
        EstudianteService CursoService = new EstudianteService();
        EstudianteService estudianteService = new EstudianteService();
        public PreRegistroCursos()
        {
            InitializeComponent();
        }

        private void BuscarDtg()
        {

            EstudianteResponse respuesta = estudianteService.BuscarPorIdentificacion(TxtCodigo.Text);
            Estudiante estudiante = respuesta.Estudiante;
            if (estudiante != null)
            {
                TxtNombre.Text = estudiante.Nombre;
                var response = estudianteService.BuscarDtg(TxtCodigo.Text);
                if (response != null)
                {
                    DtgVotaciones.Enabled = true;
                    BtRegistrarVoto.Enabled = true;
                    ConsultarTodosCandidatos();
                }
            }
            else
            {
                LimpiarTxt();
                var Messg = estudianteService.ConsultaNoEncontradaIdentificacion();
                MessageBox.Show(Messg.Message);
                DtgVotaciones.Rows.Clear();
                BtRegistrarVoto.Enabled = false;
                DtgVotaciones.Enabled = false;
            }

        }
        private void ConsultarTodosCandidatos()
        {
            var response = CursoService.ConsultarTodosCursoDtg();
            foreach (var item in response.Curso)
            {
                DtgVotaciones.Rows.Add(item.Codigo, item.Nombre);
            }
        }
        private void ConsultarGanancias_Load(object sender, EventArgs e)
        {

        }

        private void BtCancelarGanancias_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            DtgVotaciones.Rows.Clear();
            var filtrado = TxtCodigo.Text;
            if (filtrado.Equals(""))
            {
                var respuesta = estudianteService.ConsultaVaciaBuscarDtg();
                MessageBox.Show(respuesta.Message);
                BtRegistrarVoto.Enabled = false;
                DtgVotaciones.Enabled = false;
            }
            else
            {
                BuscarDtg();
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            
            LimpiarTxt();
            DtgVotaciones.Rows.Clear();
        }
        private void LimpiarTxt()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            BtRegistrarVoto.Enabled = false;
            DtgVotaciones.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
