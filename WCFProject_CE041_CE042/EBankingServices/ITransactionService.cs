using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EBankingServices
{
    [ServiceContract]
    public interface ITransactionService
    {
        [OperationContract]
        String DoTransac(Transaction ts);
    }
    [DataContract]
    public class Transaction {
        int id;
        string name = string.Empty;
        string to = string.Empty;
        string from = string.Empty;
        int money;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        [DataMember]
        public string From
        {
            get { return from; }
            set { from = value; }

        }
        [DataMember]
        public string To
        {
            get { return to; }
            set { to = value; }

        }
        [DataMember]
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
