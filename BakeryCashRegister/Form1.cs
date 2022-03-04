using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

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

            calulateTotalButton.Enabled = true;
            changeButton.Enabled = false;
            reciptButton.Enabled = false;
            newOrderButton.Enabled = false;
        }

        private void calulateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                //number of items
                numOfCupcakes = Convert.ToInt16(cupcakeInput.Text);
                numOfCakes = Convert.ToInt16(cakeInput.Text);
                numOfCookies = Convert.ToInt16(cookieInput.Text);

                //subtotal, tax amount, total cost
                subTotal = numOfCupcakes * cupcakeCost + numOfCakes * cakeCost + numOfCookies * cookieCost;
                taxAmount = subTotal * taxRate;
                totalCost = subTotal + taxAmount;

                //outputs
                subtotalOutput.Text = $"{subTotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalCost.ToString("C")}";

                calulateTotalButton.Enabled = false;
                changeButton.Enabled = true;
                reciptButton.Enabled = false;
                newOrderButton.Enabled = false;
            }
            catch
            {
                //if letter as input
                subtotalOutput.Text = "Error";
                taxOutput.Text = "";
                totalOutput.Text = "";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
           //tendered and change
            tendered = Convert.ToInt16(tenderedInput.Text);
            
            change = tendered - totalCost;
            changeOutput.Text = $"{change.ToString("C")}";

            calulateTotalButton.Enabled = false;
            changeButton.Enabled = false;
            reciptButton.Enabled = true;
            newOrderButton.Enabled = false;
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            //recipt printing
            reciptDescription.Text = "Cookies n' Cakes";
            Thread.Sleep(900);
            Refresh();

            reciptDescription.Text += "\nOrder number 45";
            Thread.Sleep(900);
            Refresh();
            reciptDescription.Text += "\n\nMarch 1, 2022";
            Thread.Sleep(900);
            Refresh();

            reciptDescription.Text += $"\n\nCupcakes x{numOfCupcakes} @ {cupcakeCost.ToString ("C")}";
            Thread.Sleep(900);
            Refresh();
            reciptDescription.Text += $"\nCakes x{numOfCakes} @ {cakeCost.ToString("C")}";
            Thread.Sleep(900);
            Refresh();
            reciptDescription.Text += $"\nCookies x{numOfCookies} @ {cookieCost.ToString("C")}";
            Thread.Sleep(900);
            Refresh();

            reciptDescription.Text += $"\n\nSubtotal {subTotal.ToString("C")}";
            Thread.Sleep(900);
            Refresh();
            reciptDescription.Text += $"\nTax {taxAmount.ToString("C")}";
            Thread.Sleep(900);
            Refresh();
            reciptDescription.Text += $"\nTotal {totalCost.ToString("C")}";
            Thread.Sleep(900);
            Refresh();

            reciptDescription.Text += $"\n\nTendered {tendered.ToString("C")}";
            Thread.Sleep(900);
            Refresh();
            reciptDescription.Text += $"\nChange {change.ToString("C")}";
            Thread.Sleep(900);
            Refresh();

            reciptDescription.Text += "\n\nHave a nice day!!";
            Thread.Sleep(900);
            Refresh();

            calulateTotalButton.Enabled = false;
            changeButton.Enabled = false;
            reciptButton.Enabled = false;
            newOrderButton.Enabled = true;
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //creating new order
            numOfCupcakes = 0;
            numOfCakes = 0;
            numOfCookies = 0;

            taxRate = 0.13;
            subTotal = 0;
            taxAmount = 0;
            totalCost = 0;
            tendered = 0;
            change = 0;

            cupcakeInput.Text = "";
            cakeInput.Text = "";
            cookieInput.Text = "";

            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Text = "";

            changeOutput.Text = "";
            reciptDescription.Text = "";

            calulateTotalButton.Enabled = false;
            changeButton.Enabled = false;
            reciptButton.Enabled = false;
            newOrderButton.Enabled = true;

            calulateTotalButton.Enabled = true;
            changeButton.Enabled = false;
            reciptButton.Enabled = false;
            newOrderButton.Enabled = false;
        }
    }
}