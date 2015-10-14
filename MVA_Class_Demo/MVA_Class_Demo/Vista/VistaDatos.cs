using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MVA_Class_Demo
{
    class VistaDatos
    {
        public void mostrar<T>(ListBox lista, List<T> collection)
        {
            collection.Sort();
            foreach (var item in collection)
                lista.Items.Add(item);
        }
    }
}
