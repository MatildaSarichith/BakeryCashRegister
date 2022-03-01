using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryCashRegister
{
    public partial class Form1 : Form
    {
        //global variables

        double cupcakeCost = 3.50;
        double cakeCost = 10.00;
        double cookieCost = 2.00;

        double numOfCupcakes = 0;
        double numOfCakes = 0;
        double numOfCookies = 0;

        double taxRate = 0.13;
        double subTotal = 0;
        double taxAmount = 0;
        double totalCost = 0;
        double tendered = 0;
        double change = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calulateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfCupcakes = Convert.ToInt16(cupcakeInput.Text);
                numOfCakes = Convert.ToInt16(cakeInput.Text);
                numOfCookies = Convert.ToInt16(cookieInput.Text);

                subTotal = numOfCupcakes * cupcakeCost + numOfCakes * cakeCost + numOfCookies * cookieCost;
                taxAmount = subTotal * taxRate;
                totalCost = subTotal * taxAmount;

                subtotalOutput.Text = $"{subTotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalCost.ToString("C")}";
            }
            catch
            {
                subtotalOutput.Text = "Error";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            change = tendered - totalCost;
            changeOutput.Text = $"{change.ToString("C")}";
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            reciptDescription.Text
        }
    }
}