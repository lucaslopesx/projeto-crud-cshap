using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto_crud_cshap
{
    class Connection
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public void InitiateConnection()
        {
            cn.ConnectionString = "SERVER = DESKTOP-GM7EVH8\\SQLEXPRESS; Database=Agenda; UID=sa; PWD=1234;";
            cn.Open();
            cmd.Connection = cn;

        }

        public void AdapterAndSet(string select)
        {
            SqlDataAdapter da = new SqlDataAdapter(select,cmd.ToString());

            DataSet ds = new DataSet();

            da.Fill(ds);
        }

    }
}
