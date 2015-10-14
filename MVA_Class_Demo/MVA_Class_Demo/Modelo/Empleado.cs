using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVA_Class_Demo
{
    abstract class Empleado : IComparable
    {
        private string numero_empleado;
        private string nombre;
        private string apellido;
        private string direccion;

        public string N_empleado
        {
            get { return numero_empleado; }
            set { numero_empleado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public virtual void login()  // virtual para sobreescribir 
        {
            MessageBox.Show("empleado logeado");  //metodo concreto
        }

        public abstract void contratar();

        public Empleado(string numero, string nom, string app, string dir)
        {
            N_empleado = numero;
            Nombre = nom;
            Apellido = app;
            Direccion = dir;
        }

        public int CompareTo(object obj)
        {
            Empleado comparado = (Empleado)obj;
            return String.Compare(this.nombre, comparado.Nombre);
        }
    }
}
