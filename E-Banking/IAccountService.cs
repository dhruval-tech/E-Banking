using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace E_Banking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServeCustomer" in both code and config file together.
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        String Insert(Users us);

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

    //[DataContract]
    //public class gettestdata
    //{
    //    [DataMember]
    //    public DataTable customertab
    //    {
    //        get;
    //        set;
    //    }

    //}

    //[DataContract]
    //public class UpdateCustomer
    //{
    //    int customerId;
    //    string fname;
    //    string lname;
    //    string email;
    //    string address;

    //    [DataMember]
    //    public int Custom_Id
    //    {
    //        get { return customerId; }
    //        set { customerId = value; }
    //    }

    //    [DataMember]
    //    public string Firstname
    //    {
    //        get { return fname; }
    //        set { fname = value; }
    //    }

    //    [DataMember]
    //    public string lastname
    //    {
    //        get { return lname; }
    //        set { lname = value; }
    //    }

    //    [DataMember]
    //    public string EmailID
    //    {
    //        get { return email; }
    //        set { email = value; }
    //    }

    //    [DataMember]
    //    public string Address
    //    {
    //        get { return address; }
    //        set { address = value; }
    //    }
    //}

    //[DataContract]
    //public class DeleteCustomer
    //{
    //    int cust_Id;
    //    [DataMember]
    //    public int CustId
    //    {
    //        get {return cust_Id; }
    //        set {cust_Id = value; }
    //    }
    //}
}