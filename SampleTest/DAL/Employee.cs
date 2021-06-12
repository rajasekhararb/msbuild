using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace SampleTest.DAL
{
    public class Employee
    {
        
        private int _id;
        private string _pwd;
       
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }

        }

        public String PassWord
        {
            get
            {
                return _pwd;
            }
            set
            {
                _pwd = value;
            }

        }

        public Employee get()
        {

            Employee e = new Employee();
            e.ID = 101;
            e.PassWord = "Sankar";
            return e;

            
           /* SqlConnection con = new SqlConnection("databaseconnection");
            con.Open();

            SqlCommand cm = new SqlCommand("select * from table ");

            cm.Connection = con;
            cm.CommandType = System.Data.CommandType.StoredProcedure;
*/
           

        }
        
        // database logic
    }
}