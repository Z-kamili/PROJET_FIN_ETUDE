using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public class Class1
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-14BHUMG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        public static SqlCommand cmd;
        public static void connecter()
        {
            if(cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
            {
                cn.Open();
            }
            
           
        }
        public static void Deconnecter()
        {
            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
           
        }
    }
}