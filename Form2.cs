using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agencia
{
    public partial class Form2 : Form
    {
        Tiquete tiquete = new Tiquete();
        Cliente cliente = new Cliente();
        public Form2()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles de la interfaz
            string ciudad = comboBox1.SelectedItem.ToString();
            int diasExcursion = int.Parse(comboBox2.SelectedItem.ToString());
            int numPersonas = ObtenerNumeroPersonas();

            // Llamar al método Liquidar de la clase Tiquete
            tiquete.Liquidar(ciudad, diasExcursion, numPersonas);
            // Calcular el subtotal y el total incluyendo el costo del tiquete
            float subtotal = (diasExcursion * tiquete.CostoAlojamiento) + (diasExcursion * tiquete.CostoComida) + tiquete.ValorTiquete;
            float descuentos = tiquete.Descuentos;

            // Aplicar descuentos adicionales según el tipo de pago
            if (radioButton1.Checked) // Pago en efectivo
            {
                descuentos += subtotal * 0.04f;
            }
            else if (radioButton2.Checked) // Pago con tarjeta de crédito
            {
                descuentos += subtotal * 0.015f;
            }

            float totalPago = subtotal - descuentos;

            // Actualizar los valores en los controles de la interfaz
            L1.Text = tiquete.ValorTiquete.ToString();
            L2.Text = (diasExcursion * tiquete.CostoAlojamiento).ToString();
            L3.Text = (diasExcursion * tiquete.CostoComida).ToString();
            L4.Text = ObtenerValorComida().ToString();
            L5.Text = tiquete.ValorTiquete.ToString();
            L6.Text = tiquete.CostoComida.ToString();
            L7.Text = tiquete.CostoAlojamiento.ToString();
            L8.Text = tiquete.CostoComida.ToString();
            L9.Text = subtotal.ToString(); // Actualizar con el subtotal calculado
            L10.Text = descuentos.ToString(); // Actualizar con los descuentos aplicados
            L11.Text = totalPago.ToString(); // Actualizar con el total de pago

            // Mostrar mensaje de éxito
            MessageBox.Show("Liquidación del tiquete realizada exitosamente.");



        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            tiquete.Reserva();

            // Mostrar mensaje de éxito
            MessageBox.Show("Tiquete reservado exitosamente.");
        }

        // Método para obtener el número de personas seleccionado en la interfaz
        private int ObtenerNumeroPersonas()
        {
            if (int.TryParse(comboBox2.SelectedItem.ToString(), out int numPersonas))
            {
                return numPersonas;
            }

            return 0; // Valor predeterminado si no se puede convertir a entero
        }

        // Método para obtener el valor de comida según la selección en la interfaz
        private float ObtenerValorComida()
        {


            string ciudad = comboBox1.SelectedItem.ToString();

            switch (ciudad)
            {
                case "A":
                    return 9000;
                case "B":
                    return 11000;
                case "C":
                    return 12000;
                case "D":
                    return 10000;
                default:
                    return 0; // Valor predeterminado si no hay selección válida
            }
        }

        // Método para limpiar los controles de la interfaz
        private void LimpiarInterfaz()
        {
            // Limpiar los valores en los controles de la interfaz
            comboBox1.SelectedIndex = -1; // Deseleccionar la ciudad
            comboBox2.SelectedIndex = -1; // Deseleccionar el número de personas

            L1.Text = "$____________";
            L2.Text = "$____________";
            L3.Text = "$____________";
            L4.Text = "$____________";
            L5.Text = "$____________";
            L6.Text = "$____________";
            L7.Text = "$____________";
            L8.Text = "$____________";
            L9.Text = "$____________";
            L10.Text = "$____________";
            L11.Text = "$____________";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            T4.Text = "";
            T5.Text = "";
            T6.Text = "";
            T7.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Limpiar los controles de la interfaz
            LimpiarInterfaz();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            string cedula = T1.Text;
            string nombres = T2.Text;
            string apellidos = T3.Text;
            string telefono = T4.Text;
            string direccion = T5.Text;
            string email = T6.Text;
            string ciudad = T7.Text;

            cliente.Actualizar(cedula, nombres, apellidos, telefono, direccion, email, ciudad);


            MessageBox.Show("Datos del cliente actualizados exitosamente.");


            MostrarDatosCliente();
        }



        // Evento del botón "REGISTRO"
        private void button5_Click(object sender, EventArgs e)
        {
            string cedula = T1.Text;
            string nombres = T2.Text;
            string apellidos = T3.Text;
            string telefono = T4.Text;
            string direccion = T5.Text;
            string email = T6.Text;
            string ciudad = T7.Text;

            cliente.Cedula = cedula;
            cliente.Nombres = nombres;
            cliente.Apellidos = apellidos;
            cliente.Telefono = telefono;
            cliente.Direccion = direccion;
            cliente.Email = email;
            cliente.Ciudad = ciudad;

            cliente.Registro();

            MessageBox.Show("Cliente registrado exitosamente.");

            MostrarDatosCliente();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Crear una ventana de diálogo para ingresar la cédula
            string cedula = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cédula del cliente:", "Consulta de Cliente");

            // Verificar si la cédula ingresada coincide con la del cliente actual
            if (cliente.Cedula == cedula)
            {
                // Mostrar los datos del cliente en los campos de texto
                T1.Text = cliente.Cedula;
                T2.Text = cliente.Nombres;
                T3.Text = cliente.Apellidos;
                T4.Text = cliente.Telefono;
                T5.Text = cliente.Direccion;
                T6.Text = cliente.Email;
                T7.Text = cliente.Ciudad;
            }
            else
            {
                // Mostrar mensaje de cliente no encontrado en la ventana de diálogo
                MessageBox.Show("No se encontró un cliente con la cédula ingresada.", "Consulta de Cliente");
            }
        }



        private void MostrarDatosCliente()
        {
            // Mostrar los datos del cliente en la interfaz gráfica
            T1.Text = cliente.Cedula;
            T2.Text = cliente.Nombres;
            T3.Text = cliente.Apellidos;
            T4.Text = cliente.Telefono;
            T5.Text = cliente.Direccion;
            T6.Text = cliente.Email;
            T7.Text = cliente.Ciudad;
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void L10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void T1_TextChanged(object sender, EventArgs e)
        {

        }

        private void L2_Click(object sender, EventArgs e)
        {

        }

        private void L5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void L3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
