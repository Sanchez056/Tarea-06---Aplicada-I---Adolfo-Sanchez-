using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercccio_1
{
    public partial class CalificacionesSalonClases : Form
    {
        public CalificacionesSalonClases()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int i = 0;
           ArrayList ItemList = new ArrayList();
            ItemList.Add("Item4");
            ItemList.Add("Item5");
            ItemList.Add("Item2");
            ItemList.Add("Item1");
            ItemList.Add("Item3");
            MessageBox.Show("Shows Added Items");
            /*for (i = 0; i < = ItemList.- 1; i++)
            {
                MessageBox.Show(ItemList[i].ToString());
            }*/
            //insert an item 
            ItemList.Insert(3, "Item6");
            //sort itemms in an arraylist 
            ItemList.Sort();
            //remove an item 
            ItemList.Remove("Item1");
            //remove item from a specified index 
            ItemList.RemoveAt(3);
            MessageBox.Show("Shows final Items the ArrayList");
            /*for (i = 0; i < = ItemList.Count - 1; i++)
            {
                MessageBox.Show(ItemList[i].ToString());
            }*/
        }
    }
}
