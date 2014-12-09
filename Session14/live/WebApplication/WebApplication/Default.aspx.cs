using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBoxTitle.Text = String.Empty;
            alertbox.InnerHtml = "";
            if (CheckBox1.Checked)
            {
                Label1.Text = TextBoxTitle.Text;
            }
            else
            {
                Label1.Text = "";
                alertbox.InnerHtml = "You chould check the checkbox first"; 
                
            }
        }
    }
}