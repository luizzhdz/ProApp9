using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MVA_Class_Demo
{
    public partial class FrmClienteC : Form
    {
        public FrmClienteC()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            VistaDatos vista = new VistaDatos();
            vista.mostrar(listBox1, Data.Clientes);
        }
    }
}
