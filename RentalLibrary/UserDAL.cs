using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RentalLibrary.DAL
{
    class UserDAL
    {
        public string ConnectString = "Data Source=DESKTOP-FSQ191M;Initial Catalog=RentalDB;Integrated Security=True";
        SqlConnection Con = new SqlConnection();
        DataTable Dt = new DataTable();

        public Int32 RegUser(Model.User Tmp) //Registrera en ny användare
        {
            try
            {
                Con.ConnectionString = ConnectString;
                if (ConnectionState.Closed == Con.State)
                    Con.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO TableUser VALUES (@Username, @Password)", Con);

                Cmd.Parameters.AddWithValue("@Username", Tmp.Username);
                Cmd.Parameters.AddWithValue("@Password", Tmp.Password);

                return Cmd.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                throw;
            }
        }
        public Int32 LoginUser(Model.User Tmp)
        {
            try
            {
                Con.ConnectionString = ConnectString;
                if (ConnectionState.Closed == Con.State)
                    Con.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM TableUser WHERE Username = (@Username) AND Password = (@Password)", Con);

                Cmd.Parameters.AddWithValue("@Username", Tmp.Username);
                Cmd.Parameters.AddWithValue("@Password", Tmp.Password);

                DataSet Ds = new DataSet();
                SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                Da.Fill(Ds);

                bool LoginSuccessful = ((Ds.Tables.Count > 0) && (Ds.Tables[0].Rows.Count > 0));

                if (LoginSuccessful)
                {
                    Con.Close(); //Connection closes if user&pass matches - want this to open new page!
                }
                else
                {
                    //Invalid - dosomething
                }
                return Cmd.ExecuteNonQuery();


            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
