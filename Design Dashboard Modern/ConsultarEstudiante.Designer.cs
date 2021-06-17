
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
            this.TxtTotalVotaron = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtConsultarIdentificacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConteoNoVotaron = new System.Windows.Forms.TextBox();
            this.TxtConteoVotaron = new System.Windows.Forms.TextBox();
            this.DtgEstudiante = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroVoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEstudiante)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTotalVotaron
            // 
            this.TxtTotalVotaron.Enabled = false;
            this.TxtTotalVotaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalVotaron.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtTotalVotaron.Location = new System.Drawing.Point(733, 198);
            this.TxtTotalVotaron.Name = "TxtTotalVotaron";
            this.TxtTotalVotaron.Size = new System.Drawing.Size(66, 26);
            this.TxtTotalVotaron.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(613, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "TOTAL VOTOS";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.BtConsultarIdentificacion);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(235, 74);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(139, 44);
            this.bunifuGradientPanel2.TabIndex = 78;
            // 
            // BtConsultarIdentificacion
            // 
            this.BtConsultarIdentificacion.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultarIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultarIdentificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtConsultarIdentificacion.BorderRadius = 0;
            this.BtConsultarIdentificacion.ButtonText = " CONSULTAR";
            this.BtConsultarIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtConsultarIdentificacion.DisabledColor = System.Drawing.Color.Gray;
            this.BtConsultarIdentificacion.Iconcolor = System.Drawing.Color.Transparent;
            this.BtConsultarIdentificacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtConsultarIdentificacion.Iconimage")));
            this.BtConsultarIdentificacion.Iconimage_right = null;
            this.BtConsultarIdentificacion.Iconimage_right_Selected = null;
            this.BtConsultarIdentificacion.Iconimage_Selected = null;
            this.BtConsultarIdentificacion.IconMarginLeft = 8;
            this.BtConsultarIdentificacion.IconMarginRight = 0;
            this.BtConsultarIdentificacion.IconRightVisible = true;
            this.BtConsultarIdentificacion.IconRightZoom = 0D;
            this.BtConsultarIdentificacion.IconVisible = true;
            this.BtConsultarIdentificacion.IconZoom = 80D;
            this.BtConsultarIdentificacion.IsTab = false;
            this.BtConsultarIdentificacion.Location = new System.Drawing.Point(3, 1);
            this.BtConsultarIdentificacion.Name = "BtConsultarIdentificacion";
            this.BtConsultarIdentificacion.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultarIdentificacion.OnHovercolor = System.Drawing.Color.Blue;
            this.BtConsultarIdentificacion.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultarIdentificacion.selected = false;
            this.BtConsultarIdentificacion.Size = new System.Drawing.Size(133, 43);
            this.BtConsultarIdentificacion.TabIndex = 28;
            this.BtConsultarIdentificacion.Text = " CONSULTAR";
            this.BtConsultarIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultarIdentificacion.Textcolor = System.Drawing.Color.White;
            this.BtConsultarIdentificacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(613, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "NO VOTARON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(613, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "SI VOTARON";
            // 
            // TxtConteoNoVotaron
            // 
            this.TxtConteoNoVotaron.Enabled = false;
            this.TxtConteoNoVotaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConteoNoVotaron.Location = new System.Drawing.Point(733, 290);
            this.TxtConteoNoVotaron.Name = "TxtConteoNoVotaron";
            this.TxtConteoNoVotaron.Size = new System.Drawing.Size(66, 26);
            this.TxtConteoNoVotaron.TabIndex = 82;
            // 
            // TxtConteoVotaron
            // 
            this.TxtConteoVotaron.Enabled = false;
            this.TxtConteoVotaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConteoVotaron.Location = new System.Drawing.Point(733, 245);
            this.TxtConteoVotaron.Name = "TxtConteoVotaron";
            this.TxtConteoVotaron.Size = new System.Drawing.Size(66, 26);
            this.TxtConteoVotaron.TabIndex = 81;
            // 
            // DtgEstudiante
            // 
            this.DtgEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.Voto,
            this.NumeroVoto});
            this.DtgEstudiante.Location = new System.Drawing.Point(18, 138);
            this.DtgEstudiante.Name = "DtgEstudiante";
            this.DtgEstudiante.Size = new System.Drawing.Size(572, 356);
            this.DtgEstudiante.TabIndex = 80;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MaxInputLength = 42767;
            this.Nombre.Name = "Nombre";
            // 
            // Voto
            // 
            this.Voto.HeaderText = "Voto";
            this.Voto.Name = "Voto";
            // 
            // NumeroVoto
            // 
            this.NumeroVoto.HeaderText = "Numero de voto";
            this.NumeroVoto.Name = "NumeroVoto";
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.BtCancelar);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(612, 450);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(155, 44);
            this.bunifuGradientPanel4.TabIndex = 79;
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelar.Location = new System.Drawing.Point(5, 0);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(145, 44);
            this.BtCancelar.TabIndex = 13;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.UseVisualStyleBackColor = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtConsultar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(608, 73);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(139, 44);
            this.bunifuGradientPanel1.TabIndex = 77;
            // 
            // BtConsultar
            // 
            this.BtConsultar.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtConsultar.BorderRadius = 0;
            this.BtConsultar.ButtonText = " CONSULTAR";
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
            this.BtConsultar.Location = new System.Drawing.Point(3, 1);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultar.selected = false;
            this.BtConsultar.Size = new System.Drawing.Size(133, 43);
            this.BtConsultar.TabIndex = 28;
            this.BtConsultar.Text = " CONSULTAR";
            this.BtConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultar.Textcolor = System.Drawing.Color.White;
            this.BtConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "SI",
            "NO",
            "TODOS"});
            this.CmbFiltro.Location = new System.Drawing.Point(491, 89);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(111, 28);
            this.CmbFiltro.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(379, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Fitro por Voto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Identificacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(195, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 44);
            this.label1.TabIndex = 73;
            this.label1.Text = "CONSULTA ESTUDIANTES";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(133, 92);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(96, 26);
            this.TxtIdentificacion.TabIndex = 72;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.TxtTotalVotaron);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtConteoNoVotaron);
            this.Controls.Add(this.TxtConteoVotaron);
            this.Controls.Add(this.DtgEstudiante);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdentificacion);
            this.Name = "Reserva";
            this.Text = "RESERVA";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgEstudiante)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TxtTotalVotaron;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultarIdentificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtConteoNoVotaron;
        private System.Windows.Forms.TextBox TxtConteoVotaron;
        private System.Windows.Forms.DataGridView DtgEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroVoto;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.Button BtCancelar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultar;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdentificacion;
    }
}