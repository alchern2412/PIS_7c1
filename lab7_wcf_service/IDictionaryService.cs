using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace lab7_wcf_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "I
    [ServiceContract]
    public interface IDictionaryService
    {
        [OperationContract]
        List<Record> GetRecords();

        [OperationContract]
        void AddRecord(string name, string number);

        [OperationContract]
        void UpdRecord(int id, string name, string number);

        [OperationContract]
        void DelRecord(int id);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
