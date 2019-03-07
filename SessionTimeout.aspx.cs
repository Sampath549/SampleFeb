using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminPresentation
{
    public partial class SessionTimeout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now);
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetNoStore();

            Response.ClearHeaders();
            Response.AddHeader("Cache-Control", "no-cache, no-store, must-revalidate");
            Response.AddHeader("Pragma", "no-cache");
            Response.AddHeader("Expires", "0");

            Session.Abandon();
            FormsAuthentication.SignOut();
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            AutoRedirect();
        }

        public void AutoRedirect()
        {
            int int_MilliSecondsTimeOut = (this.Session.Timeout * 1200000); // 60000 MilliSeconds = 1 Min || 1200000 MilliSeconds = 20 Mins
            string str_Script = @"<script type='text/javascript'> 
                                 intervalset = window.setInterval('Redirect()'," + int_MilliSecondsTimeOut.ToString() + @");
                                    function Redirect()
                                    {
                                       window.location.href='SessionTimeout.aspx'; 
                                    }
                                </script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Redirect", str_Script);
        }
    }
}