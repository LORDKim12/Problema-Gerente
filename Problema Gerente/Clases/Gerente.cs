using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Gerente.Clases
{
    internal class Gerente:Empleado
    {
        public double bono;

        public override string MostrarDatos()
        {
            return MostrarDatos() + $"\nBono: {bono}";
        }
    }
}
