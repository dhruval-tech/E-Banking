using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EBankingServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AccountService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AccountService.svc or AccountService.svc.cs at the Solution Explorer and start debugging.
    public class AccountService : IAccountService 
    {
        public String Insert(Users us)
        {
            string msg;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Users(FirstName,LastName,Email,Address,Password,Balance,Contact)  values(@FirstName,@LastName,@Email,@Address,@Password,@Balance,@Contact)", con);
            cmd.Parameters.AddWithValue("@FirstName", us.FirstName);
            cmd.Parameters.AddWithValue("@LastName", us.LastName);
            cmd.Parameters.AddWithValue("@Email", us.Email);
            cmd.Parameters.AddWithValue("@Address", us.Address);
            cmd.Parameters.AddWithValue("@Password", us.Password);
            cmd.Parameters.AddWithValue("@Balance", us.Balance);
            cmd.Parameters.AddWithValue("@Contact", us.Contact);


            int g = cmd.ExecuteNonQuery();
            if (g == 1)
            {
                msg = "Successfully Registered.";
            }
            else
            {
                msg = "Failed To Registere.";
            }
            return msg;
        }
        public List<string> LoginUserDetails(Users userInfo)
        {
            List<string> usr = new List<string>();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where Email=@Email and Password=@Password", con);
            cmd.Parameters.AddWithValue("@Email", userInfo.Email);
            cmd.Parameters.AddWithValue("@Password", userInfo.Password);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                usr.Add(dr[0].ToString());
                usr.Add(dr[2].ToString());
            }
            con.Close();
            return usr;
        }
    }
}
