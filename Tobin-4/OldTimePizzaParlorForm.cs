/* Project:     Assignment 4
 * Programmer:  Chris Tobin
 * Due Date:    4.23.2010
 * Description: A program to record the call in orders of customers for old time pizza parlor 
 *
 * Class:       Order Form
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tobin_4
{
    public partial class OldTimePizzaParlorForm : Form
    {   
        // Declare price structure
        struct Price
        {
            public string nameString;
            public string valueDecimal;
        }
        
        // Declare price array
        Price[] pizzaPrice = new Price[10];
        
        // Declare class-level variables
        decimal totalDecimal = 0;
        decimal pizzaPriceDecimal = 0;
        decimal pizzaSizePriceDecimal = 0;
        decimal toppingsPriceDecimal = 0;
        decimal taxDecimal;
        decimal summaryPizzaPriceDecimal, summarySalesTaxDecimal,
            summaryOrderPriceDecimal, smallDecimal, mediumDecimal, 
            largeDecimal, toppingsDecimal;
        int numberOfToppingsInteger;
        string summaryPizzaPriceString, summarySalesTaxString,
            summaryOrderPriceString, smallString, mediumString,
            largeString, toppingsPriceString;
        string nameString = "";
        string phoneString = "";
        string sizeString = "";
        string crustString = "";
        string toppingsString = "";

        public OldTimePizzaParlorForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the about form
            AboutBox1 aAboutForm = new AboutBox1();
            aAboutForm.ShowDialog();
        }

        private void OldTimePizzaParlorForm_Load(object sender, EventArgs e)
        {
            int indexInteger = 0;

            try
            {
                // Read the pizza prices in from an external file
                StreamReader sizeStreamReader = new StreamReader("Prices.txt");
                while (sizeStreamReader.Peek() != -1)
                {
                    pizzaPrice[indexInteger].nameString = (sizeStreamReader.ReadLine());
                    pizzaPrice[indexInteger].valueDecimal = (sizeStreamReader.ReadLine());
                    indexInteger++;
                }
                sizeStreamReader.Close();
            }
            catch
            {
                // Handle a missing file
                MessageBox.Show("File not found.", "File not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Display names of sizes
            smallRadioButton.Text = pizzaPrice[0].nameString;
            mediumRadioButton.Text = pizzaPrice[1].nameString;
            largeRadioButton.Text = pizzaPrice[2].nameString;

            // Display small pizza price in currency
            smallDecimal = decimal.Parse(pizzaPrice[0].valueDecimal);
            smallString = smallDecimal.ToString("C");
            smallPizzaPriceLabel.Text = smallString;

            // Display medium pizza price in currency
            mediumDecimal = decimal.Parse(pizzaPrice[1].valueDecimal);
            mediumString = mediumDecimal.ToString("C");
            mediumPizzaPriceLabel.Text = mediumString;

            // Display large pizza price in currency
            largeDecimal = decimal.Parse(pizzaPrice[2].valueDecimal);
            largeString = largeDecimal.ToString("C");
            largePizzaPriceLabel.Text = largeString;
            
            // Display price per topping in currency
            toppingsDecimal = decimal.Parse(pizzaPrice[3].valueDecimal);
            toppingsPriceString = toppingsDecimal.ToString("C") + " each";
            toppingsPriceLabel.Text = toppingsPriceString;

            
            try
            {
                // Read in the pizza crusts from an external file
                StreamReader crustsStreamReader = new StreamReader("Crusts.txt");
                while (crustsStreamReader.Peek() != -1)
                {
                    pizzaCrustComboBox.Items.Add(crustsStreamReader.ReadLine());
                }
                crustsStreamReader.Close();
            }
            catch
            {
                // Handle a missing file
                MessageBox.Show("File not found.", "File not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            try
            {
                // Read in the pizza toppings from an external file
                StreamReader toppingsStreamReader = new StreamReader("Toppings.txt");
                while (toppingsStreamReader.Peek() != -1)
                {
                    toppingsListBox.Items.Add(toppingsStreamReader.ReadLine());
                }
                toppingsStreamReader.Close();
            }
            catch
            {
                // Handle a missing file
                MessageBox.Show("File not found.", "File not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Set form defaults
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyy");
            pickUpRadioButton.Checked = true;
            mediumRadioButton.Checked = true;
            pizzaCrustComboBox.SelectedItem = "Regular";
        }

        private void toppingsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // Run the calculate price method whenever the toppings are changed
            CalculatePrice();
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Run the calculate price method whenever the pizza size is changed
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            // Determine which pizza size was selected and assign the correct price to the 
            // pizza size price decimal
            if (smallRadioButton.Checked)
            {
                pizzaSizePriceDecimal = decimal.Parse(pizzaPrice[0].valueDecimal);
            }
            if (mediumRadioButton.Checked)
            {
                pizzaSizePriceDecimal = decimal.Parse(pizzaPrice[1].valueDecimal);
            }
            if (largeRadioButton.Checked)
            {
                pizzaSizePriceDecimal = decimal.Parse(pizzaPrice[2].valueDecimal);
            }
            
            // Determine the sales tax and the order price based on the pizza size and the 
            // number of toppings selected
            pizzaPriceDecimal = pizzaSizePriceDecimal + toppingsPriceDecimal;
            pizzaPriceLabel.Text = pizzaPriceDecimal.ToString("C");
            taxDecimal = decimal.Parse(pizzaPrice[4].valueDecimal) * pizzaPriceDecimal;
            salesTaxLabel.Text = taxDecimal.ToString("C");
            totalDecimal = taxDecimal + pizzaPriceDecimal;
            orderPriceLabel.Text = totalDecimal.ToString("C");

            
            
            // Set variable to 0 determine number of toppings selected
            numberOfToppingsInteger = 0;
            // Loop to determine how many toppings are selected
            for (int countInteger = 0; countInteger < toppingsListBox.Items.Count;
                    countInteger++)
            {
                if (toppingsListBox.GetSelected(countInteger))
                {
                    numberOfToppingsInteger++;
                    toppingsPriceDecimal = decimal.Parse(pizzaPrice[3].valueDecimal)
                        * numberOfToppingsInteger;                       
                }
            }
                
            // Calculate and display the pizza price for the order
            pizzaPriceDecimal = pizzaSizePriceDecimal + toppingsPriceDecimal;
            pizzaPriceLabel.Text = pizzaPriceDecimal.ToString("C");
            
            if (toppingsListBox.SelectedIndex == -1)
            {
                // Calculate and display the pizza price if no toppings are selected
                pizzaPriceDecimal = pizzaSizePriceDecimal;
                pizzaPriceLabel.Text = pizzaPriceDecimal.ToString("C");
            }
            

            // Calculate and display the sales tax for the order
            taxDecimal = decimal.Parse(pizzaPrice[4].valueDecimal) * pizzaPriceDecimal;
            salesTaxLabel.Text = taxDecimal.ToString("C");
            
            
            // Calculate and display the order total
            totalDecimal = taxDecimal + pizzaPriceDecimal;
            orderPriceLabel.Text = totalDecimal.ToString("C");
            
        }

        private void printReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the print preview dialog box
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Bring together the first name and last name for printing purposes
            nameString = firstNameTextBox.Text + " " + lastNameTextBox.Text;
            
            // Set the phonestring variable
            phoneString = phoneNumberMaskedTextBox.Text;
            
            // Determine which pizza size was selected
            if (smallRadioButton.Checked)
            {
                sizeString = "Small";
            }
            else if (mediumRadioButton.Checked)
            {
                sizeString = "Medium";
            }
            else if (largeRadioButton.Checked)
            {
                sizeString = "Large";
            }
            
            // Determine which crust was selected
            crustString = pizzaCrustComboBox.Text;

            // Loop to determine the toppings selected
            for (int countInteger = 0; countInteger < toppingsListBox.Items.Count; countInteger++)
            {
                if (toppingsListBox.GetSelected(countInteger))
                {
                    toppingsString = toppingsString +
                        toppingsListBox.Items[countInteger].ToString() + "\n";
                }
            }

            // Set the printing properties
            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float verticalPrintPositionFloat = e.MarginBounds.Top;
            float horizontalPrintPositionFloat = e.MarginBounds.Left;
            float lineHeightfloat = printFont.GetHeight();
            string printLineString;

            // Display the heading
            printLineString = "Old Time Pizza Parlor-Order Receipt";
            e.Graphics.DrawString(printLineString, headingFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display the order date
            printLineString = dateMaskedTextBox.Text;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat * 2;

            // Display the customer's name
            printLineString = "Customer Name: " + nameString;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display the phone number for the order
            printLineString = "Phone Number: " + phoneString;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display the pizza size for the order
            printLineString = "Pizza Size: " + sizeString;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display the pizza crust for the order 
            printLineString = "Pizza Crust: " + crustString;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display "Pizza Toppings"
            printLineString = "Pizza Toppings: ";
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Determine if toppings were selected
            if (toppingsString != "")
            {
                // Loop to display the toppings on different lines
                for (int countInteger = 0; countInteger < toppingsListBox.Items.Count;
                    countInteger++)
                {
                    if (toppingsListBox.GetSelected(countInteger))
                    {
                        toppingsString = toppingsListBox.Items[countInteger].ToString();
                        printLineString = toppingsString;
                        e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                            150, verticalPrintPositionFloat);
                        verticalPrintPositionFloat += lineHeightfloat;
                        toppingsString = "";
                    }
                }
            }
            else
            {
                // Display "None Selected" if user does not want toppings
                printLineString = "None Selected";
                e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                    150, verticalPrintPositionFloat);
                verticalPrintPositionFloat += lineHeightfloat;
            }
            
            // Display the pizza price for the order 
            printLineString = "Pizza Price: " + pizzaPriceLabel.Text;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display the sales tax for the order 
            printLineString = "Sales Tax: " + salesTaxLabel.Text;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;

            // Display the total for the order 
            printLineString = "Order Total: " + orderPriceLabel.Text;
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black,
                horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += lineHeightfloat;
        }

        private void saveOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Write the orders to an external file
            StreamWriter orderStreamWriter = new StreamWriter("Order Summaries.txt", true);
            
            // Determine which size was selected
            if (smallRadioButton.Checked)
            {
                sizeString = "Small";
            }
            else if (mediumRadioButton.Checked)
            {
                sizeString = "Medium";
            }
            else if (largeRadioButton.Checked)
            {
                sizeString = "Large";
            }
            
            // Send the values to the external file
            orderStreamWriter.WriteLine(firstNameTextBox.Text + " " + lastNameTextBox.Text);
            orderStreamWriter.WriteLine(phoneNumberMaskedTextBox.Text);
            orderStreamWriter.WriteLine(sizeString);
            orderStreamWriter.WriteLine(pizzaCrustComboBox.Text);

            // Loop to display each topping on a different line
            for (int countInteger = 0; countInteger < toppingsListBox.Items.Count;
                countInteger++)
            {
                if (toppingsListBox.GetSelected(countInteger))
                {
                    orderStreamWriter.WriteLine(toppingsListBox.Items[countInteger]);
                }
            }
            orderStreamWriter.WriteLine(pizzaPriceLabel.Text);
            orderStreamWriter.WriteLine(salesTaxLabel.Text);
            orderStreamWriter.WriteLine(orderPriceLabel.Text);
            orderStreamWriter.WriteLine();
            
            // Close the streamwriter
            orderStreamWriter.Close();

            // Send the order values to the sales summary figures  
            summaryPizzaPriceDecimal += pizzaPriceDecimal;
            summaryPizzaPriceString = summaryPizzaPriceDecimal.ToString("C");
            summarySalesTaxDecimal += taxDecimal;
            summarySalesTaxString = summarySalesTaxDecimal.ToString("C");
            summaryOrderPriceDecimal += totalDecimal;
            summaryOrderPriceString = summaryOrderPriceDecimal.ToString("C");

            // Reset the form to the default layout
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneNumberMaskedTextBox.Text = "";
            pickUpRadioButton.Checked = true;
            mediumRadioButton.Checked = true;
            pizzaCrustComboBox.Text = "Regular";
            toppingsListBox.SelectedIndex = -1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display a message box to make sure the user wanted to close
            DialogResult responseDialogResult;
            responseDialogResult = MessageBox.Show("Are you sure you wish to exit the program?", "Exit?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (responseDialogResult == DialogResult.Yes)
            {
                // End the program
                this.Close();
            } 
        }

        private void displaySalesSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the order summary values
            string messageString = "";
            messageString = "Total Pizza Price:       " + summaryPizzaPriceString + "\n" +
                "Total Sales Tax:           " + summarySalesTaxString + "\n" +
                "Total Order Price:     " + summaryOrderPriceString;
            MessageBox.Show(messageString, "Order Summaries", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
        }

        private void clearSalesSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Be sure the user wanted to clear the sales summary figures
            DialogResult responseDialogResult;
            responseDialogResult = MessageBox.Show("Are you sure you wish to clear the sales summary?", 
                "Clear sales summary?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (responseDialogResult == DialogResult.Yes)
            {
                // End the program
                summaryPizzaPriceString = "";
                summaryPizzaPriceDecimal = 0;
                summarySalesTaxString = "";
                summarySalesTaxDecimal = 0;
                summaryOrderPriceString = "";
                summaryOrderPriceDecimal = 0;
            }         
        }
    }
}
