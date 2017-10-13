using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_StateManagement
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

            //control for btnAddCookieMessage
            protected void btnAddCookieMessage_click(object sender, EventArgs e)
               {
            if (txtCookieMessage.Text==String.Empty)
                {
                lblCookieResponse.Text = "Your cookie is empty!";
            }
                        else
            {
                    //create a new cookie
                    HttpCookie cookie = new HttpCookie("CookieMessage", txtCookieMessage.Text);
                    //long expiration so we can use the button to delete cookie
                    cookie.Expires = DateTime.Now.AddYears(1);
                    //add cookie to cookie collection
                    Response.Cookies.Add(cookie);
                    //display something to show the cookie was accepted
                    lblCookieResponse.Text = "You just saved a cookie!";
              
            }
     
                //Response.Redirect("Pages/Cookie.aspx");
            }
            //control for btnGetCookie
            protected void btnGetCookie_click(object sender, EventArgs e)
            {
            if (txtCookieMessage.Text == String.Empty)
            {
                lblCookieMessage.Text = "You have no cookie, sorry!";
            }
            else
            {

                //display the cookie in the label

                lblCookieMessage.Text = "Your cookie is: " + Request.Cookies["CookieMessage"].Value;
            }
            }
        //control for btnExpireCookie
        protected void btnExpireCookie_click(object sender, EventArgs e)
            {
            //get cookie to expire, though I am not sure how it picks the "right" cookie...
            HttpCookie cookie = new HttpCookie("CookieMessage");
            //expires cookie right away
            cookie.Expires = DateTime.Now.AddDays(-1d);
            //removes the expired cookie...hopefully
            Response.Cookies.Add(cookie);
            //success message
            lblCookieMessage.Text = "Cookie (if there was one) has been cleared!";
            //clear out add statement
            lblCookieResponse.Text = "";
        }

        protected void btnAddSessionMessage_click(object sender, EventArgs e)
        {
                Session["SessionText"] = txtSessionMessage.Text;
                Response.Redirect("Pages/SessionState.aspx");
           
            
        }



    }
}