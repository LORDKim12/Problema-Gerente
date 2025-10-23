using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Gerente.Clases
{
    internal class Empleado
    {
        public string? nombre;
        public decimal salario;

        public virtual string MostrarDatos()
        {
            return $"Nombre: {nombre}\nSalario: {salario}";
        }
    }
}
