using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace E_Banking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //[OperationContract]
        //string InsertEmpDetails(Employees eDetails);
        //[OperationContract]
        //getData GetEmpDetails();
        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        void InsertEmpDetails(Employees eDetails);
        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        List<Employees> GetEmployees();
        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        void UpdateEmpDetails(Employees eDetails);
        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        void DeleteEmpDetails(int EmpId);

    }

    [DataContract]
    public class ExceptionMessage
    {
        private string infoExceptionMessage;
        public ExceptionMessage(string Message)
        {
            this.infoExceptionMessage = Message;
        }
        [DataMember]
        public string errorMessageOfAction
        {
            get { return this.infoExceptionMessage; }
            set { this.infoExceptionMessage = value; }
        }
    }
    [DataContract]
    public class getData { 

        [DataMember]
        public DataTable employess{
            get;
            set;
        }
    }
    [DataContract]
    public class Employees
    {
        //int? eId;
        int empId;
        string name = string.Empty;
        string salary = string.Empty;
        string deptId = string.Empty;
        string deptName = string.Empty;

        //[DataMember]
        //public long EmpId;
        [DataMember]
        public int EmpId {
            get
            {
                return empId;
            }
            set {
                empId = value;
            }
        }
        [DataMember]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        [DataMember]
        public string Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        [DataMember]
        public string DeptId
        {
            get
            {
                return deptId;
            }
            set
            {
                deptId = value;
            }
        }
        [DataMember]
        public string DeptName
        {
            get
            {
                return deptName;
            }
            set
            {
                deptName = value;
            }
        }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
