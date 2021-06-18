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
    public partial class RegistroCursos : Form
    {
        EstudianteService CursoService = new EstudianteService();
        public RegistroCursos()
        {
            InitializeComponent();
        }

        private void BorrarMensajesErrorIdentificacion()
        {
            errorProvider1.SetError(TxtCodigo, "");

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabTelefono_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotRegistrar_Click(object sender, EventArgs e)
        {
            
        }
        

        private bool validarcampos()
        {
            bool ok = true;
            if(TxtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombre, "Por Favor Ingrese los Nombres");
            }           
            if (TxtCodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtCodigo, "Por Favor Ingrese La Codigo");
            }
            if (TxtCupoTotal.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtCupoTotal, "Este Campo Es Obligatorio");
            }
            return ok;
        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(TxtCodigo, "");
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtCupoTotal, "");
            
        }

        private void ButCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(TxtCodigo.Text, out numero))
            {
                errorProvider1.SetError(TxtCodigo, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtCodigo, "");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void TxtIdentificacion_Validated(object sender, EventArgs e)
        {
            
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(TxtCupoTotal.Text, out numero))
            {
                errorProvider1.SetError(TxtCupoTotal, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtCupoTotal, "");
            }
        }

        private void RegistroPensionado_Load(object sender, EventArgs e)
        {

        }

        private void LabFechanacimiento_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PanelColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void BtRegistrar_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtRegistrar_Click_2(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                Cursos curso = MapearCurso();
                string mensaje = CursoService.GuardarCurso(curso);
                MessageBox.Show(mensaje);
                LimpiarTxt();
            }
        }
        private Cursos MapearCurso()
        {
            Cursos curso = new Cursos();
            curso.Codigo = TxtCodigo.Text;
            curso.Nombre = TxtNombre.Text;
            curso.CupoTotal = int.Parse(TxtCupoTotal.Text);
            curso.CupoDisponible = int.Parse(TxtCupoDisponible.Text);
            return curso;
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            BorrarMensajesErrorIdentificacion();
            if (validarcampos())
            {
                string codigo = TxtCodigo.Text;
                if (codigo != "")
                {
                    RespuestaBusqueda respuesta = CursoService.BuscarCurso(codigo);
                    if (respuesta.Curso != null)
                    {
                        codigo = TxtCodigo.Text;
                        var mensaje = CursoService.EliminarCurso(codigo);
                        MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show($"El curso con el codigo {codigo} no se encuentra registrado");
                    }
                }
                LimpiarTxt();
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        private void LimpiarTxt()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtCupoDisponible.Text = "0";
            TxtCupoTotal.Text = "";
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text;
            if (codigo != "")
            {
                RespuestaBusqueda respuesta = CursoService.BuscarCurso(codigo);

                if (respuesta.Curso != null)
                {
                    Cursos curso = respuesta.Curso;
                    TxtNombre.Text = curso.Nombre;
                    TxtCupoTotal.Text = curso.CupoTotal.ToString();
                    TxtCupoDisponible.Text = curso.CupoDisponible.ToString();
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
            }
            else
            {
                MessageBox.Show("digite el codigo a buscar");
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtNombre, "");
        }
    }
}
