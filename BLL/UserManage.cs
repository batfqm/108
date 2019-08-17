using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UserManage
    {

        public Model.UserInfo userlogin(string uname, string upsd)
        {
            DAL.UserDAO ud = new DAL.UserDAO();
            Model.UserInfo user = ud.selectuser(uname,upsd);

            if (user != null)
            {

                return user;
            }
            else
            {
                throw new Exception("login failed"); 
            }
           

        }


    }
}
