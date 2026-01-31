namespace RegistroEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtID.MaxLength = 10;

            txtNombre.MaxLength = 30;
            txtApellido.MaxLength = 30;
            txtDireccion.MaxLength = 100;

            txtEmail.MaxLength = 50;
            txtSalario.MaxLength = 10;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" ||
                txtDireccion.Text == "" || txtEmail.Text == "" ||
                txtSalario.Text == "" ||
                cmbGenero.SelectedIndex == -1 ||
                cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!txtTelefono.MaskFull)
            {
                MessageBox.Show("Ingrese el número de teléfono completo");
                return;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Correo electrónico inválido");
                return;
            }

            dataGridView1.Rows.Add(
                txtID.Text,
                txtNombre.Text,
                txtApellido.Text,
                txtTelefono.Text,
                txtEmail.Text,
                cmbCargo.Text,
                txtSalario.Text,
                dtpFecha.Value.ToShortDateString(),
                cmbGenero.Text
            );

            // Limpiar
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtSalario.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }



        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo de texto (*.txt)|*.txt";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(guardar.FileName);

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    sw.WriteLine(
                        fila.Cells[0].Value + " | " +
                        fila.Cells[1].Value + " | " +
                        fila.Cells[2].Value + " | " +
                        fila.Cells[3].Value + " | " +
                        fila.Cells[4].Value + " | " +
                        fila.Cells[5].Value + " | " +
                        fila.Cells[6].Value
                    );
                }

                sw.Close();
                MessageBox.Show("Archivo guardado correctamente");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Seguro que desea salir?",
                "Confirmación",
                MessageBoxButtons.YesNo
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
