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
            string contraseña = T3.Text;
            string rolUsuario = comboBox1.SelectedItem as string;


            usuario.IdUsuario = idUsuario;
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contraseña = contraseña;
            usuario.RolUsuario = rolUsuario;

            if (!string.IsNullOrEmpty(idUsuario) && !string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(contraseña) && !string.IsNullOrEmpty(rolUsuario))
            {
                usuario.Registro(idUsuario, nombreUsuario, contraseña, rolUsuario);

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
            string contraseña = T5.Text;

            bool loginExitoso = usuario.Login(nombreUsuario, contraseña);

            if (loginExitoso)
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                Hide();

            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Nombre de usuario o contraseña incorrectos.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nuevaContraseña = T3.Text;

            if (!string.IsNullOrEmpty(nuevaContraseña))
            {
                usuario.ActualizarContraseña(nuevaContraseña);

                MessageBox.Show("Contraseña actualizada correctamente.", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una nueva contraseña antes de realizar el cambio.", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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