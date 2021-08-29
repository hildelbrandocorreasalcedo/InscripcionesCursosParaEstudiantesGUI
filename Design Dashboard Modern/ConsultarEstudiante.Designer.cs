
namespace Design_Dashboard_Modern
{
    partial class ConsultarEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEstudiante));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConteoInactivos = new System.Windows.Forms.TextBox();
            this.TxtConteoActivos = new System.Windows.Forms.TextBox();
            this.DtgEstudiante = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEstudiante)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtTotal.Location = new System.Drawing.Point(977, 244);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(87, 30);
            this.TxtTotal.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(841, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 85;
            this.label5.Text = "TOTAL ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(841, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "INACTIVOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(841, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "ACTIVOS";
            // 
            // TxtConteoInactivos
            // 
            this.TxtConteoInactivos.Enabled = false;
            this.TxtConteoInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConteoInactivos.Location = new System.Drawing.Point(977, 357);
            this.TxtConteoInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConteoInactivos.Name = "TxtConteoInactivos";
            this.TxtConteoInactivos.Size = new System.Drawing.Size(87, 30);
            this.TxtConteoInactivos.TabIndex = 82;
            // 
            // TxtConteoActivos
            // 
            this.TxtConteoActivos.Enabled = false;
            this.TxtConteoActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConteoActivos.Location = new System.Drawing.Point(977, 302);
            this.TxtConteoActivos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConteoActivos.Name = "TxtConteoActivos";
            this.TxtConteoActivos.Size = new System.Drawing.Size(87, 30);
            this.TxtConteoActivos.TabIndex = 81;
            // 
            // DtgEstudiante
            // 
            this.DtgEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.Estado});
            this.DtgEstudiante.Location = new System.Drawing.Point(24, 170);
            this.DtgEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.DtgEstudiante.Name = "DtgEstudiante";
            this.DtgEstudiante.RowHeadersWidth = 51;
            this.DtgEstudiante.Size = new System.Drawing.Size(763, 438);
            this.DtgEstudiante.TabIndex = 80;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.MinimumWidth = 6;
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MaxInputLength = 42767;
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.BtCancelar);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(816, 554);
            this.bunifuGradientPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(207, 54);
            this.bunifuGradientPanel4.TabIndex = 79;
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelar.Location = new System.Drawing.Point(7, 0);
            this.BtCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(193, 54);
            this.BtCancelar.TabIndex = 13;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click_1);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtConsultar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(811, 90);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(212, 54);
            this.bunifuGradientPanel1.TabIndex = 77;
            // 
            // BtConsultar
            // 
            this.BtConsultar.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtConsultar.BorderRadius = 0;
            this.BtConsultar.ButtonText = "                  CONSULTAR";
            this.BtConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.BtConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtConsultar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtConsultar.Iconimage")));
            this.BtConsultar.Iconimage_right = null;
            this.BtConsultar.Iconimage_right_Selected = null;
            this.BtConsultar.Iconimage_Selected = null;
            this.BtConsultar.IconMarginLeft = 8;
            this.BtConsultar.IconMarginRight = 0;
            this.BtConsultar.IconRightVisible = true;
            this.BtConsultar.IconRightZoom = 0D;
            this.BtConsultar.IconVisible = true;
            this.BtConsultar.IconZoom = 80D;
            this.BtConsultar.IsTab = false;
            this.BtConsultar.Location = new System.Drawing.Point(4, 1);
            this.BtConsultar.Margin = new System.Windows.Forms.Padding(5);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultar.selected = false;
            this.BtConsultar.Size = new System.Drawing.Size(203, 53);
            this.BtConsultar.TabIndex = 28;
            this.BtConsultar.Text = "                  CONSULTAR";
            this.BtConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultar.Textcolor = System.Drawing.Color.White;
            this.BtConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "AC",
            "IN",
            "TODOS"});
            this.CmbFiltro.Location = new System.Drawing.Point(655, 110);
            this.CmbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(147, 33);
            this.CmbFiltro.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(572, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 75;
            this.label7.Text = "Fitro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(260, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 55);
            this.label1.TabIndex = 73;
            this.label1.Text = "CONSULTA ESTUDIANTES";
            // 
            // ConsultarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1089, 633);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtConteoInactivos);
            this.Controls.Add(this.TxtConteoActivos);
            this.Controls.Add(this.DtgEstudiante);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarEstudiante";
            this.Text = "RESERVA";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgEstudiante)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtConteoInactivos;
        private System.Windows.Forms.TextBox TxtConteoActivos;
        private System.Windows.Forms.DataGridView DtgEstudiante;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.Button BtCancelar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultar;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}