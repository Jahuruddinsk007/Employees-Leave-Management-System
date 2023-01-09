using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem
{
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;
        public Functions() 
        {
            ConStr = @"Data Source=192.168.2.115;Initial Catalog=NetTrainingEmployee;User ID=net_training;password=bct1bnco#";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Con);
            sda.Fill(dt);
            return dt;
        }
        public int SetData(string Query)
        {
            int Cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt= Cmd.ExecuteNonQuery();
            return Cnt;
        }
    }
}
