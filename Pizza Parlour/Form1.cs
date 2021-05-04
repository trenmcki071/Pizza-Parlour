using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class pizzaParlour : Form
    {
        public pizzaParlour()
        {
            InitializeComponent();
        }
        
        // globals
        double basePrice = 7.00;
        double toppingPrice = 1.25;
        double toppingNumber;
        double totalPrice;
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //textbox string into a double then do the math and print the result
            toppingNumber = Int32.Parse(textBox1.Text);
            totalPrice = toppingPrice * toppingNumber + basePrice;
            outputText.Text = $"The price of the {toppingNumber} topping pizza is ${totalPrice}";
        }
    }
}
