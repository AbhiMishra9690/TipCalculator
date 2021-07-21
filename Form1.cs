

/*                                                 Documentation Section
 * 
 * It is a GUI based Tip Calculator that calculates the ^Tip Amount Per person^ and the ^Total Amount Per person^ 
 * needs to pay, according to their total bill amount, Tip Percentage (they want to offer) , and the number of people
 * in which the amount will be split. 
 * 
 *                                             - Coded by Abhishek Mishra.
 *                                             - For Grapecity assignment.
 *                                             
 */


using System;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Bill_Text_TextChanged(object sender, EventArgs e) //Bill amount text box implementation.
        {
            try 
            {
                if (Tip_Percent_Text.Text.EndsWith("%"))   //To handle % symbol in the end of Tip percentage.
                    Tip_Percent_Text.Text = Tip_Percent_Text.Text.Remove(Tip_Percent_Text.Text.Length - 1, 1);

                /*
                 * Calculating Tip per person and storing in variable Tip_Calculate (Data Type - Double)
                 * Formula used: Tip per person = {(tip percentage/100) * Bill amount} / People count
                 */
                Double Tip_Calculate = (((Double.Parse(Tip_Percent_Text.Text) / 100.0) * (Double.Parse(Bill_Text.Text))) /
                                        (Double.Parse(Num_Of_People_Text.Text)));

                
                //Converting the Tip per person result into string type and giving output with a $ symbol in Tip per person text box.
                Tip_Per_Person_Text.Text = "$" + Math.Round(Tip_Calculate, 2).ToString();


                /*
                 * Calculating Total Bill per person and storing in variable Total_Bill (Data Type - Double)
                 * Formula used: Total Bill per person = {(Bill amount) + (tip percentage/100 * Bill amount)} / People count.
                 */
                Double Total_Bill = (((Double.Parse(Bill_Text.Text)) +
                                     ((Double.Parse(Tip_Percent_Text.Text) / 100.0) * (Double.Parse(Bill_Text.Text)))) /
                                     Double.Parse(Num_Of_People_Text.Text));

                /*Converting the Total Bill per person result into string type and giving output with a $ symbol
                in total bill per person text box. */
                Total_Text.Text = "$" + Math.Round(Total_Bill, 2).ToString();

                //Conserving the % symbol of the Tip percentage removed in startng of the block.
                Tip_Percent_Text.Text = Tip_Percent_Text.Text.ToString() + "%";
            }

            catch
            {
               
            }
        }

        private void Tip_Percent_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Calculating Tip per person and storing in variable Tip_Calculate (Data Type - Double)
                 * Formula used: Tip per person = {(tip percentage/100) * Bill amount} / People count
                 */
                Double Tip_Calculate = (((Double.Parse(Tip_Percent_Text.Text) / 100.0) * (Double.Parse(Bill_Text.Text))) /
                                        (Double.Parse(Num_Of_People_Text.Text)));

                //Converting the Tip per person result into string type and giving output with a $ symbol in Tip per person text box.
                Tip_Per_Person_Text.Text = "$" + Math.Round(Tip_Calculate, 2).ToString();

                /*
                 * Calculating Total Bill per person and storing in variable Total_Bill (Data Type - Double)
                 * Formula used: Total Bill per person = {(Bill amount) + (tip percentage/100 * Bill amount)} / People count.
                 */
                Double Total_Bill = (((Double.Parse(Bill_Text.Text)) +
                                     ((Double.Parse(Tip_Percent_Text.Text) / 100.0) * (Double.Parse(Bill_Text.Text))))/
                                     Double.Parse(Num_Of_People_Text.Text));

                /*Converting the Total Bill per person result into string type and giving output with a $ symbol
                in total bill per person text box. */
                Total_Text.Text = "$" + Math.Round(Total_Bill, 2).ToString();
            }

            catch
            {

            }
        }

        private void Num_Of_People_Text_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                if (Tip_Percent_Text.Text.EndsWith("%")) //To handle % symbol in the end of Tip percentage.
                    Tip_Percent_Text.Text = Tip_Percent_Text.Text.Remove(Tip_Percent_Text.Text.Length - 1, 1);


                /*
                * Calculating Tip per person and storing in variable Tip_Calculate (Data Type - Double)
                * Formula used: Tip per person = {(tip percentage/100) * Bill amount} / People count
                */
                Double Tip_Calculate =  (((Double.Parse(Tip_Percent_Text.Text) / 100.0) * (Double.Parse(Bill_Text.Text)))/ 
                                        (Double.Parse(Num_Of_People_Text.Text)));

                //Converting the Tip per person result into string type and giving output with a $ symbol in Tip per person text box.
                Tip_Per_Person_Text.Text = "$" + Math.Round(Tip_Calculate, 2).ToString();

                /*
                 * Calculating Total Bill per person and storing in variable Total_Bill (Data Type - Double)
                 * Formula used: Total Bill per person = {(Bill amount) + (tip percentage/100 * Bill amount)} / People count.
                 */
                Double Total_Bill = (((Double.Parse(Bill_Text.Text)) +
                                     ((Double.Parse(Tip_Percent_Text.Text) / 100.0) * (Double.Parse(Bill_Text.Text)))) /
                                     Double.Parse(Num_Of_People_Text.Text));

                /*Converting the Total Bill per person result into string type and giving output with a $ symbol
                in total bill per person text box. */
                Total_Text.Text = "$" + Math.Round(Total_Bill , 2).ToString();

                //Conserving the % symbol of the Tip percentage removed in startng of the block.
                Tip_Percent_Text.Text = Tip_Percent_Text.Text.ToString() + "%";
            }
            
            catch
            {

            }
        }

        private void Tip_Inc_Button(object sender, EventArgs e) //easy Tip % increment button to increase Tip % by 1 with each click.
        {
            if (Tip_Percent_Text.Text == "" || Tip_Percent_Text.Text == "%")//Managing Tip percent text box if empty or left with % only.
                Tip_Percent_Text.Text = "0%";  //Set the default value to 0%;
            if (Tip_Percent_Text.Text.EndsWith("%")) //Managing % symbol in tip percentage string.
            Tip_Percent_Text.Text = Tip_Percent_Text.Text.Remove(Tip_Percent_Text.Text.Length - 1, 1); //remove % for further calculation.

            Double Tip_Prc = Convert.ToDouble(Tip_Percent_Text.Text); //converting string to double.
            Tip_Prc += 1.0; //increment percentage tip by one for each click.
            Tip_Percent_Text.Text = Convert.ToString(Tip_Prc)+"%"; //Convert the tip % value to string and conserve % symbol.
            
            //Altering and restoring Bill text as % symbol not managed in tip percentage textbox.
            Bill_Text.Text = Bill_Text.Text + " "; 
            Bill_Text.Text = Bill_Text.Text.Remove(Bill_Text.Text.Length - 1, 1);
        }

        private void Tip_Dec_Button(object sender, EventArgs e) //easy Tip % decrement button to decrease Tip % by 1 with each click.
        {
            if (Tip_Percent_Text.Text == "" || Tip_Percent_Text.Text == "%") //Managing Tip percent text box if empty or left with % only.
                Tip_Percent_Text.Text = "0%"; //Set the default value to 0%;
            if (Tip_Percent_Text.Text.EndsWith("%")) //Managing % symbol in tip percentage string.
                Tip_Percent_Text.Text = Tip_Percent_Text.Text.Remove(Tip_Percent_Text.Text.Length - 1,1); //remove % for further calculation.

            Double Tip_Prc = Convert.ToDouble(Tip_Percent_Text.Text); //converting string to double.
            Tip_Prc -= 1.0; //Decrement percentage tip by one for each click.
            if (Tip_Prc <= 0) //Tip % cannot be less than 0.
                Tip_Prc = 0.0;
            Tip_Percent_Text.Text = Convert.ToString(Tip_Prc) + "%"; //Convert the tip % value to string and conserve % symbol.

            //Altering and restoring Bill text as % symbol not managed in tip percentage textbox.
            Bill_Text.Text = Bill_Text.Text + " ";
            Bill_Text.Text = Bill_Text.Text.Remove(Bill_Text.Text.Length - 1, 1);

        }

        private void People_Inc_Button(object sender, EventArgs e) //Easy number of people increment button.
        {
            if (Num_Of_People_Text.Text == "") //managing case if empty box incremented.
                Num_Of_People_Text.Text = "0";
             
            Double People_Count = Convert.ToDouble(Num_Of_People_Text.Text); //converting string to double.
            People_Count += 1.0; //increment people by 1 for each click.
            Num_Of_People_Text.Text = Convert.ToString(People_Count); //Display the incremented value in Number of people textbox.
        }

        private void People_Dec_Button(object sender, EventArgs e) //Easy number of people decrement button.
            {
            if (Num_Of_People_Text.Text == "")   //managing case if empty box decremented.
                Num_Of_People_Text.Text = "1";

            Double People_Count = Convert.ToDouble(Num_Of_People_Text.Text);  //converting string to double.
            People_Count -= 1.0;
            if (People_Count <= 1) //Number of people can never be less than 1.
                People_Count = 1.0;
            Num_Of_People_Text.Text = Convert.ToString(People_Count); //Display the Decremented value in Number of people textbox.
        }

        private void Click_Outside(object sender, EventArgs e)  
        {
            /*Click anywhere over the Application to clear values and set back to default values*/
            Bill_Text.Text = "0.00"; 
            Num_Of_People_Text.Text = "1";
            Tip_Percent_Text.Text = "10%";
        }

        private void Bill_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Handling the keys acceptable in Bill Text box.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                //only digits and .(dot) are accpetable in Bill box text.
                e.Handled = true;
        }

        private void Tip_Percent_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Handling the keys accpetable in Tip percentage Text box.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '%')
                //Only digits, .(dot) and % is acceptable in tip percentage text box.
                e.Handled = true;
        }

        private void Num_Of_People_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Handling the keys accpetable in Number of people Text box.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                //Only digits are acceptable in Number of people text box.
                e.Handled = true;
        }
    }
}
