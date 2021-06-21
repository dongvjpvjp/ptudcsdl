using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CSKH_SALONOTO.Class
{
    class Progress
    {
        public SqlConnection cn = new SqlConnection();
        
        public bool connect(string datasource, string databasename)
        {
            try
            {
                cn = new SqlConnection("Data Source=" + datasource + "Database=" + databasename + "Integrated Security=True;Connect Timeout = 30;User instance = false");
                cn.Open();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public void close()
        {
            cn.Close();
        }

        public bool check(string a)
        {
            if (a == "")
            { return false; }
            if (a.Contains(" "))
            { return false; }
            return true;

        }
        public DataTable get(string str)
        {
            connect(@".\SQLEXPRESS;", "CSKH_OTO;");
            DataSet Ds = new DataSet();
            close();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(str,this.cn);
                sda.Fill(Ds,str);
                DataTable dt = Ds.Tables[0];
                return dt;
            }
            catch
            {
                return null;
            }

        }
        public void update(string data)
        {
            connect(@".\SQLEXPRESS;", "CSKH_OTO;");
            SqlCommand cmd = new SqlCommand(data, this.cn);
            cmd.ExecuteNonQuery();
            close();
        }
        // Xóa ( Delete table Where
        public void delete(string tbcl,string val1)
        {
            string str = tbcl + "'" + val1 + "';";
            
                connect(@".\SQLEXPRESS;", "CSKH_OTO;");
                SqlCommand cmd = new SqlCommand(str, this.cn);
                cmd.ExecuteNonQuery();
                close();

        }

        //Thêm (Insert into table() values)
        public void insert(string tbcl, string val1, string val2, string val3)
        {
            string str = tbcl + " VALUES (" + val1 + val2 + val3 + ");" ;
            
                connect(@".\SQLEXPRESS;", "CSKH_OTO;");
                SqlCommand cmd = new SqlCommand(str, this.cn);
                cmd.ExecuteNonQuery();
                close();
           

        }
        public void insert(string tbcl, string val1, string val2, string val3, string val4, string val5)
        {
            string str = tbcl + "VALUES (" + val1 +  val2 +  val3 + val4 + val5 + ");";
           
                connect(@".\SQLEXPRESS;", "CSKH_OTO;");
                SqlCommand cmd = new SqlCommand(str, this.cn);
                cmd.ExecuteNonQuery();
                close();
                
            

        }
        public void insert(string tbcl, string val1, string val2, string val3, string val4, string val5,string val6)
        {
            string str = tbcl + "VALUES (" + val1 +  val2 + val3 + val4 +  val5 +val6+");";
            
                connect(@".\SQLEXPRESS;", "CSKH_OTO;");
                SqlCommand cmd = new SqlCommand(str, this.cn);
                cmd.ExecuteNonQuery();
                close();
          

        }
        public void insert(string tbcl, string val1, string val2, string val3, string val4, string val5, string val6,string val7,string val8)
        {
            string str = tbcl + "VALUES (" + val1 + val2 + val3 + val4  + val5 + val6 +val7+val8+");";
            
                connect(@".\SQLEXPRESS;", "CSKH_OTO;");
                SqlCommand cmd = new SqlCommand(str, this.cn);
                cmd.ExecuteNonQuery();
                close();
           

        }
    }

}

