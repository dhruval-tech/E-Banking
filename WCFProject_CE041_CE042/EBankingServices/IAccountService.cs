using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EBankingServices
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        String Insert(Users us);
        [OperationContract]
        List<string> LoginUserDetails(Users userInfo);
        [OperationContract]
        Users getUserbyID(string email);
        //[OperationContract]
        //gettestdata GetInfo();

        //[OperationContract]
        //string Update(UpdateCustomer uc);

        //[OperationContract]
        //string Delete(DeleteCustomer dc);



    }

    [DataContract]
    public class Users
    {
        int id;
        string firstName = string.Empty;
        string lastName = string.Empty;
        string email = string.Empty;
        string address = string.Empty;
        int balance;
        string password = string.Empty;
        string contact = string.Empty;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }
        [DataMember]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }
        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }

        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }

        }
        [DataMember]
        public string Contact
        {
            get { return contact; }
            set { contact = value; }

        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }

        }

        [DataMember]
        public int Balance
        {
            get { return balance; }
            set { balance = value; }

        }

    }
}
