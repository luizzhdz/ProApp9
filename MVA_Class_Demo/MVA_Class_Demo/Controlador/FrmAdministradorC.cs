﻿using System;
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
    public partial class FrmAdministradorC : Form
    {
        public FrmAdministradorC()
        {
            InitializeComponent();
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            VistaDatos vista = new VistaDatos();
            vista.mostrar(listBox1, Data.Administradores);
        }
    }
}

