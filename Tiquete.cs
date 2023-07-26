using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    public class Tiquete
    {
        private int nroTiquete;
        private string ciudad;
        private int diasExcursion;
        private float costoAlojamiento;
        private float valorTiquete;
        private float costoComida;
        private float descuentos;
        private float subtotal;
        private float totalPago;
        private string formaPago;

        public Tiquete()
        {
        }

        public Tiquete(int nroTiquete, string ciudad)
        {
            this.nroTiquete = nroTiquete;
            this.ciudad = ciudad;
            this.diasExcursion = 0;
            this.costoAlojamiento = 0;
            this.valorTiquete = 0;
            this.costoComida = 0;
            this.descuentos = 0;
            this.subtotal = 0;
            this.totalPago = 0;
            this.formaPago = "";
        }



        public int NroTiquete
        {
            get { return nroTiquete; }
            set { nroTiquete = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public int DiasExcursion
        {
            get { return diasExcursion; }
            set { diasExcursion = value; }
        }

        public float CostoAlojamiento
        {
            get { return costoAlojamiento; }
            set { costoAlojamiento = value; }
        }

        public float ValorTiquete
        {
            get { return valorTiquete; }
            set { valorTiquete = value; }
        }

        public float CostoComida
        {
            get { return costoComida; }
            set { costoComida = value; }
        }

        public float Descuentos
        {
            get { return descuentos; }
            set { descuentos = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public float TotalPago
        {
            get { return totalPago; }
            set { totalPago = value; }
        }

        public string FormaPago
        {
            get { return formaPago; }
            set { formaPago = value; }
        }

        public void Reserva()
        {
            // Realizar el registro del tiquete
            Console.WriteLine("Tiquete reservado exitosamente.");
        }

        public void Liquidar(string ciudad, int diasExcursion, int numPersonas)
        {
            // Obtener los valores correspondientes a la ciudad seleccionada
            switch (ciudad)
            {
                case "A":
                    this.ciudad = ciudad;
                    this.diasExcursion = diasExcursion;
                    this.costoAlojamiento = 15000;
                    this.valorTiquete = 100000;
                    this.costoComida = 9000;
                    break;
                case "B":
                    this.ciudad = ciudad;
                    this.diasExcursion = diasExcursion;
                    this.costoAlojamiento = 12500;
                    this.valorTiquete = 120000;
                    this.costoComida = 11000;
                    break;
                case "C":
                    this.ciudad = ciudad;
                    this.diasExcursion = diasExcursion;
                    this.costoAlojamiento = 14000;
                    this.valorTiquete = 110000;
                    this.costoComida = 12000;
                    break;
                case "D":
                    this.ciudad = ciudad;
                    this.diasExcursion = diasExcursion;
                    this.costoAlojamiento = 17000;
                    this.valorTiquete = 115000;
                    this.costoComida = 10000;
                    break;
                default:
                    Console.WriteLine("La ciudad seleccionada no es válida.");
                    return;
            }

            // Realizar los cálculos de la liquidación
            subtotal = (diasExcursion * costoAlojamiento) + (diasExcursion * costoComida) + valorTiquete;
            descuentos = 0;

            // Aplicar descuentos
            if (numPersonas > 5)
            {
                descuentos += subtotal * 0.1f;
            }

            if (numPersonas > 10)
            {
                descuentos += subtotal * 0.15f;
            }

            if (ciudad == "A" || ciudad == "B")
            {
                descuentos += valorTiquete * 0.02f;
            }
            else if (ciudad == "C" || ciudad == "D")
            {
                descuentos += valorTiquete * 0.05f;

            }
            
            Console.WriteLine("Liquidación del tiquete realizada exitosamente.");
        }


    }



}


