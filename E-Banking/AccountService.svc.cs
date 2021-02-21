using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace E_Banking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServeCustomer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServeCustomer.svc or ServeCustomer.svc.cs at the Solution Explorer and start debugging.
    public class ServeCustomer : IAccountService
    {

        public String Insert(Users us)
        {
            string msg;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

        //public gettestdata GetInfo()
        //{
        //    gettestdata g = new gettestdata();
        //    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30;" +
        //        "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Select * from customers", con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    g.customertab = dt;
        //    return g;
        //}

        //public string Update(UpdateCustomer uc)
        //{
        //    string msg1 = " ";
        //    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30;" +
        //        "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Update customers set CusFname = @CusFname , CusLname=@CusLname , Email=@Email , Address=@Address where Id = @Id",con);
        //    cmd.Parameters.AddWithValue("@Id", uc.Custom_Id);
        //    cmd.Parameters.AddWithValue("@CusFname",uc.Firstname);
        //    cmd.Parameters.AddWithValue("@CusLname",uc.lastname);
        //    cmd.Parameters.AddWithValue("@Email",uc.EmailID);
        //    cmd.Parameters.AddWithValue("@Address",uc.Address);

        //    int res = cmd.ExecuteNonQuery();
        //    if(res == 1)
        //    {
        //        msg1 = "Updated Successfully.";
        //    }
        //    else
        //    {
        //        msg1 = "Update failure.";
        //    }
        //    return msg1;
        //}

        //public string Delete(DeleteCustomer dc)
        //{
        //    string msg = "";
        //    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30;" +
        //        "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("delete customers where Id = @Id ", con);
        //    cmd.Parameters.AddWithValue("@Id", dc.CustId);
        //    int res = cmd.ExecuteNonQuery();
        //    if(res == 1)
        //    {
        //        msg = "Successfully deleted.";
        //    }
        //    else
        //    {
        //        msg = "Failed to  delete.";
        //    }
        //    return msg;
        //}

    }

}
