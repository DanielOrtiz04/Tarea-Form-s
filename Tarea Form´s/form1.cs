using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Form_s
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string puntoOrigen = txtIncial.Text;
            string puntoDestino = txtFinal.Text;
            double velocidadConstante;
            if (!double.TryParse(txtVelocida.Text, out velocidadConstante) ||  velocidadConstante <= 0)
            {
                MessageBox.Show("Por favor, ingresa una velocidad valida y mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
             double distanciaSimulada = 100;

             double tiempoEstimado = distanciaSimulada / velocidadConstante;

             MessageBox.Show("Ingresa valores numericos validos para la disntancia y galones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            
        }
    }
}
