using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPBASICS.Models;

namespace ASPBASICS.Models
{
    public partial class ASPBasics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
           
            
            inpLabel.Text = "hai hello how r u ";
        }
    }
}