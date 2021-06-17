using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class RegistroPensionado : Form
    {
        public RegistroPensionado()
        {
            InitializeComponent();
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
            if (TxtIdentificacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtIdentificacion, "Por Favor Ingrese La Identificación");
            }
            if (TxtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtApellido, "Por Favor Ingrese Los Apellidos");
            }
            if (TxtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtTelefono, "Este Campo Es Obligatorio");
            }
            if (CmbSexo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CmbSexo, "Esta Selección Es Obligatoria");
            }
            if (CombCarrera.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CombCarrera, "Esta Selección Es Obligatoria");
            }
            return ok;
        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(CmbSexo, "");
            errorProvider1.SetError(CombCarrera, "");
            errorProvider1.SetError(TxtIdentificacion, "");
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtTelefono, "");
            errorProvider1.SetError(TxtApellido, "");
        }

        private void ButCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(TxtIdentificacion.Text, out numero))
            {
                errorProvider1.SetError(TxtIdentificacion, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtIdentificacion, "");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CombCarrera, "");
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
            if (!int.TryParse(TxtTelefono.Text, out numero))
            {
                errorProvider1.SetError(TxtTelefono, "Ingrese Solo Numeros");
            }
            else
            {
                errorProvider1.SetError(TxtTelefono, "");
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
            errorProvider1.SetError(CmbSexo, "");
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
                MessageBox.Show("Se Registraron los datos Correctamente");
            }
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                MessageBox.Show("Se Modificaron los datos Correctamente");
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if (validarcampos())
            {
                MessageBox.Show("Se Eliminaron los datos Correctamente");
            }
        }
    }
}
