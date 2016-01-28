using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Drinago.Models
{
    public class UserDB
    {
        //variable connection
        protected SqlConnection con;

        //open connection
        public bool Open(string Connection = "DefaultConnection")
        {
            con = new SqlConnection(@WebConfigurationManager.ConnectionStrings[Connection].ToString());
            try
            {
                bool b = true;
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }
                return b;
            }

            catch (SqlException)
            {
                return false;
            }
        }

        //end Open Connection
        //close connection

        public bool Close()
        {
            try
            {
                con.Close();
                return true;
            }

            catch (Exception)
            {

            }
            {
                return false;
            }
        }




    }





}
