using MVA_Class_Demo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica9.Controlador
{
    public partial class FrmAddAdministrativo : Form
    {
        public FrmAddAdministrativo()
        {
            InitializeComponent();
        }

        private void AddAdministrativo_Load(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(Administrador.Depto)))
                cmbDepartamento.Items.Add(item);
        }

        private void validarDatos(ErrorProvider ep, TextBox txt)
        {
            if (txt.Text.Trim().Length == 0)
            {
                ep.Icon = Icon.FromHandle(((Bitmap)imageList1.Images[0]).GetHicon());
                ep.SetError(txt, "Dato no válido");
            }
            else
            {
                ep.Icon = Icon.FromHandle(((Bitmap)imageList1.Images[1]).GetHicon());
                ep.SetError(txt, "Dato Correcto");
            }
        }
        private void txtNumero_Leave(object sender, EventArgs e)
        {
            validarDatos(errorNumero, txtNumero);
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            validarDatos(errorNombre, txtNombre);
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            validarDatos(errorApellido, txtApellido);
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            validarDatos(errorDireccion, txtDireccion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0 && MessageBox.Show("Deseas agregar el administrador " + txtNombre.Text, " App Empleado - Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Administrador ad = new Administrador(txtNumero.Text,txtNombre.Text,txtApellido.Text,txtDireccion.Text,(Administrador.Depto)Enum.Parse(typeof(Administrador.Depto),cmbDepartamento.Text));
                Data.add(ad);
                ModeloSecuencial m = new ModeloSecuencial();
                m.escribir("administradores.txt", ad,cmbDepartamento);
                MessageBox.Show("Administrador Agregado", "App - Empleado - Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Text = "";
                this.txtApellido.Text = "";
                this.txtDireccion.Text = "";
                this.txtNumero.Text = "";
                this.cmbDepartamento.Text = "";
            }
            else
            {
                MessageBox.Show("Favor de introducir datos válidos", "App - Empleado - Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
