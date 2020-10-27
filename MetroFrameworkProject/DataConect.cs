using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MetroFrameworkProject
{
    class DataConect
    {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cd = new SqlCommand();

        private void Connect()
        {
            string s = "";
            s = @"Server=.\SQLEXPRESS01;Database=Futebol;UID=sa;PWD=123";
            cn.ConnectionString = s;
            cn.Open();
        }

        public void Execute(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public DataSet List(string sql)
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        private string fields;
        public string Fields { get => fields; set => fields = value; }

        public void Consult(string sql)
        {
            Connect();
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();
            fields = "";
            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Fields += dr[i].ToString() + ";";

                }
            }
            cn.Close();
        }
    }
}
