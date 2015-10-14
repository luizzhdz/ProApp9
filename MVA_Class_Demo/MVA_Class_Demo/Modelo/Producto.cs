using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class Producto : IComparable
    {
        public enum Productos { tortas, empanadas, quesadillas, tostadas, tacos, licuados };
        private Productos nombre;
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
                else
                    precio = 0;
            }
        }

        public Productos Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Producto(Productos nom, decimal prec)
        {
            Nombre = nom;
            Precio = prec;
        }

        public override string ToString()
        {
            return String.Format("{0} - $ {1} ", Nombre, Precio);
        }

        public int CompareTo(object obj)
        {
            Producto other = (Producto)obj;
            return String.Compare(this.nombre.ToString(), other.Nombre.ToString());
        }
    }
}
