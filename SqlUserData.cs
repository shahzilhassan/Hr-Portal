using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1
{   public  class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
    }
    internal class SqlUserData
    {
        string connstr = @"Data Source=DESKTOP-HNT8HH2\SQLEXPRESS01;Initial Catalog=Inventory_Management;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adptr;
        DataTable tb = new DataTable();

        public bool SetUserData( string name, DateTime joiningdate, int salary, string address)
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string query = "insert into Employee_Portal values('" + name + "','" + address + "'," + salary + ",'" + joiningdate + "')";
            cmd = new SqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool Deletedata(int id)
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string query = "Delete from Employee_Portal  where Employee_ID = " + id + "";
            cmd = new SqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool Updatedata(string name, DateTime joiningdate, int salary, string address ,int id)
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string query = "update Employee_Portal set Name = '"+name+"', Address ='"+address+"', Salary="+salary+", Joining_Date ='"+joiningdate+"' where Employee_ID = "+id+"";
            cmd = new SqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
    }
}
