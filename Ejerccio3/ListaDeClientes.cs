using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerccio3
{
    public partial class ListasClientes : Form
    {
        Stack miPila= new Stack();
        public ListasClientes()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int numeroCliente;
            int x=0;  

               
                miPila.Push(4);
                miPila.Push(5);
                miPila.Push(6);

            for (x = 0; x < miPila.Count; x++)
            {
                numeroCliente = (int)miPila.Pop();
                ClienteslistBox1.Items.Add(numeroCliente.ToString());
                



            }



        }
    }
}
