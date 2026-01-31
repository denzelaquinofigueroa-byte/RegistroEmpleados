namespace RegistroEmpleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtID = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            btnGuardarArchivo = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpFecha = new DateTimePicker();
            cmbGenero = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtEmail = new TextBox();
            txtSalario = new TextBox();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colCargo = new DataGridViewTextBoxColumn();
            colSalario = new DataGridViewTextBoxColumn();
            label12 = new Label();
            txtTelefono = new MaskedTextBox();
            cmbCargo = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(35, 128);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Century Gothic", 9F);
            txtID.Location = new Point(162, 128);
            txtID.Name = "txtID";
            txtID.Size = new Size(117, 26);
            txtID.TabIndex = 1;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Century Gothic", 9F);
            txtApellido.Location = new Point(162, 224);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(245, 26);
            txtApellido.TabIndex = 4;
            txtApellido.TextChanged += textBox4_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(162, 173);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 26);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += textBox5_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Century Gothic", 9F);
            txtDireccion.Location = new Point(162, 527);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(260, 26);
            txtDireccion.TabIndex = 7;
            txtDireccion.TextChanged += textBox7_TextChanged;
            // 
            // btnGuardarArchivo
            // 
            btnGuardarArchivo.BackColor = Color.LimeGreen;
            btnGuardarArchivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarArchivo.ForeColor = Color.Transparent;
            btnGuardarArchivo.Location = new Point(204, 623);
            btnGuardarArchivo.Name = "btnGuardarArchivo";
            btnGuardarArchivo.Size = new Size(218, 45);
            btnGuardarArchivo.TabIndex = 8;
            btnGuardarArchivo.Text = "GUARDAR ARCHIVO";
            btnGuardarArchivo.UseVisualStyleBackColor = false;
            btnGuardarArchivo.Click += btnGuardarArchivo_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Transparent;
            btnSalir.Location = new Point(34, 623);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(196, 46);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Highlight;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.Transparent;
            btnAgregar.Location = new Point(38, 623);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 45);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(31, 173);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 11;
            label2.Text = "NOMBRE:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(35, 273);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 12;
            label3.Text = "GENERO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(38, 534);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 13;
            label4.Text = "DIRECCIÓN:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.Location = new Point(35, 224);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 14;
            label5.Text = "APELLIDO:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.Location = new Point(35, 586);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 15;
            label6.Text = "FECHA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F);
            label7.Location = new Point(38, 394);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 16;
            label7.Text = "TELEFONO:";
            label7.Click += label7_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Century Gothic", 9F);
            dtpFecha.Location = new Point(162, 581);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(260, 26);
            dtpFecha.TabIndex = 19;
            dtpFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbGenero
            // 
            cmbGenero.Font = new Font("Century Gothic", 9F);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "masculino", "femenino", "otro" });
            cmbGenero.Location = new Point(162, 273);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(120, 28);
            cmbGenero.TabIndex = 20;
            cmbGenero.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(448, 19);
            label8.Name = "label8";
            label8.Size = new Size(513, 36);
            label8.TabIndex = 21;
            label8.Text = "SISTEMA DE GESTION DE EMPLEADOS";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F);
            label9.Location = new Point(38, 488);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 27;
            label9.Text = "SALARIO:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F);
            label10.Location = new Point(38, 443);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 26;
            label10.Text = "EMAIL:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F);
            label11.Location = new Point(35, 320);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 25;
            label11.Text = "CARGO:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 9F);
            txtEmail.Location = new Point(162, 440);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 26);
            txtEmail.TabIndex = 23;
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Century Gothic", 9F);
            txtSalario.Location = new Point(162, 485);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(260, 26);
            txtSalario.TabIndex = 22;
            txtSalario.TextChanged += txtSalario_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colNombre, colApellido, colTelefono, colEmail, colCargo, colSalario });
            dataGridView1.Location = new Point(34, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 516);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 75;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.Width = 125;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.Width = 125;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.Width = 125;
            // 
            // colCargo
            // 
            colCargo.HeaderText = "Cargo";
            colCargo.MinimumWidth = 6;
            colCargo.Name = "colCargo";
            colCargo.Width = 125;
            // 
            // colSalario
            // 
            colSalario.HeaderText = "Salario";
            colSalario.MinimumWidth = 6;
            colSalario.Name = "colSalario";
            colSalario.Width = 125;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 14.8F);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(34, 19);
            label12.Name = "label12";
            label12.Size = new Size(270, 31);
            label12.TabIndex = 29;
            label12.Text = "LISTA DE EMPLEADOS";
            label12.Click += label12_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 9F);
            txtTelefono.Location = new Point(162, 394);
            txtTelefono.Mask = "(999)000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(120, 26);
            txtTelefono.TabIndex = 30;
            // 
            // cmbCargo
            // 
            cmbCargo.Font = new Font("Century Gothic", 9F);
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Gerente", "Administrador", "Secretaria", "Contador", "Técnico", "Vendedor" });
            cmbCargo.Location = new Point(162, 320);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(120, 28);
            cmbCargo.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnSalir);
            panel1.Location = new Point(507, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 685);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnGuardarArchivo);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(cmbCargo);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtDireccion);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtSalario);
            panel2.Controls.Add(cmbGenero);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpFecha);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(30, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 685);
            panel2.TabIndex = 33;
            panel2.Paint += panel2_Paint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9F);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(35, 76);
            label13.Name = "label13";
            label13.Size = new Size(200, 20);
            label13.TabIndex = 30;
            label13.Text = "INFORMACION PERSONAL";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 14.8F);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(35, 19);
            label14.Name = "label14";
            label14.Size = new Size(293, 31);
            label14.TabIndex = 32;
            label14.Text = "DATOS DEL EMPLEADO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 782);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Button btnGuardarArchivo;
        private Button btnSalir;
        private Button btnAgregar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpFecha;
        private ComboBox cmbGenero;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtEmail;
        private TextBox txtSalario;
        private DataGridView dataGridView1;
        private Label label12;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colCargo;
        private DataGridViewTextBoxColumn colSalario;
        private MaskedTextBox txtTelefono;
        private ComboBox cmbCargo;
        private Panel panel1;
        private Panel panel2;
        private Label label13;
        private Label label14;
    }
}
