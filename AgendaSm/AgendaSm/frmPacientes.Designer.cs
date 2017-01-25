namespace AgendaSm
{
    partial class frmPacientes
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
            this.gpDatos = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNexpediente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelEmergencia = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.cbDerechohabiente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpHerramientas = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.id_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNexpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sApaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAmaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCurp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFecnac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelEmergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpDatos
            // 
            this.gpDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpDatos.Controls.Add(this.label11);
            this.gpDatos.Controls.Add(this.txtNexpediente);
            this.gpDatos.Controls.Add(this.label10);
            this.gpDatos.Controls.Add(this.txtCurp);
            this.gpDatos.Controls.Add(this.label9);
            this.gpDatos.Controls.Add(this.txtTelEmergencia);
            this.gpDatos.Controls.Add(this.rbMasculino);
            this.gpDatos.Controls.Add(this.rbFemenino);
            this.gpDatos.Controls.Add(this.cbDerechohabiente);
            this.gpDatos.Controls.Add(this.label5);
            this.gpDatos.Controls.Add(this.label4);
            this.gpDatos.Controls.Add(this.dtpFecNac);
            this.gpDatos.Controls.Add(this.label7);
            this.gpDatos.Controls.Add(this.label6);
            this.gpDatos.Controls.Add(this.label3);
            this.gpDatos.Controls.Add(this.label2);
            this.gpDatos.Controls.Add(this.label8);
            this.gpDatos.Controls.Add(this.txtTelefono);
            this.gpDatos.Controls.Add(this.txtNombre);
            this.gpDatos.Controls.Add(this.txtAmaterno);
            this.gpDatos.Controls.Add(this.txtApaterno);
            this.gpDatos.Location = new System.Drawing.Point(115, 12);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Size = new System.Drawing.Size(1000, 197);
            this.gpDatos.TabIndex = 7;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos del Paciente";
            this.gpDatos.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(639, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "No. Expediente";
            // 
            // txtNexpediente
            // 
            this.txtNexpediente.Location = new System.Drawing.Point(637, 32);
            this.txtNexpediente.Name = "txtNexpediente";
            this.txtNexpediente.Size = new System.Drawing.Size(102, 20);
            this.txtNexpediente.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "CURP";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(26, 152);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(252, 20);
            this.txtCurp.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "No. Teléfono de Emergencia";
            // 
            // txtTelEmergencia
            // 
            this.txtTelEmergencia.Location = new System.Drawing.Point(456, 143);
            this.txtTelEmergencia.Name = "txtTelEmergencia";
            this.txtTelEmergencia.Size = new System.Drawing.Size(144, 20);
            this.txtTelEmergencia.TabIndex = 41;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(352, 106);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 39;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(352, 83);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 40;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // cbDerechohabiente
            // 
            this.cbDerechohabiente.FormattingEnabled = true;
            this.cbDerechohabiente.Items.AddRange(new object[] {
            "IMSS",
            "ISSTE",
            "ISSTESON",
            "SEGURO POPULAR"});
            this.cbDerechohabiente.Location = new System.Drawing.Point(637, 105);
            this.cbDerechohabiente.Name = "cbDerechohabiente";
            this.cbDerechohabiente.Size = new System.Drawing.Size(150, 21);
            this.cbDerechohabiente.TabIndex = 38;
            this.cbDerechohabiente.Text = "Eliga su opción...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Derechohabiente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNac.Location = new System.Drawing.Point(26, 89);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(176, 20);
            this.dtpFecNac.TabIndex = 35;
            this.dtpFecNac.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "No. Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre (s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Apellido Materno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Apellido Paterno";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(456, 86);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(144, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(352, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Location = new System.Drawing.Point(181, 32);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(165, 20);
            this.txtAmaterno.TabIndex = 28;
            // 
            // txtApaterno
            // 
            this.txtApaterno.Location = new System.Drawing.Point(26, 32);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(149, 20);
            this.txtApaterno.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(50, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 75);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(19, 37);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(536, 20);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImage = global::AgendaSm.Properties.Resources.add;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(664, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(54, 51);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::AgendaSm.Properties.Resources.buscar2;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(590, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 45);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // gpHerramientas
            // 
            this.gpHerramientas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpHerramientas.Controls.Add(this.btnEliminar);
            this.gpHerramientas.Controls.Add(this.btnHistorial);
            this.gpHerramientas.Controls.Add(this.btnEditar);
            this.gpHerramientas.Controls.Add(this.btnGuardar);
            this.gpHerramientas.Location = new System.Drawing.Point(835, 215);
            this.gpHerramientas.Name = "gpHerramientas";
            this.gpHerramientas.Size = new System.Drawing.Size(280, 75);
            this.gpHerramientas.TabIndex = 42;
            this.gpHerramientas.TabStop = false;
            this.gpHerramientas.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::AgendaSm.Properties.Resources.Delet;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(228, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 45);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorial.BackgroundImage = global::AgendaSm.Properties.Resources.folder;
            this.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Location = new System.Drawing.Point(159, 19);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(46, 45);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::AgendaSm.Properties.Resources.edit;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(78, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 45);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = global::AgendaSm.Properties.Resources.Save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(6, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(46, 45);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_paciente,
            this.sNexpediente,
            this.sApaterno,
            this.sAmaterno,
            this.sNombre,
            this.sCurp,
            this.bSexo,
            this.dtFecnac,
            this.sTelefono,
            this.sTelEmergencia});
            this.dgvDatos.Location = new System.Drawing.Point(50, 311);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(1065, 167);
            this.dgvDatos.TabIndex = 43;
            this.dgvDatos.DataSourceChanged += new System.EventHandler(this.dgvDatos_DataSourceChanged);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(66, 493);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(83, 13);
            this.lblTotalRegistros.TabIndex = 44;
            this.lblTotalRegistros.Text = "No. Pacientes : ";
            // 
            // cbActivos
            // 
            this.cbActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbActivos.AutoSize = true;
            this.cbActivos.Checked = true;
            this.cbActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActivos.Location = new System.Drawing.Point(1003, 492);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(112, 17);
            this.cbActivos.TabIndex = 45;
            this.cbActivos.Text = "Pacientes de Baja";
            this.cbActivos.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::AgendaSm.Properties.Resources.home;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.CausesValidation = false;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 45);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseHover += new System.EventHandler(this.dtpFecNac_MouseHover);
            // 
            // id_paciente
            // 
            this.id_paciente.DataPropertyName = "id_paciente";
            this.id_paciente.HeaderText = "No.";
            this.id_paciente.Name = "id_paciente";
            // 
            // sNexpediente
            // 
            this.sNexpediente.DataPropertyName = "sNexpediente";
            this.sNexpediente.HeaderText = "No. Expediente";
            this.sNexpediente.Name = "sNexpediente";
            // 
            // sApaterno
            // 
            this.sApaterno.DataPropertyName = "sApaterno";
            this.sApaterno.HeaderText = "Apellido Paterno";
            this.sApaterno.Name = "sApaterno";
            // 
            // sAmaterno
            // 
            this.sAmaterno.DataPropertyName = "sAmaterno";
            this.sAmaterno.HeaderText = "Apellido Materno";
            this.sAmaterno.Name = "sAmaterno";
            // 
            // sNombre
            // 
            this.sNombre.DataPropertyName = "sNombre";
            this.sNombre.HeaderText = "Nombre (s)";
            this.sNombre.Name = "sNombre";
            // 
            // sCurp
            // 
            this.sCurp.DataPropertyName = "sCurp";
            this.sCurp.HeaderText = "CURP";
            this.sCurp.Name = "sCurp";
            // 
            // bSexo
            // 
            this.bSexo.DataPropertyName = "bSexo";
            this.bSexo.HeaderText = "Sexo";
            this.bSexo.Name = "bSexo";
            // 
            // dtFecnac
            // 
            this.dtFecnac.DataPropertyName = "dtFecnac";
            this.dtFecnac.HeaderText = "Edad";
            this.dtFecnac.Name = "dtFecnac";
            // 
            // sTelefono
            // 
            this.sTelefono.DataPropertyName = "sTelefono";
            this.sTelefono.HeaderText = "Teléfono";
            this.sTelefono.Name = "sTelefono";
            // 
            // sTelEmergencia
            // 
            this.sTelEmergencia.DataPropertyName = "sTelEmergencia";
            this.sTelEmergencia.HeaderText = "Teléfono de Emergencia";
            this.sTelEmergencia.Name = "sTelEmergencia";
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 528);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gpHerramientas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.gpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salud Mental - Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpHerramientas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNexpediente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelEmergencia;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.ComboBox cbDerechohabiente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpHerramientas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNexpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sApaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAmaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCurp;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFecnac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelEmergencia;
    }
}