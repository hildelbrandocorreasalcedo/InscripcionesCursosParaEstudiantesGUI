
namespace Design_Dashboard_Modern
{
    partial class Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PulsacionTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DtgCodigoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgCantidadPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgNumeroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgNumeroMeses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgCostoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgCostoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtReservar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Habitación 101",
            "Habitación 102",
            "Habitación 103",
            "Habitación 104",
            "Habitación 201",
            "Habtiación 202",
            "Habitación 203",
            "Habitación 204",
            "Habitación 205",
            "Habitación 301",
            "Habitación 302",
            "Habitación 303",
            "Habitación 304",
            "Habitación 305"});
            this.comboBox1.Location = new System.Drawing.Point(219, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 26);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 29, 6, 37, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(224, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(163, 26);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.Value = new System.DateTime(2021, 4, 29, 6, 37, 11, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 44);
            this.label3.TabIndex = 30;
            this.label3.Text = "SERVICIO DE RESERVACION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(37, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Numero de habitacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(3, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Codigo  de reserva";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(3, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Identificacion del pensionado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(3, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Fecha de entrada";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(36, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Cantidad de personas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(3, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Fecha de salida";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(37, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(300, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "Costo de la habitacion     $ 400000 pesos";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(17, 322);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Costo del servicio de reserva";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(224, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 26);
            this.textBox2.TabIndex = 42;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(224, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 26);
            this.textBox3.TabIndex = 43;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox2.Location = new System.Drawing.Point(219, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(61, 28);
            this.comboBox2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(37, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Estado de la habitacion";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "DISPONIBLE",
            "OCUPADO"});
            this.comboBox3.Location = new System.Drawing.Point(218, 123);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 28);
            this.comboBox3.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.PulsacionTxt);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 241);
            this.panel3.TabIndex = 51;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // PulsacionTxt
            // 
            this.PulsacionTxt.Location = new System.Drawing.Point(224, 197);
            this.PulsacionTxt.Name = "PulsacionTxt";
            this.PulsacionTxt.ReadOnly = true;
            this.PulsacionTxt.Size = new System.Drawing.Size(100, 26);
            this.PulsacionTxt.TabIndex = 57;
            this.PulsacionTxt.TextChanged += new System.EventHandler(this.PulsacionTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(3, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Numero de meses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(143, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "RESERVACION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(431, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 241);
            this.panel1.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(149, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "HABITACION";
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
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(623, 309);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(155, 44);
            this.bunifuGradientPanel4.TabIndex = 54;
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
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DtgCodigoReserva,
            this.DtgIdentificacion,
            this.DtgCantidadPersonas,
            this.DtgNumeroHabitacion,
            this.DtgEstado,
            this.DtgFechaIngreso,
            this.DtgFechaSalida,
            this.DtgNumeroMeses,
            this.DtgCostoHabitacion,
            this.DtgCostoReserva});
            this.dataGridView1.Location = new System.Drawing.Point(12, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 139);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DtgCodigoReserva
            // 
            this.DtgCodigoReserva.HeaderText = "CodigoReserva";
            this.DtgCodigoReserva.Name = "DtgCodigoReserva";
            // 
            // DtgIdentificacion
            // 
            this.DtgIdentificacion.HeaderText = "Identificacion";
            this.DtgIdentificacion.Name = "DtgIdentificacion";
            // 
            // DtgCantidadPersonas
            // 
            this.DtgCantidadPersonas.HeaderText = "Cantidad Personas";
            this.DtgCantidadPersonas.Name = "DtgCantidadPersonas";
            // 
            // DtgNumeroHabitacion
            // 
            this.DtgNumeroHabitacion.HeaderText = "Numero de Habitacion";
            this.DtgNumeroHabitacion.Name = "DtgNumeroHabitacion";
            // 
            // DtgEstado
            // 
            this.DtgEstado.HeaderText = "Estado";
            this.DtgEstado.Name = "DtgEstado";
            // 
            // DtgFechaIngreso
            // 
            this.DtgFechaIngreso.HeaderText = "Fecha de Ingreso";
            this.DtgFechaIngreso.Name = "DtgFechaIngreso";
            // 
            // DtgFechaSalida
            // 
            this.DtgFechaSalida.HeaderText = "Fecha de Salida";
            this.DtgFechaSalida.Name = "DtgFechaSalida";
            // 
            // DtgNumeroMeses
            // 
            this.DtgNumeroMeses.HeaderText = "Numero meses";
            this.DtgNumeroMeses.Name = "DtgNumeroMeses";
            // 
            // DtgCostoHabitacion
            // 
            this.DtgCostoHabitacion.HeaderText = "CostoHabitacion";
            this.DtgCostoHabitacion.Name = "DtgCostoHabitacion";
            // 
            // DtgCostoReserva
            // 
            this.DtgCostoReserva.HeaderText = "CostoReserva";
            this.DtgCostoReserva.Name = "DtgCostoReserva";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtReservar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(431, 309);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(151, 44);
            this.bunifuGradientPanel1.TabIndex = 56;
            // 
            // BtReservar
            // 
            this.BtReservar.Activecolor = System.Drawing.Color.Transparent;
            this.BtReservar.BackColor = System.Drawing.Color.Transparent;
            this.BtReservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtReservar.BorderRadius = 0;
            this.BtReservar.ButtonText = "    RESERVAR";
            this.BtReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtReservar.DisabledColor = System.Drawing.Color.Gray;
            this.BtReservar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtReservar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtReservar.Iconimage")));
            this.BtReservar.Iconimage_right = null;
            this.BtReservar.Iconimage_right_Selected = null;
            this.BtReservar.Iconimage_Selected = null;
            this.BtReservar.IconMarginLeft = 8;
            this.BtReservar.IconMarginRight = 0;
            this.BtReservar.IconRightVisible = true;
            this.BtReservar.IconRightZoom = 0D;
            this.BtReservar.IconVisible = true;
            this.BtReservar.IconZoom = 80D;
            this.BtReservar.IsTab = false;
            this.BtReservar.Location = new System.Drawing.Point(6, -1);
            this.BtReservar.Name = "BtReservar";
            this.BtReservar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtReservar.OnHovercolor = System.Drawing.Color.Blue;
            this.BtReservar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtReservar.selected = false;
            this.BtReservar.Size = new System.Drawing.Size(139, 45);
            this.BtReservar.TabIndex = 28;
            this.BtReservar.Text = "    RESERVAR";
            this.BtReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtReservar.Textcolor = System.Drawing.Color.White;
            this.BtReservar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(238, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 26);
            this.textBox1.TabIndex = 58;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Name = "Reserva";
            this.Text = "RESERVA";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtReservar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PulsacionTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgCodigoReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgCantidadPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgNumeroHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgFechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgNumeroMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgCostoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtgCostoReserva;
    }
}