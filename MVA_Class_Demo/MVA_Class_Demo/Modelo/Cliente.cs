using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class Cliente : ItarjetadeLealtad, IComparable
    {
        private int puntos;
        private string nombre;

        public Cliente(string nombre)
        {
            Nombre = nombre;
            puntos = 0;
        }

        public int Puntos
        {
            get {
                if (puntos >= 0)
                    return puntos;
                else
                    return 0;
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // Metodos
        public int AgregarPuntos(int puntos)
        {
            this.puntos += puntos;
            return Puntos;
        }
        public void RecetearPuntos()
        {
            puntos = 0;
        }

        public override string ToString()
        {
            return String.Format("Cliente: {0} - Puntos Acumulados: {1}", Nombre, Puntos);
        }

        public int CompareTo(object obj)
        {
            Cliente other = (Cliente)obj;
            return String.Compare(this.nombre, other.Nombre);
        }
    }
}
