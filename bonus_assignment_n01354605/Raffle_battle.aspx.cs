using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonus_assignment_n01354605
{
    public partial class Raffle_battle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {   //convert input into integer
                    int number_of_tickets = Convert.ToInt32( number_of_tickets_booked.Text);

                    raffle_battle_summary.InnerHtml += "Input:<br>";
                    raffle_battle_summary.InnerHtml += "Number of tickets ordered: " + number_of_tickets + "<br>";
                    raffle_battle_summary.InnerHtml += "Output";
                    //condition for tickets less than or equal to 50
                    if (number_of_tickets <= 50)
                    {
                        for (int i = 1; i<=number_of_tickets;i++)
                        {
                            raffle_battle_summary.InnerHtml += "You recived a bundle of 1! That's " + i + "ticket(s)!<br>";
                        }
                        //calculate total cost
                        double total_cost = (0.25 * float.Parse(number_of_tickets.ToString()));
                        raffle_battle_summary.InnerHtml += "Your total ticket(s) is " + number_of_tickets + " and your cost is $ " + total_cost + "<br>"; 
                    }
                    //condition for tickets between 51 and 150
                    else if (number_of_tickets >= 51 && number_of_tickets <= 150)
                    {
                        //calculate remaining tickets
                        int a = number_of_tickets % 2;
                        for (int i = 2; i <= number_of_tickets; i+=2)
                        {
                            raffle_battle_summary.InnerHtml += "You received a bundle of 2! That's " + i+ "tickets(s)<br>";

                        }
                        //loop for remaining tickets
                        if (a != 0)
                        {
                            raffle_battle_summary.InnerHtml += "Your left over is 1ticket(s). That's " + number_of_tickets + "ticket(s)<br>";
                        }
                        //calculate total cost
                        double total_cost = (0.25 * float.Parse(number_of_tickets.ToString()));
                        raffle_battle_summary.InnerHtml += "Your total ticket(s) is " + number_of_tickets + " and your cost is $ " + total_cost + "<br>";
                    }
                    //condition for tickets between 151 and 300
                    else if (number_of_tickets >= 151 && number_of_tickets <= 300)
                    {
                        //calculate remaining tickets
                        int b = number_of_tickets % 3;
                        for (int i = 3; i<= number_of_tickets;i+=3)
                        {
                            raffle_battle_summary.InnerHtml += "You received a bundle of 3! That's " + i + " ticket(s)<br>";
                        }
                        //loop for remaining tickets
                        if (b!=0)
                        {
                            for (int j = b-1; j >= 0; j--)
                            {
                                raffle_battle_summary.InnerHtml += "You received a bundle of 1! That's " + (number_of_tickets - j) + " ticket(s)<br>";
                            }
                        }
                        //calculate total cost
                        double total_cost = (0.25 * float.Parse(number_of_tickets.ToString()));
                        raffle_battle_summary.InnerHtml += "Your total ticket(s) is " + number_of_tickets + " and your cost is $ " + total_cost + "<br>";
                    }
                    //condition for tickets more than or equal to 301
                    else
                    {
                        //calculate remaining tickets
                        int c = number_of_tickets % 5;
                        for (int i = 5; i <= number_of_tickets; i += 5)
                        {
                            raffle_battle_summary.InnerHtml += "You recieved a bundle of 5! That's " + i + " ticket(s)<br>";
                        }
                        //loop for remaining tickets
                        if (c != 0)
                        {
                            for (int j = c-1; j>=0;j--)
                            {
                                raffle_battle_summary.InnerHtml += "You received a bundle of 1! That's " + (number_of_tickets - j) + "ticket(s)<br>";
                            }
                        }
                        //calculate total cost
                        double total_cost = (0.25 * float.Parse(number_of_tickets.ToString()));
                        raffle_battle_summary.InnerHtml += "Your total ticket(s) is " + number_of_tickets + " and your cost is $ " + total_cost + "<br>";

                    }
                }
            }
        }

    }
}