using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.ComponentModel;
using Practica9.Modelo;
using System.Windows.Forms;

namespace Practica9
{
    class ModeloSecuencial
    {
        private BinaryReader lector;
        private BinaryWriter escritor;

        public ModeloSecuencial()
        {
            escritor = null;
            lector = null;
        }

        public void abrir_escritura(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            escritor = new BinaryWriter(fs);
        }

        public void abrir_lectura(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            lector = new BinaryReader(fs);
        }

        public void escribir(string archivo, Producto p, ComboBox cbnombre)
        {
            abrir_escritura(archivo);
            escritor.Write(cbnombre.Text);
            escritor.Write(Convert.ToString(p.Precio));
            escritor.Close();
        }

        public void escribir(string archivo, Administrador a, ComboBox dpto)
        {
            abrir_escritura(archivo);
            escritor.Write(a.EmpNumber);
            escritor.Write(a.FirstName);
            escritor.Write(a.LastName);
            escritor.Write(a.Address);
            escritor.Write(dpto.Text);
            escritor.Close();
        }

        public void escribir(string archivo, Cliente c)
        {
            abrir_escritura(archivo);
            escritor.Write(c.Nombre);
            escritor.Write(Convert.ToString(c.Puntos));
            escritor.Close();
        }

        /*public List<Producto> leer(string archivo, ComboBox cbproductos)
        {
            List<Producto> productos = new List<Producto>();
            if (escritor != null)
                escritor.Close();
            if (File.Exists(archivo))
            {
                abrir_lectura(archivo);
                try
                {
                    lector.Read();
                    while (true)
                    {
                        double precio = Convert.ToDouble(lector.ReadString());
                        productos.Add(new Producto((Producto.Productos)Enum.Parse(typeof(Producto.Productos), cbproductos.Text), precio));
                    }
                }
                catch (EndOfStreamException)
                {
                    //fin del archivo
                }
                finally
                {
                    lector.Close();
                }

            }
            else
                MessageBox.Show(String.Format("El  archivo {0} no existe", archivo));
            return productos;
        }

        public List<Administrador> leerA(string archivo, ComboBox cbdpto)
        {
            List<Administrador> administradores = new List<Administrador>();
            if (escritor != null)
                escritor.Close();
            if (File.Exists(archivo))
            {
                abrir_lectura(archivo);
                try
                {
                    lector.Read();
                    while (true)
                    {
                        string numero = lector.ReadString();
                        string nombre = lector.ReadString();
                        string apellidos = lector.ReadString();
                        string direccion = lector.ReadString();
                        double precio = Convert.ToDouble(lector.ReadString());
                        administradores.Add(new Administrador(numero,nombre,apellidos,direccion,(Administrador.Depto)Enum.Parse(typeof(Administrador.Depto), cbdpto.Text)));
                    }
                }
                catch (EndOfStreamException)
                {
                    //fin del archivo
                }
                finally
                {
                    lector.Close();
                }

            }
            else
                MessageBox.Show(String.Format("El  archivo {0} no existe", archivo));
            return administradores;
        }

        public List<Cliente> leer(string archivo)
        {
            List<Cliente> clientes = new List<Cliente>();
            if (escritor != null)
                escritor.Close();
            if (File.Exists(archivo))
            {
                abrir_lectura(archivo);
                try
                {
                    lector.Read();
                    while (true)
                    {
                        string nombre = lector.ReadString();
                        clientes.Add(new Cliente(nombre));
                    }
                }
                catch (EndOfStreamException)
                {
                    //fin del archivo
                }
                finally
                {
                    lector.Close();
                }

            }
            else
                MessageBox.Show(String.Format("El  archivo {0} no existe", archivo));
            return clientes;
        }*/
    }
}
