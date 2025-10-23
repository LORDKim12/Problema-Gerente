using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Gerente.Clases
{
    internal class Gerente:Empleado
    {
        public decimal bono;

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"\nBono: {bono}";
        }
    }
}
