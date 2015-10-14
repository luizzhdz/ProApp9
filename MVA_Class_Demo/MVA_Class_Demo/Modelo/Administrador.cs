using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVA_Class_Demo
{
    class Administrador : Empleado
    {
        public enum Depto { ventas, compras, cotrataciones, gerencia };
        private Depto departamento;

        public Depto Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public override void contratar()
        {
            MessageBox.Show("administrador contratando");
        }

        public Administrador(string numero, string nom , string app, string dir, Depto dpto)
            :base(numero,nom,app,dir)
        {
            departamento=dpto; 
        }

        public override string ToString()
        {
 	       return String.Format("{0} - {1} {2} {3} {4} ", N_empleado, Nombre, Apellido, Direccion, Departamento);
        }
        

    }
}
