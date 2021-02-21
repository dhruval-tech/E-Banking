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
    public class EmployeeService : IEmployeeService
    {
        public void InsertEmpDetails(Employees eDetails)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Employees (Name,Salary,DeptId,DeptName) values (@Name,@Salary,@DeptId,@DeptName)", con);
            cmd.Parameters.AddWithValue("@Name", eDetails.Name);
            cmd.Parameters.AddWithValue("@Salary", eDetails.Salary);
            cmd.Parameters.AddWithValue("@DeptId", eDetails.DeptId);
            cmd.Parameters.AddWithValue("@DeptName", eDetails.DeptName);

            int g = cmd.ExecuteNonQuery();


        }
        public List<Employees> GetEmployees()
        {
            List<Employees> studentList = new List<Employees>();
            DataTable resourceTable = new DataTable();
            SqlDataReader resultReader = null;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand command = new SqlCommand("Select * from Employees", con);
            int g = command.ExecuteNonQuery();

            try
            {
                resultReader = command.ExecuteReader();
                resourceTable.Load(resultReader);
                resultReader.Close();
                con.Close();
                studentList = (from DataRow dr in resourceTable.Rows
                               select new Employees()
                               {
                                   EmpId = Convert.ToInt32(dr["EmpId"]),
                                   Name = dr["Name"].ToString(),
                                   Salary = dr["Salary"].ToString(),
                                   DeptId = dr["DeptId"].ToString(),
                                   DeptName = dr["DeptName"].ToString()
                               }).ToList();
            }
            catch (Exception exception)
            {
                if (resultReader != null || con.State == ConnectionState.Open)
                {
                    resultReader.Close();
                    con.Close();
                }

                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }
            return studentList;
        }
        public void UpdateEmpDetails(Employees eDetails)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            //"UPDATE Student SET FirstName = @FirstName,LastName = @LastName,RegisterNo = @RegisterNo,Department = @Department WHERE StudentId = @StudentId"
            SqlCommand cmd = new SqlCommand("UPDATE Employees SET Name = @Name, Salary = @Salary, DeptId = @DeptId, DeptName = @DeptName WHERE EmpId = @EmpID", con);
            cmd.Parameters.AddWithValue("@EmpId", eDetails.EmpId);
            cmd.Parameters.AddWithValue("@Name", eDetails.Name);
            cmd.Parameters.AddWithValue("@Salary", eDetails.Salary);
            cmd.Parameters.AddWithValue("@DeptId", eDetails.DeptId);
            cmd.Parameters.AddWithValue("@DeptName", eDetails.DeptName);

            int g = cmd.ExecuteNonQuery();


        }
        public void DeleteEmpDetails(int EmpId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Employees WHERE EmpId = @EmpId", con);
                    command.Parameters.AddWithValue("@EmpId", EmpId);

                    int result = command.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException exception)
            {
                throw new FaultException<ExceptionMessage>(new ExceptionMessage(exception.Message));
            }



        }
    }
}

