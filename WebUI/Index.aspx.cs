using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"]!=null)
        {
            Label1.Text = Session["name"].ToString();
        }
    }

    public void btnlogin(object sender, EventArgs e)
    {
        try
        {
            BLL.UserManage um = new BLL.UserManage();
            Model.UserInfo user = um.userlogin(Text1.Value,Text2.Value);

            Session["name"] = user.uname;
            Response.Write("<script>alert('login ok');location.href='Index.aspx';</script>");

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('"+ex.Message+"');</script>");
        }
      


    }

}