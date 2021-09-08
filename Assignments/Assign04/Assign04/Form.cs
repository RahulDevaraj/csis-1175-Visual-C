using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign04
{
    public partial class Form : System.Windows.Forms.Form
    {
        private double total = 0.0;             //display price varible
        

        const double ADULT = 78.00;
        const double TEEN = 69.00;
        const double CHILD = 40.00;
        const double TOT = 0.00;
        public  int[] QuantityArray { get; set; }   //Array to know quantity of each item
        public Form()
        {
            InitializeComponent();
        }

        public void initArray()         //Initialise the Array
        {
            QuantityArray = new int[4];
            for (int i = 0; i < 4; i++)
                QuantityArray[i] = 0;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            cmbTickets.SelectedIndex = 0;       //Default Ticket value
            cmbQuantity.SelectedIndex = 1;      //Default Quantity value

            initArray();
            lblTotal.Text = String.Format("Total: ${0:F2}", total);     //Display Total


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")  //if No name is given
            {
                MessageBox.Show("Please enter your name.","Warning");
            }
            else if(txtBoxCart.Text.Split('\n').Length - 1 ==0) //if no tickets Added
            {
                MessageBox.Show("Please add tickets to your cart.", "Warning");
            }

            else
            {

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult results;

                results = MessageBox.Show("Hi "+ txtName.Text +",\nConfirm the order?", "Order confirmation", buttons);
                if (results == DialogResult.Yes)
                {
                    MessageBox.Show("Thank you for your order!","Order confirmed.");
                    Close();
                }
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ticketIndex = cmbTickets.SelectedIndex;
            int quantityIndex = cmbQuantity.SelectedIndex;
            double tempTotal = 0.0;
            string msg = "";

            if(quantityIndex>0)     //Adding tickets
            {
                Boolean change = false;
                if(ticketIndex==0 && QuantityArray[ticketIndex] == 0)
                {
                    tempTotal = ADULT * quantityIndex ;
                    msg = String.Format("Adult(19-64) x {0}: ${1:F2}\n",quantityIndex,tempTotal);
                    txtBoxCart.AppendText(msg);
                    change = true;
                }
                else if(ticketIndex == 1 && QuantityArray[ticketIndex] == 0)
                {
                    tempTotal = TEEN * quantityIndex;
                    msg = String.Format("Teen/Senior(13-18 & 65+) x {0}: ${1:F2}\n", quantityIndex, tempTotal);
                    txtBoxCart.AppendText(msg);
                    change = true;
                }
                else if (ticketIndex == 2 && QuantityArray[ticketIndex] == 0)
                {
                    tempTotal = CHILD * quantityIndex;
                    msg = String.Format("Child(7-12) x {0}: ${1:F2}\n", quantityIndex, tempTotal);
                    txtBoxCart.AppendText(msg);
                    change = true;
                }
                else if (ticketIndex == 3 && QuantityArray[ticketIndex] == 0)
                {
                    tempTotal = TOT * quantityIndex;
                    msg = String.Format("Tot(3-6) x {0}: ${1:F2}\n", quantityIndex, tempTotal);
                    txtBoxCart.AppendText(msg);
                    change = true;
                }
                if(change==true)    //Change quantity  Array value
                QuantityArray[ticketIndex] = quantityIndex;
            }
            else if(quantityIndex == 0 && QuantityArray[ticketIndex]!=0)        //Condition for deletion
            {
                         
                    tempTotal = DeleteValues(ticketIndex);      //Price change
                    QuantityArray[ticketIndex] = 0;             //Deletion in quantity Array
                    DeleteText(ticketIndex);                    //Deletion from Cart                            
                    
            }

            total += tempTotal * 1.12;
            lblTotal.Text = String.Format("Total: ${0:F2}", total);

            
            

        }
        private double DeleteValues(int index)          //Function for Deletion price updation
        {
            double toSubstract = -1.0;
            if (index == 0)
                toSubstract *= ADULT;
            else if (index == 1)
                toSubstract *= TEEN;
            else if (index == 2)
                toSubstract *= CHILD;
            else if (index == 3)
                toSubstract *= TOT;
            

            return toSubstract*QuantityArray[index];
        }

        private void DeleteText(int index)              //Function for Cart text deletion
        {
            String[] temp = txtBoxCart.Text.Split('\n');
            String newCart = "";
            string compare = "";
            if (index == 0)
                compare = "Adu";
            else if (index == 1)
                compare = "Tee";
            else if (index == 2)
                compare = "Chi";
            else if (index == 3)
                compare = "Tot";


            for(int i=0;i<temp.Length -1;i++)
            {
                if(compare != temp[i].Substring(0,3))
                {
                    newCart += (temp[i]+"\n");
                }
            }

            txtBoxCart.Text = newCart;


        }
    }
}
