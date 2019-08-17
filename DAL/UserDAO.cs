using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAO
    {
        DB mydb = new DB();

        public Model.UserInfo selectuser(string uname, string upsd)
        {
            Model.UserInfo user = null;

            mydb.sqlcom(mydb.openconn());
            mydb.com.CommandText = "select * from userinfo where uname=@uname and upsd=@upsd";
            mydb.com.Parameters.Add(new SqlParameter ("@uname",uname));
            mydb.com.Parameters.Add(new SqlParameter("@upsd", upsd));

            mydb.sqlread(mydb.com);

            if (mydb.read.Read ())
            {
                user = new Model.UserInfo();

                user.uid = mydb.read.GetInt32(0);
                user.uname = mydb.read.GetString(1);
                user.upsd = mydb.read.GetString(2);
                user.umail = mydb.read.GetString(3);

                
            }
            return user;

        }
        
    }
}
