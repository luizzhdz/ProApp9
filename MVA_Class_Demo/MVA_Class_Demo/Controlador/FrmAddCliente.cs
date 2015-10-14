using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVA_Class_Demo
{
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0 && MessageBox.Show("Deseas agregar el cliente " + txtNombre.Text, "App empleado - cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Data.add(new Cliente(txtNombre.Text));
                MessageBox.Show("Cliente agregado", "App empleado- cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Text = "";
            }
            else
                MessageBox.Show("Favor de introducir datos validos","App empleado - cliente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void FrmAddCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
