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
    public partial class FrmPrincipal : Form
    {  
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("estas seguro que deseas salir","App empleados Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            this.Dispose(); 
        }

        private void mostrar_form(Form formulario)
        {
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar_form(new FrmClienteC());
        }

        private void catalogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrar_form(new FrmAdministradorC());
        }

        private void catalogoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mostrar_form(new FrmProductoC());
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar_form(new FrmAddCliente());
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mostrar_form(new FrmAddProducto());
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrar_form(new FrmAddAdministrador());
        }

    }
}
