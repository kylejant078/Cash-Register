using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Cash_Register
{
    public partial class CashRegister : Form
    {
        //Global Variables
        double drinkPrice = 2.39;
        double donutPrice = 1.19;
        double sandwichPrice = 4.29;
        double order;
        double taxRate = 0.13;
        double orderTax;
        double orderTotal;
        double numberDrink;
        double numberDonut;
        double numberSandwich;
        double amountTendered;
        double changeTotal;
        public CashRegister()
        {
            InitializeComponent();
            //SECTION 1
            //Hide labels, buttons and textboxes except for those neccescary in section 1
            labelSubtotal.Visible = false;
            labelTax.Visible = false;
            labelTotal.Visible = false;
            calculateChange.Visible = false;
            labelTendered.Visible = false;
            blackLine.Visible = false;
            labelChange.Visible = false;
            printReciept.Visible = false;
            receipt.Visible = false;
            newOrder.Visible = false;
            tenderedAmount.Visible = false;
            labelError.Visible = false;
            easterEgg.Visible = false;
            chocolateTimbit.Visible = false;
            birthdaycakeTimbit.Visible = false;
            oldfashionedTimbit.Visible = false;
            jellyfilledTimbit.Visible = false;
            labelEasterEgg.Visible = false;
            buttonReturn.Visible = false;
            //initialize variables to 0
            order=0;
            orderTax=0;
            orderTotal=0;
            numberDrink=0;
            numberDonut=0;
            numberSandwich=0;
            amountTendered=0;
            changeTotal=0;
            //Initialize textboxes to 0
            drinksNumber.Text = "0";
            donutsNumber.Text = "0";
            sandwichesNumber.Text = "0";
            tenderedAmount.Text = "0";
        }
        private void calculateTotal_Click(object sender, EventArgs e)
        {
            //SECTION 2
            
            //Play first cashregister sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.registersound);
            player.Play();
            //Make labels, buttons and textboxes in the next section visible
            labelSubtotal.Visible = true;
            labelTax.Visible = true;
            labelTotal.Visible = true;
            blackLine.Visible = true;
            tenderedAmount.Visible = true;
            calculateChange.Visible = true;
            labelTendered.Visible = true;
            //Hide error label that is not yet in use
            labelError.Visible = false;
            //Hide Textboxes so changes cannot be made to the number of items purphased
            drinksNumber.Visible = false;
            donutsNumber.Visible = false;
            sandwichesNumber.Visible = false;
            //Hide Calculate Total so user won't keep listening to the first cashregister sound
            calculateTotal.Visible = false;
            //Set up try to find errors within the textboxes in part 1
            try
            {
                //calculate totals using these variables
                numberDrink = Convert.ToDouble(drinksNumber.Text);
                numberDonut = Convert.ToDouble(donutsNumber.Text);
                numberSandwich = Convert.ToDouble(sandwichesNumber.Text);
            }
            catch
            {
                //display error message if input is not a number
                labelError.Visible = true;
                labelError.Text = "*You must enter an integer*";

                //play error sound that draws their attention to the Error Label at the bottom
                SoundPlayer errorplayer = new SoundPlayer(Properties.Resources.error);
                errorplayer.Play();

                //Reset all values and start from the beginning keeping labels, buttons amd textboxes hidden until the user has used the textboxes from part 1 correctly
                labelSubtotal.Visible = false;
                labelTax.Visible = false;
                labelTotal.Visible = false;
                calculateChange.Visible = false;
                labelTendered.Visible = false;
                blackLine.Visible = false;
                labelChange.Visible = false;
                printReciept.Visible = false;
                receipt.Visible = false;
                newOrder.Visible = false;
                tenderedAmount.Visible = false;
                drinksNumber.Visible = true;
                donutsNumber.Visible = true;
                sandwichesNumber.Visible = true;
                calculateTotal.Visible = true;

                //initialize variables to 0 so new values can be entered in the texboxes
                order = 0;
                orderTax = 0;
                orderTotal = 0;
                numberDrink = 0;
                numberDonut = 0;
                numberSandwich = 0;
                amountTendered = 0;
                changeTotal = 0;

                //initialize textboxes to 0, and labels to their original text
                drinksNumber.Text = "0";
                donutsNumber.Text = "0";
                sandwichesNumber.Text = "0";
                labelSubtotal.Text = "Sub Total";
                labelTax.Text = "Tax";
                labelTotal.Text = "Total";
                tenderedAmount.Text = "0";
                labelChange.Text = "Change";

                return;

            }
            order = (drinkPrice * numberDrink) + (donutPrice * numberDonut) + (sandwichPrice * numberSandwich);
            //if any item is entered as a negative number, then force user to reenter
            if (numberDrink >= 0 && numberDonut >=0 && numberSandwich >=0)
                
            {
                //Show the next part if there are no errors
                labelError.Visible = false;
                labelSubtotal.Visible = true;
                labelTax.Visible = true;
                labelTotal.Visible = true;
                blackLine.Visible = true;
                tenderedAmount.Visible = true;
                calculateChange.Visible = true;
                labelTendered.Visible = true;
                labelSubtotal.Text += $"             {order.ToString("C")}";
                orderTax = taxRate * order;
                labelTax.Text += $"                      {orderTax.ToString("C")}";
                orderTotal = order + orderTax;
                labelTotal.Text += $"                   {orderTotal.ToString("C")}";
            }
            else
            {
                //play error sound, show error message and don't show next part and force user to reenter their input
                SoundPlayer errorplayer = new SoundPlayer(Properties.Resources.error);
                errorplayer.Play();
                labelError.Visible = true;
                labelError.Text = "*You must use positive numbers*";
                labelSubtotal.Visible = false;
                labelTax.Visible = false;
                labelTotal.Visible = false;
                blackLine.Visible = false;
                tenderedAmount.Visible = false;
                calculateChange.Visible = false;
                labelTendered.Visible = false;
                drinksNumber.Visible = true;
                donutsNumber.Visible = true;
                sandwichesNumber.Visible = true;
                calculateTotal.Visible = true;

                drinksNumber.Text = "0";
                donutsNumber.Text = "0";
                sandwichesNumber.Text = "0";
            }
            
        }
        private void calculateChange_Click(object sender, EventArgs e)
        {
            //SECTION 3
            //Display text in part 3 so user can enter how much they paid
            tenderedAmount.Visible = false;
            //Hide Calculate change button so user won't keep listening to the second register sound
            calculateChange.Visible = false;
            //Set up try to find errors within the textbox in part 3
            try
            {
                //Look for error where user uses letters instead of numbers
                amountTendered = Convert.ToDouble(tenderedAmount.Text);
                changeTotal = Math.Round(amountTendered - orderTotal,2); //Rounded this because when change was exactly zero it would cause an error rather than calculate zero change
                labelChange.Text += $"                {changeTotal.ToString("C")}";
            }
            catch
            {
                //If letters instead of text error is caught, then display the error message, along with the error sound.
                //allow the texboxes and button in section 3 to be visible, and set the textboxes back to "0"
                labelError.Visible = true;
                labelError.Text = "*You must enter an integer*";
                tenderedAmount.Text = "0";
                tenderedAmount.Visible = true;
                calculateChange.Visible = true;
                SoundPlayer player = new SoundPlayer(Properties.Resources.error);
                player.Play();
                return;
            }
            if(changeTotal < 0)
            {
                //use if statement to find possible error where not enough money is tendered by the user
                //if the changeTotal is less than 0 then procede with the following actions
                //display error label with message, "*Not enough money tendered*", hide the labels, buttons and textboxes from the 4th part
                //Initialize part 3 texboxes to "0" and labels to their original text
                labelError.Visible = true;
                labelError.Text = "*Not enough money tendered*";
                tenderedAmount.Text = "0";
                tenderedAmount.Visible = true;
                labelChange.Text = "Change";
                labelChange.Visible = false;
                printReciept.Visible = false;
                calculateChange.Visible = true;
                //play error sound
                SoundPlayer errorplayer = new SoundPlayer(Properties.Resources.error);
                errorplayer.Play();
            }
            else 
            {
                //if changeTotal is greater than 0 procede with the following actions
                //Hide error button that is not being used
                labelError.Visible = false;

                //Play 2nd cash register sound
                SoundPlayer player = new SoundPlayer(Properties.Resources.registersound);
                player.Play();

                //Make next section visible to display the user's change and the print receipt button
                labelChange.Visible = true;
                printReciept.Visible = true;
            }
        }
        private void printReciept_Click(object sender, EventArgs e)
        {
            //SECTION 4
            //Play printer sound for the receipt printing
            SoundPlayer player = new SoundPlayer(Properties.Resources.printersound);
            player.Play();
            //Make last section visible for receipt and "new order" button
            receipt.Visible = true;
            newOrder.Visible = true;
            //Hide Print Receipt button so the receipt only prints once and the sound only plays once
            printReciept.Visible = false;
            //start adding the text to the receipt
            //make program refresh and the sleep for 500 milliseconds to match the printer sound between every text entry
            receipt.Text = $"\nTim Hortons";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"\nOrder Number 859\nMay 3, 2021\n";
            Refresh();
            Thread.Sleep(500);
            //dont print drink line if there are no drinks
            if (numberDrink > 0)
            {
                receipt.Text += $"\nDrinks      x{drinksNumber.Text} @2.39      ";
                Refresh();
                Thread.Sleep(500);
            }
            //dont print donut line if ther are no donuts
            if (numberDonut > 0)
            {
                receipt.Text += $"\nDonuts      x{donutsNumber.Text} @1.19      ";
                Refresh();
                Thread.Sleep(500);
            }
            //dont print sandwich line if there are no sandwiches
            if (numberSandwich > 0)
            {
                receipt.Text += $"\nSandwiches  x{sandwichesNumber.Text} @4.29      ";
                Refresh();
                Thread.Sleep(500);
            }
            //dont print sub total line if there is no sub total (empty order)
            if (order > 0)
            {
                receipt.Text += $"\n\nSub Total      {order.ToString("C")}     ";
                Refresh();
                Thread.Sleep(500);
            }
            //dont print tax line if there is no tax (empty order)
            if (orderTax > 0)
            {
                receipt.Text += $"Tax            {orderTax.ToString("C")}     ";
                Refresh();
                Thread.Sleep(500);
            }
            //dont print total if there is no total (empty order)
            if (orderTotal > 0)
            {
                receipt.Text += $"Total          {orderTotal.ToString("C")}     ";
                Refresh();
                Thread.Sleep(500);
            }
            //dont print amount tedered if there is no money tendered (empty order)
            if (amountTendered > 0)
            {
                receipt.Text += $"\n\nTendered       {amountTendered.ToString("C")}     ";
                Refresh();
                Thread.Sleep(500);
            }
            //dont print change amount if there is no change (empty order)
            if (changeTotal > 0)
            {
                receipt.Text += $"\nChange         {changeTotal.ToString("C")}     ";
                Refresh();
                Thread.Sleep(500);
            }
            receipt.Text += $"\n\nThank you for choosing Tim Hortons!";
        }
        private void newOrder_Click(object sender, EventArgs e)
        {
            //Play bell sound for "new order"
            SoundPlayer player = new SoundPlayer(Properties.Resources.bellsound);
            player.Play();
            //Reset all labels, buttons and textboxes to false for Visibility and only display the ones needed in section 1
            labelSubtotal.Visible = false;
            labelTax.Visible = false;
            labelTotal.Visible = false;
            calculateChange.Visible = false;
            labelTendered.Visible = false;
            blackLine.Visible = false;
            labelChange.Visible = false;
            printReciept.Visible = false;
            receipt.Visible = false;
            newOrder.Visible = false;
            tenderedAmount.Visible = false;
            calculateTotal.Visible = true;
            drinksNumber.Visible = true;
            donutsNumber.Visible = true;
            sandwichesNumber.Visible = true;
            //initialize variables to 0 so data from the last order is no longer associated with its respective variable
            order = 0;
            orderTax = 0;
            orderTotal = 0;
            numberDrink = 0;
            numberDonut = 0;
            numberSandwich = 0;
            amountTendered = 0;
            changeTotal = 0;
            //initialize textboxes from section 1 to "0" and labels to their original text
            drinksNumber.Text = "0";
            donutsNumber.Text = "0";
            sandwichesNumber.Text = "0";
            labelSubtotal.Text = "Sub Total";
            labelTax.Text = "Tax";
            labelTotal.Text = "Total";
            tenderedAmount.Text = "0";
            labelChange.Text = "Change";
        }
        private void buttonTimbits_Click(object sender, EventArgs e)
        {
            //This is the hidden easter egg***
            //Clear all labels, buttons and textboxes by changing the visibility property to false
            labelSubtotal.Visible = false;
            labelTax.Visible = false;
            labelTotal.Visible = false;
            calculateChange.Visible = false;
            labelTendered.Visible = false;
            blackLine.Visible = false;
            labelChange.Visible = false;
            printReciept.Visible = false;
            receipt.Visible = false;
            newOrder.Visible = false;
            tenderedAmount.Visible = false;
            labelError.Visible = false;
            labelCoffee.Visible = false;
            labelDonuts.Visible = false;
            labelSandwich.Visible = false;
            drinksNumber.Visible = false;
            donutsNumber.Visible = false;
            sandwichesNumber.Visible = false;
            calculateTotal.Visible = false;
            //Still include picture boxes, title label, buttonDrink and buttonTimbits (visible property = true)
            easterEgg.Visible = true;
            chocolateTimbit.Visible = true;
            birthdaycakeTimbit.Visible = true;
            oldfashionedTimbit.Visible = true;
            jellyfilledTimbit.Visible = true;
            labelEasterEgg.Visible = true;
            buttonReturn.Visible = true;
        }
        private void chocolateTimbit_Click(object sender, EventArgs e)
        {
            //Have label display text for this button
            labelEasterEgg.Text = "Ah yes! What a wonderful flavour";
        }
        private void birthdaycakeTimbit_Click(object sender, EventArgs e)
        {
            //Have label display text for this button
            labelEasterEgg.Text = "Timbits that are full of fun and cheer!";
        }
        private void jellyfilledTimbit_Click(object sender, EventArgs e)
        {
            //Have label display text for this button
            labelEasterEgg.Text = "A Canadian winter isn't the only good powder here";
        }
        private void oldfashionedTimbit_Click(object sender, EventArgs e)
        {
            //Have label display text for this button
            labelEasterEgg.Text = "I'm sorry, but how do you like these?";
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //Return to the original settings at the beginning
            //Make labels, buttons and textboxes hiden except for the ones needed in section 1
            labelCoffee.Visible = true;
            labelDonuts.Visible = true;
            labelSandwich.Visible = true;
            drinksNumber.Visible = true;
            donutsNumber.Visible = true;
            sandwichesNumber.Visible = true;
            calculateTotal.Visible = true;
            easterEgg.Visible = false;
            labelSubtotal.Visible = false;
            labelTax.Visible = false;
            labelTotal.Visible = false;
            calculateChange.Visible = false;
            labelTendered.Visible = false;
            blackLine.Visible = false;
            labelChange.Visible = false;
            printReciept.Visible = false;
            receipt.Visible = false;
            newOrder.Visible = false;
            tenderedAmount.Visible = false;
            chocolateTimbit.Visible = false;
            birthdaycakeTimbit.Visible = false;
            oldfashionedTimbit.Visible = false;
            jellyfilledTimbit.Visible = false;
            labelEasterEgg.Visible = false;
            buttonReturn.Visible = false;
            //Reset all labels, buttons and textboxes to false for Visibility and only display the ones needed in section 1
            labelSubtotal.Visible = false;
            labelTax.Visible = false;
            labelTotal.Visible = false;
            calculateChange.Visible = false;
            labelTendered.Visible = false;
            blackLine.Visible = false;
            labelChange.Visible = false;
            printReciept.Visible = false;
            receipt.Visible = false;
            newOrder.Visible = false;
            tenderedAmount.Visible = false;
            calculateTotal.Visible = true;
            drinksNumber.Visible = true;
            donutsNumber.Visible = true;
            sandwichesNumber.Visible = true;
            //Reset easter egg label to null so any previous data can be overwriten by the user
            labelEasterEgg.Text = "";
            //initialize variables to 0 so data from the last order is no longer associated with its respective variable
            order = 0;
            orderTax = 0;
            orderTotal = 0;
            numberDrink = 0;
            numberDonut = 0;
            numberSandwich = 0;
            amountTendered = 0;
            changeTotal = 0;
            //initialize textboxes from section 1 to "0" and labels to their original text
            drinksNumber.Text = "0";
            donutsNumber.Text = "0";
            sandwichesNumber.Text = "0";
            labelSubtotal.Text = "Sub Total";
            labelTax.Text = "Tax";
            labelTotal.Text = "Total";
            tenderedAmount.Text = "0";
            labelChange.Text = "Change";
            labelEasterEgg.Text = "";
        }
    }
}
