using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    interface ItarjetadeLealtad // En una interfaz todo es Abstracto
    {
        int Puntos { get; }
        int AgregarPuntos(int transaccion);

        void RecetearPuntos();
    }
}
