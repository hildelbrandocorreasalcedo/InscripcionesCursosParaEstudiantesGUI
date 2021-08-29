
namespace Design_Dashboard_Modern
{
    partial class RegistroCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCursos));
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCupoTotal = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelColor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCupoDisponible = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelColor.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel6.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(248, 122);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(259, 30);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtIdentificacion_TextChanged);
            this.TxtCodigo.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.labNombre.Location = new System.Drawing.Point(77, 187);
            this.labNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(81, 25);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(248, 180);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(259, 30);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtCupoTotal
            // 
            this.TxtCupoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCupoTotal.Location = new System.Drawing.Point(248, 238);
            this.TxtCupoTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCupoTotal.Name = "TxtCupoTotal";
            this.TxtCupoTotal.Size = new System.Drawing.Size(259, 30);
            this.TxtCupoTotal.TabIndex = 7;
            this.TxtCupoTotal.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtCupoTotal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(332, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "REGISTRAR CURSOS";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(77, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(77, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cupo total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelColor
            // 
            this.PanelColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelColor.BackgroundImage")));
            this.PanelColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelColor.Controls.Add(this.pictureBox1);
            this.PanelColor.GradientBottomLeft = System.Drawing.Color.Blue;
            this.PanelColor.GradientBottomRight = System.Drawing.Color.Aqua;
            this.PanelColor.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.PanelColor.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelColor.Location = new System.Drawing.Point(624, 105);
            this.PanelColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Quality = 10;
            this.PanelColor.Size = new System.Drawing.Size(351, 292);
            this.PanelColor.TabIndex = 25;
            this.PanelColor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelColor_Paint);
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.Activecolor = System.Drawing.Color.Transparent;
            this.BtRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.BtRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtRegistrar.BorderRadius = 0;
            this.BtRegistrar.ButtonText = "    REGISTRAR";
            this.BtRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.BtRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtRegistrar.Iconimage")));
            this.BtRegistrar.Iconimage_right = null;
            this.BtRegistrar.Iconimage_right_Selected = null;
            this.BtRegistrar.Iconimage_Selected = null;
            this.BtRegistrar.IconMarginLeft = 8;
            this.BtRegistrar.IconMarginRight = 0;
            this.BtRegistrar.IconRightVisible = true;
            this.BtRegistrar.IconRightZoom = 0D;
            this.BtRegistrar.IconVisible = true;
            this.BtRegistrar.IconZoom = 80D;
            this.BtRegistrar.IsTab = false;
            this.BtRegistrar.Location = new System.Drawing.Point(8, 1);
            this.BtRegistrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtRegistrar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtRegistrar.selected = false;
            this.BtRegistrar.Size = new System.Drawing.Size(185, 54);
            this.BtRegistrar.TabIndex = 28;
            this.BtRegistrar.Text = "    REGISTRAR";
            this.BtRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRegistrar.Textcolor = System.Drawing.Color.White;
            this.BtRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click_2);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtRegistrar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(100, 503);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(201, 54);
            this.bunifuGradientPanel1.TabIndex = 26;
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
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(816, 506);
            this.bunifuGradientPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(207, 54);
            this.bunifuGradientPanel4.TabIndex = 29;
            this.bunifuGradientPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel4_Paint);
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelar.Location = new System.Drawing.Point(7, 0);
            this.BtCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(193, 54);
            this.BtCancelar.TabIndex = 13;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.ButCancelar_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.BtEliminar);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(343, 505);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(201, 54);
            this.bunifuGradientPanel2.TabIndex = 29;
            // 
            // BtEliminar
            // 
            this.BtEliminar.Activecolor = System.Drawing.Color.Transparent;
            this.BtEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEliminar.BorderRadius = 0;
            this.BtEliminar.ButtonText = "    ELIMINAR";
            this.BtEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtEliminar.Iconimage")));
            this.BtEliminar.Iconimage_right = null;
            this.BtEliminar.Iconimage_right_Selected = null;
            this.BtEliminar.Iconimage_Selected = null;
            this.BtEliminar.IconMarginLeft = 8;
            this.BtEliminar.IconMarginRight = 0;
            this.BtEliminar.IconRightVisible = true;
            this.BtEliminar.IconRightZoom = 0D;
            this.BtEliminar.IconVisible = true;
            this.BtEliminar.IconZoom = 80D;
            this.BtEliminar.IsTab = false;
            this.BtEliminar.Location = new System.Drawing.Point(8, 1);
            this.BtEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtEliminar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtEliminar.selected = false;
            this.BtEliminar.Size = new System.Drawing.Size(185, 54);
            this.BtEliminar.TabIndex = 28;
            this.BtEliminar.Text = "    ELIMINAR";
            this.BtEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEliminar.Textcolor = System.Drawing.Color.White;
            this.BtEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(77, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cupo disponible";
            // 
            // TxtCupoDisponible
            // 
            this.TxtCupoDisponible.Enabled = false;
            this.TxtCupoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCupoDisponible.Location = new System.Drawing.Point(248, 303);
            this.TxtCupoDisponible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCupoDisponible.Name = "TxtCupoDisponible";
            this.TxtCupoDisponible.Size = new System.Drawing.Size(259, 30);
            this.TxtCupoDisponible.TabIndex = 30;
            this.TxtCupoDisponible.Text = "0";
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.Controls.Add(this.BtLimpiar);
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(531, 202);
            this.bunifuGradientPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(73, 54);
            this.bunifuGradientPanel6.TabIndex = 47;
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Activecolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BtLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtLimpiar.BorderRadius = 0;
            this.BtLimpiar.ButtonText = "";
            this.BtLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.BtLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtLimpiar.Iconimage")));
            this.BtLimpiar.Iconimage_right = null;
            this.BtLimpiar.Iconimage_right_Selected = null;
            this.BtLimpiar.Iconimage_Selected = null;
            this.BtLimpiar.IconMarginLeft = 8;
            this.BtLimpiar.IconMarginRight = 0;
            this.BtLimpiar.IconRightVisible = true;
            this.BtLimpiar.IconRightZoom = 0D;
            this.BtLimpiar.IconVisible = true;
            this.BtLimpiar.IconZoom = 80D;
            this.BtLimpiar.IsTab = false;
            this.BtLimpiar.Location = new System.Drawing.Point(0, 1);
            this.BtLimpiar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtLimpiar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtLimpiar.selected = false;
            this.BtLimpiar.Size = new System.Drawing.Size(73, 54);
            this.BtLimpiar.TabIndex = 28;
            this.BtLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtLimpiar.Textcolor = System.Drawing.Color.White;
            this.BtLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.Controls.Add(this.BtConsultar);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(531, 122);
            this.bunifuGradientPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(73, 54);
            this.bunifuGradientPanel5.TabIndex = 48;
            // 
            // BtConsultar
            // 
            this.BtConsultar.Activecolor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtConsultar.BorderRadius = 0;
            this.BtConsultar.ButtonText = "";
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
            this.BtConsultar.Location = new System.Drawing.Point(1, 2);
            this.BtConsultar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtConsultar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtConsultar.selected = false;
            this.BtConsultar.Size = new System.Drawing.Size(65, 53);
            this.BtConsultar.TabIndex = 28;
            this.BtConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConsultar.Textcolor = System.Drawing.Color.White;
            this.BtConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // RegistroCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1089, 633);
            this.Controls.Add(this.bunifuGradientPanel6);
            this.Controls.Add(this.bunifuGradientPanel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCupoDisponible);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.PanelColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCupoTotal);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroCursos";
            this.Text = "RegistroPensionado";
            this.Load += new System.EventHandler(this.RegistroPensionado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelColor.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCupoTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelColor;
        private Bunifu.Framework.UI.BunifuFlatButton BtRegistrar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtRegistrarPensionado;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtEliminar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuFlatButton BtLimpiar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Bunifu.Framework.UI.BunifuFlatButton BtConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCupoDisponible;
    }
}