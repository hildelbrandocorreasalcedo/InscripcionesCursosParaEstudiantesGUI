using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace Design_Dashboard_Modern
{
    public partial class ConsultarEstudiante : Form
    {
        private readonly EstudianteService estudianteService;
        public ConsultarEstudiante()
        {
            InitializeComponent();
            estudianteService = new EstudianteService();
        }
        private void Consultar()
        {
            var response = estudianteService.ConsultarTodos();
            LlenarDtg(response);
            TxtTotal.Text = estudianteService.TotalizarVotos().ToString();
        }

        private void ConsultarFiltrarVoto()
        {

            var response = estudianteService.ConsultarSiVoto(CmbFiltro.Text);
            LlenarDtg(response);
            TxtConteoVotaron.Text = estudianteService.ContarSiVotos().ToString();

        }

        private void ConsultarFiltrarNoVoto()
        {
            var response = estudianteService.ConsultarNoVoto(CmbFiltro.Text);
            LlenarDtg(response);
            TxtConteoNoVotaron.Text = estudianteService.ContarNoVotos().ToString();
        }
        private void BuscarDtg()
        {
            var response = estudianteService.BuscarDtg(TxtIdentificacion.Text);
            if (response != null)
            {
                EstudianteResponse respuesta = estudianteService.BuscarPorIdentificacion(TxtIdentificacion.Text);
                Estudiante estudiante = respuesta.Estudiante;
                if (estudiante == null)
                {
                    var Messg = estudianteService.ConsultaNoEncontradaIdentificacion();
                    MessageBox.Show(Messg.Message);
                }
                LlenarDtg(response);
            }
        }

        private void LlenarDtg(ConsultaEstudianteResponse response)
        {
            if (response.Encontrado)
            {
                foreach (var item in response.Estudiante)
                {
                    DtgEstudiante.Rows.Add(item.Identificacion, item.Nombre, item.Estado);
                }
            }
        }
        private void VaciarTextBox()
        {
            TxtTotal.Text = "";
            TxtConteoInactivos.Text = "";
            TxtConteoActivos.Text = "";
        }
        private void BtReservaHab_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtcancelarHab_Click(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PulsacionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            DtgEstudiante.Rows.Clear();
            VaciarTextBox();
            var filtrado = CmbFiltro.Text;
            if (filtrado.Equals(""))
            {
                var respuesta = estudianteService.ConsultaVacia();
                MessageBox.Show(respuesta.Message);

            }
            else if (CmbFiltro.Text.Equals("TODOS"))
            {
                Consultar();
            }
            else if (CmbFiltro.Text.Equals("IN"))
            {
                ConsultarFiltrarNoVoto();
            }
            else
            {
                ConsultarFiltrarVoto();
            }
        }
    }
    }
}
