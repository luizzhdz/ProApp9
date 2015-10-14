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
    public partial class FrmAddProducto : Form
    {
        public FrmAddProducto()
        {
            InitializeComponent();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            decimal precio = 0.0M;
            bool bandera = true;
            try
            {
                precio = Decimal.Parse(this.txtPrecio.Text);
            }
            catch (Exception)
            {
                bandera = false;
                MessageBox.Show("los valores no son validos", "app cliente-adm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (bandera)
            {
                Data.add(new Producto((Producto.Productos)Enum.Parse(typeof(Producto.Productos),cbProductos.Text),precio));
                this.txtPrecio.Text = "";
                this.cbProductos.Text = "";
            }
        }
       
        private void FrmAddProducto_Load(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(Producto.Productos)))
                cbProductos.Items.Add(item);
        }
    }
}
