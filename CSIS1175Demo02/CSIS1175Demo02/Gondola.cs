using static System.Console;
using System;

namespace CSIS1175Demo02
{
    class Gondola
    {
        static void Main(string[] args)
        {
            string userName;       //Variable for storing UserName
            int ticketsAdult,ticketsTeen,ticketsChild,ticketsTot,totalTickets;    //Variables for storing number of tickets
            double totalAmount,finalAmount;   //Variables for calculation and storage of the Amount

            WriteLine("Welcome to ABC Gondola Ordering System");
            Write("May I have your name? ");
            userName = ReadLine();      //Getting the Customer Name
            WriteLine("Hello, " + userName + "! We offer the following tickets:");

            // Printing the Ticket Prices for reference
            WriteLine("****************************************************************************");
            WriteLine("* Type  | Adult(19-64) | Teen/Senior(13-18 & 65+) | Child(7-12) | Tot(3-6) *");
            WriteLine("* ------|--------------|--------------------------|-------------|--------- *");
            WriteLine("* Price | $78          | $69                      | $40         | Free     *");
            WriteLine("****************************************************************************");

            Write("How many Adult tickets do you want? ");
            ticketsAdult = int.Parse(ReadLine());  //Getting the input for number of Adult Tickets needed
            Write("How many Teen/Senior tickets do you want? ");
            ticketsTeen = int.Parse(ReadLine());   //Getting the input for number of Teen/Senior Tickets needed
            Write("How many Child tickets do you want? ");
            ticketsChild = int.Parse(ReadLine());  //Getting the input for number of Child Tickets needed
            Write("How many Tot tickets do you want? ");
            ticketsTot = int.Parse(ReadLine());    //Getting the input for number of Toddler Tickets needed

            totalTickets = ticketsAdult + ticketsChild + ticketsTeen + ticketsTot;   //Calculate the total number of tickets
            WriteLine("Thank you for the purchase. Here is the summary:");
            WriteLine("Customer: " + userName);
            WriteLine("Number of tickets: " + totalTickets);

            totalAmount = (78 * ticketsAdult + 69 * ticketsTeen + 40 * ticketsChild);  //Amount calcualtion without tax
            finalAmount = totalAmount + totalAmount * .12;   //Final payable amount including 12% Tax
            WriteLine("Total price (incl. 12% tax): ${0:0.##}" , finalAmount);

            ReadKey();
        }
    }
}
