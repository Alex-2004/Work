using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Visible = false;
            foreach (string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
                if (s == "Bread" || s == "Tomatoes" || s == "Washing powder" || s == "Milk" || s == "Wine * 2")
                {
                    label1.Visible = true;  
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
