using ProjectAppl.Entities;
using ProjectAppl.Web.UI.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAppl.Web.UI.UserControl
{
    public partial class StudentTemplate : System.Web.UI.UserControl
    {
        tbl_StudentProfile _lsttbl = new tbl_StudentProfile();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Comman.GetSessionValue("SessionRollStudent") != null)
            {
                Response.AppendHeader("Refresh", Convert.ToString((Session.Timeout * 60)) + ";URL=../SessionTimeout.aspx");
                _lsttbl = Comman.GetSessionValue("SessionRollStudent") as tbl_StudentProfile;
                lbluseremail.Text = _lsttbl.EmailID.ToString();
                lblstunamefull.Text = _lsttbl.FirstName.ToString() + " " + _lsttbl.LastName.ToString();
                imgstupic.Src = "~/PhotoUploads/" + _lsttbl.PhotoPath.ToString() + "";
            }
            else
                Response.Redirect("../SessionTimeout.aspx");
        }

        protected void btnlog_ServerClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("StudentLogin.aspx");
        }
    }
}