using Problema_Gerente.Clases;

namespace Problema_Gerente
{
    public partial class Form1 : Form
    {
        Gerente gerente = new Gerente();
        Empleado empleado = new Empleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            gerente.nombre = "Juan Perez";
            gerente.salario = 50000;
            gerente.bono = 10000;

            empleado.nombre = "Ana Gomez";
            empleado.salario = 30000;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gerente.MostrarDatos());
            MessageBox.Show(empleado.MostrarDatos());
        }
    }
}
