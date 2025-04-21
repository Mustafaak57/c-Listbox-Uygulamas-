using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstİller.Items.Add(txtİl.Text);
            txtİl.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<object> selectedItems = new List<object>();
            foreach (var item in lstİller.SelectedItems)
            {
                
                if (!lstİller2.Items.Contains(item))
                {
                    
                    lstİller2.Items.Add(item);
                    
                }
                selectedItems.Add(item);
            }
            foreach (var item in selectedItems)
            {
                lstİller.Items.Remove(item);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();

            foreach (var item in lstİller2.SelectedItems)
            {
                if (!lstİller.Items.Contains(item))
                {
                    lstİller.Items.Add(item);
                }

                selectedItems.Add(item);
            }

            foreach (var item in selectedItems)
            {
                lstİller2.Items.Remove(item);
            }
        }

    }
}
