using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApplication
{
    public class RegisterController: Controller
    {
        public int insertEmpAjax(User user)
        {
            return 0;
        }

        public void insertEmpAjax()
        {

        }     
        
        public int SaveUser(string firstName, string lastName)
        {
            return 0;
        }

        public int insertEmpAjax(List<User> Users)
        {
            int intRecord = 0;
            string conn_String = ConfigurationManager.ConnectionStrings["myDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conn_String))
            {
                conn.Open();
                    foreach (User s in Users)
                    {
                        string FirstName = s.FirstName;
                        string Lastname = s.LastName;
                        string sql = "insert into UserInfo(FirstName,LastName) values('" + FirstName + "','" + Lastname + "')";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            intRecord = cmd.ExecuteNonQuery();
                        }
                    }
                                
                conn.Close();
            }
            return intRecord;
        }

        public string Show()
        {
            return "true";
        }
    }
}