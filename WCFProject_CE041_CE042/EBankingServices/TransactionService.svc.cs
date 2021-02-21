using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EBankingServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TransactionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TransactionService.svc or TransactionService.svc.cs at the Solution Explorer and start debugging.
    public class TransactionService : ITransactionService
    {
        public String DoTransac(Transaction ts) {
            string msg=null;

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Transaction (Name,From,To,Money) VALUES (@Name,@From,@To,@Money)", con);
            //cmd.Parameters.AddWithValue("@Name", ts.Name);
            //cmd.Parameters.AddWithValue("@From", ts.From);
            //cmd.Parameters.AddWithValue("@To", ts.To);
            //cmd.Parameters.AddWithValue("@Money", ts.Money);


            //int g = cmd.ExecuteNonQuery();
            //if (g == 1) {
            //    msg = "Transaction went successfull";
            //}
            //else
            //{
            //    msg = "Failed To Registere.";
            //}
            //return msg;
            //int g = cmd.ExecuteNonQuery();
            //if (g == 1)
            //{
            //    


            //}
            //con.Close();
            SqlCommand cmd = new SqlCommand("Select * from Users WHERE Email = @Email", con);
            cmd.Parameters.AddWithValue("@Email", ts.From);
            SqlDataReader dr = cmd.ExecuteReader();
            int mn = 0;
            if (dr.Read() == true)
            {
                mn = Int32.Parse(dr[6].ToString());

            }
            dr.Close();
            con.Close();
            if (mn >= ts.Money)
            {
                con.Open();
                cmd = new SqlCommand("Select * from Users WHERE Email=@Email", con);
                cmd.Parameters.AddWithValue("@Email", ts.To);
                dr = cmd.ExecuteReader();
                int ToMn = 0;
                if (dr.Read() == true)
                {
                    ToMn = Int32.Parse(dr[6].ToString());

                }
                ToMn = ToMn + ts.Money;
                dr.Close();
                con.Close();
                con.Open();
                cmd = new SqlCommand("UPDATE Users SET Balance = @Balance WHERE Email = @Email", con);
                cmd.Parameters.AddWithValue("@Balance", ToMn);
                cmd.Parameters.AddWithValue("@Email", ts.To);

                cmd.ExecuteNonQuery();
                dr.Close();
                con.Close();
                int fromMn = 0;
                if (mn - ts.Money < 0)
                {
                    fromMn = 0;
                }
                else
                {
                    fromMn = mn - ts.Money;
                }
                con.Open();
                cmd = new SqlCommand("UPDATE Users SET Balance = @Balance WHERE Email = @Email", con);
                cmd.Parameters.AddWithValue("@Balance", fromMn);
                cmd.Parameters.AddWithValue("@Email", ts.From);

                cmd.ExecuteNonQuery();
                con.Close();

                //con.Open();
                //cmd = new SqlCommand("Insert into Transaction(Name,From,To,Money) values(@Name,@From,@To,@Money)", con);
                //cmd.Parameters.AddWithValue("@Name", ts.Name);
                //cmd.Parameters.AddWithValue("@From", ts.From);
                //cmd.Parameters.AddWithValue("@To", ts.To);
                //cmd.Parameters.AddWithValue("@Money", ts.Money);


                //int g = cmd.ExecuteNonQuery();
                //if (g == 1)
                //{
                //    


                //}
                //con.Close();
                msg = "Transaction went successfull";

            }
            return msg;
        }
    }
}
