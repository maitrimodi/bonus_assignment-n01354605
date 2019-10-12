using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonus_assignment_n01354605
{
    public partial class Weekly_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //list of all days initialized to boolean value false
                    List<Boolean> working_days_of_week = new List<Boolean>();
                    working_days_of_week.Add(false);
                    working_days_of_week.Add(false);
                    working_days_of_week.Add(false);
                    working_days_of_week.Add(false);
                    working_days_of_week.Add(false);
                    working_days_of_week.Add(false);
                    working_days_of_week.Add(false);

                    // foreach loop for every items of the checkbox
                    foreach (ListItem user_work_day in user_work_days.Items)
                    {
                        //converting values into integer and subtracting it by 1 as index starts from 0
                        int day_index = Convert.ToInt32(user_work_day.Value) -1;
                        //set which days user has selected
                        working_days_of_week[day_index] = user_work_day.Selected;

                    }
                    // for loop for days of month
                    for (int i = 1; i <= 31; i++)
                    {
                        // for loop for days 
                        for (int j = 0; j < 7; j++)
                        {   
                            if (i <= 31)
                            {   //for 1st iteration it will skip 1st index as 1st day of month is Tuesday
                                if (i == 1)
                                {
                                    j++;
                                }

                                //switch case for all days                               
                                switch (j)
                                {
                                    // if user selects Monday 
                                    case 0:
                                        set_HTML(working_days_of_week, j, i, "Monday");
                                        break;
                                    
                                    //if user selects Tuesday
                                    case 1:
                                        set_HTML(working_days_of_week, j, i, "Tuesday");
                                        break;

                                    //if user selects Wedesday
                                    case 2:
                                        set_HTML(working_days_of_week, j, i, "Wednesday");
                                        break;

                                    //if user selects Thursday
                                    case 3:
                                        set_HTML(working_days_of_week, j, i, "Thursday");
                                        break;

                                    //if user selects Friday
                                    case 4:
                                        set_HTML(working_days_of_week, j, i, "Friday");
                                        break;

                                    //if user selects Saturday
                                    case 5:
                                        set_HTML(working_days_of_week, j, i, "Saturday");
                                        break;

                                    //if user selects Sunday
                                    case 6:
                                        set_HTML(working_days_of_week, j, i, "Sunday");
                                        break;
                                }
                                i++;
                            }
                        }
                        i--;
                    }
                }
            }
            
        }
        protected void set_HTML(List<Boolean> working_days_of_week, int index, int day_of_month, string day_of_week)
        {

            //if boolean value of day is true its time to work
            if (working_days_of_week[index] == true)
            {
                weekly_calendar_summary.InnerHtml += "October" + day_of_month + "  is a " + day_of_week + "! Time to work" + "<br>";
            }
            // else boolean value of day will be false so its time to have fun!!
            else
            {
                weekly_calendar_summary.InnerHtml += "October" + day_of_month + " is a " + day_of_week + "! Time to have fun! " + "<br>";
            }
        }
    }
}