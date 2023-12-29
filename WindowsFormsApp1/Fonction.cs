using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Fonction
    {
        private SqlConnection Conn;
        private SqlCommand Comande;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private String Constr;
        public Fonction(){
            Constr = @"";
            Conn =new SqlConnection(Constr);
            Comande = new SqlCommand();
            Comande.Connection = Conn;
        }
        public DataTable RecupererData(string Req)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Req,Constr);
            Sda.Fill(dt);
            return dt;
        }

    }
}
