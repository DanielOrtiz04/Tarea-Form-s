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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using System;
            using System.Collections.Generic;
            using System.ComponentModel;
            using System.Data;
            using System.Drawing;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;
            using System.Windows.Forms;

namespace Tarea_Windows_form
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void btnCalcular_Click(object sender, EventArgs e)
            {
                try


                {
                    double distanciaKM = double.Parse(txtDistancia.Text);
                    double galonesconsumidos = double.Parse(txtGalones.Text);
                    double rendimientoKMPorGalon = distanciaKM / galonesconsumidos;

                    lblRendimiento.Text = $"Rendimiento: {rendimientoKMPorGalon:F2} km/galón";
                    lblGalonesConsumidos.Text = $"Galones consumidos: {galonesconsumidos:F2}";
                }
                catch

                {
                    MessageBox.Show("Ingresa valores numericos validos para la distancia y los galones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }

}
    }
}
