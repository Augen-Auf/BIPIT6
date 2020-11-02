using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClassLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [DataContract]
    public class AllData
    {
        [DataMember (Name ="IdO", Order =1)]
        public string IdO { get; set; }
        [DataMember(Name = "Client", Order = 2)]
        public string Client { get; set; }
        [DataMember(Name = "Service", Order = 3)]
        public string Service { get; set; }
        [DataMember(Name = "Time", Order = 4)]
        public string Time { get; set; }
        [DataMember(Name = "Price", Order = 5)]
        public string Price { get; set; }
        [DataMember(Name = "Total", Order = 6)]
        public string Total { get; set; }
        [DataMember(Name = "Date", Order = 7)]
        public string Date { get; set; }
    }

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        AllData[] GetData();
        [OperationContract]
        Dictionary<int, string> Clients();
        [OperationContract]
        Dictionary<int, string> Services();
        [OperationContract]
        void NewRec(int IdC, int IdS, int Time, DateTime Date);
        [OperationContract]
        void CountOfDBRows(string input);
        [OperationContract]
        void ResponseFromHost(string name, string port, string loaclPath, string uri, string scheme);
    }
}
