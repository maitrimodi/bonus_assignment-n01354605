using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonus_assignment_n01354605
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {   
                    //variables for input of user
                    float user_x_axis_var = float.Parse(user_x_axis.Text.ToString());
                    float user_y_axis_var = float.Parse(user_y_axis.Text.ToString());


                    //condition for both values 0
                    if (user_x_axis_var == 0 && user_y_axis_var == 0)
                    {
                        co_ordinate_summary.InnerHtml += "Please enter values other than (0,0) ";
                    }

                    //condition for quadrant 1 and quadrant 4
                    if (user_x_axis_var > 0)
                    {
                        if (user_y_axis_var > 0)
                        {
                            co_ordinate_summary.InnerHtml = "You are in Quadrant 1";
                        }
                        else
                        {
                            co_ordinate_summary.InnerHtml = "You are in Quadrant 4";
                        }
                    }
                    //condition for quadrant 2 and quadrant 3
                    else if (user_x_axis_var < 0)
                    {
                        if (user_y_axis_var > 0)
                        {
                            co_ordinate_summary.InnerHtml = "You are in quadrant 2";
                        }
                        else
                        {
                            co_ordinate_summary.InnerHtml = "You are in quadrant 3";
                        }
                    }
                }
            }



        }
        //custom validator to check if the value is 0 or not
        protected void Co_ordinate_validate(object sender, ServerValidateEventArgs e)
        {
            float number = float.Parse(e.Value);

            if (number == 0)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }
    }
}