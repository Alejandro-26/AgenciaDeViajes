namespace Agencia
{
    public partial class Form1 : Form
    {
        Usuario usuario = new Usuario();
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idUsuario = T1.Text;
            string nombreUsuario = T2.Text;
            string contrase�a = T3.Text;
            string rolUsuario = comboBox1.SelectedItem as string;


            usuario.IdUsuario = idUsuario;
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contrase�a = contrase�a;
            usuario.RolUsuario = rolUsuario;

            if (!string.IsNullOrEmpty(idUsuario) && !string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(contrase�a) && !string.IsNullOrEmpty(rolUsuario))
            {
                usuario.Registro(idUsuario, nombreUsuario, contrase�a, rolUsuario);

                MessageBox.Show("Registro de usuario realizado.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de realizar el registro.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LimpiarCampos()
        {
            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            T4.Text = "";
            T5.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = T4.Text;
            string contrase�a = T5.Text;

            bool loginExitoso = usuario.Login(nombreUsuario, contrase�a);

            if (loginExitoso)
            {
                MessageBox.Show("Inicio de sesi�n exitoso.", "Inicio de Sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                Hide();

            }
            else
            {
                MessageBox.Show("Inicio de sesi�n fallido. Nombre de usuario o contrase�a incorrectos.", "Inicio de Sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nuevaContrase�a = T3.Text;

            if (!string.IsNullOrEmpty(nuevaContrase�a))
            {
                usuario.ActualizarContrase�a(nuevaContrase�a);

                MessageBox.Show("Contrase�a actualizada correctamente.", "Cambio de Contrase�a", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una nueva contrase�a antes de realizar el cambio.", "Cambio de Contrase�a", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void T1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void T4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}