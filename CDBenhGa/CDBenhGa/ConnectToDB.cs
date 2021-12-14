using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDBenhGa
{
    class ConnectToDB
    {
        public const string conn = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=BenhGa;Integrated Security=True;User ID= sa;Password = sa123";
        SqlConnection connection = null;

        public DataSet get_data(string sql,string table_name, List<SqlParameter> parameters)
        {
            DataSet data = new DataSet();
            try
            {
                connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql,connection);
                if (parameters != null)
                    dataAdapter.SelectCommand.Parameters.AddRange(parameters.ToArray());
                dataAdapter.Fill(data, table_name);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi !" + ex.Message);
            }
            return data;
        }
        public void Excute(string query, List<SqlParameter> parameters)
        {
            try
            {
                connection = new SqlConnection(conn);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                if (parameters != null)
                    command.Parameters.AddRange(parameters.ToArray());
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
        }
    }
}
