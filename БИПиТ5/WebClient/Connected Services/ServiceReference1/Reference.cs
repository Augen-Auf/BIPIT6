﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AllData", Namespace="http://schemas.datacontract.org/2004/07/ClassLibrary")]
    [System.SerializableAttribute()]
    public partial class AllData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdO {
            get {
                return this.IdOField;
            }
            set {
                if ((object.ReferenceEquals(this.IdOField, value) != true)) {
                    this.IdOField = value;
                    this.RaisePropertyChanged("IdO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string Client {
            get {
                return this.ClientField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientField, value) != true)) {
                    this.ClientField = value;
                    this.RaisePropertyChanged("Client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Service {
            get {
                return this.ServiceField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceField, value) != true)) {
                    this.ServiceField = value;
                    this.RaisePropertyChanged("Service");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Time {
            get {
                return this.TimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeField, value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Price {
            get {
                return this.PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceField, value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Total {
            get {
                return this.TotalField;
            }
            set {
                if ((object.ReferenceEquals(this.TotalField, value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string Date {
            get {
                return this.DateField;
            }
            set {
                if ((object.ReferenceEquals(this.DateField, value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        WebClient.ServiceReference1.AllData[] GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.AllData[]> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Clients", ReplyAction="http://tempuri.org/IService1/ClientsResponse")]
        System.Collections.Generic.Dictionary<int, string> Clients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Clients", ReplyAction="http://tempuri.org/IService1/ClientsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> ClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Services", ReplyAction="http://tempuri.org/IService1/ServicesResponse")]
        System.Collections.Generic.Dictionary<int, string> Services();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Services", ReplyAction="http://tempuri.org/IService1/ServicesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> ServicesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewRec", ReplyAction="http://tempuri.org/IService1/NewRecResponse")]
        void NewRec(int IdC, int IdS, int Time, System.DateTime Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewRec", ReplyAction="http://tempuri.org/IService1/NewRecResponse")]
        System.Threading.Tasks.Task NewRecAsync(int IdC, int IdS, int Time, System.DateTime Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CountOfDBRows", ReplyAction="http://tempuri.org/IService1/CountOfDBRowsResponse")]
        void CountOfDBRows(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CountOfDBRows", ReplyAction="http://tempuri.org/IService1/CountOfDBRowsResponse")]
        System.Threading.Tasks.Task CountOfDBRowsAsync(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ResponseFromHost", ReplyAction="http://tempuri.org/IService1/ResponseFromHostResponse")]
        void ResponseFromHost(string name, string port, string loaclPath, string uri, string scheme);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ResponseFromHost", ReplyAction="http://tempuri.org/IService1/ResponseFromHostResponse")]
        System.Threading.Tasks.Task ResponseFromHostAsync(string name, string port, string loaclPath, string uri, string scheme);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebClient.ServiceReference1.IService1>, WebClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebClient.ServiceReference1.AllData[] GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.AllData[]> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public System.Collections.Generic.Dictionary<int, string> Clients() {
            return base.Channel.Clients();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> ClientsAsync() {
            return base.Channel.ClientsAsync();
        }
        
        public System.Collections.Generic.Dictionary<int, string> Services() {
            return base.Channel.Services();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> ServicesAsync() {
            return base.Channel.ServicesAsync();
        }
        
        public void NewRec(int IdC, int IdS, int Time, System.DateTime Date) {
            base.Channel.NewRec(IdC, IdS, Time, Date);
        }
        
        public System.Threading.Tasks.Task NewRecAsync(int IdC, int IdS, int Time, System.DateTime Date) {
            return base.Channel.NewRecAsync(IdC, IdS, Time, Date);
        }
        
        public void CountOfDBRows(string input) {
            base.Channel.CountOfDBRows(input);
        }
        
        public System.Threading.Tasks.Task CountOfDBRowsAsync(string input) {
            return base.Channel.CountOfDBRowsAsync(input);
        }
        
        public void ResponseFromHost(string name, string port, string loaclPath, string uri, string scheme) {
            base.Channel.ResponseFromHost(name, port, loaclPath, uri, scheme);
        }
        
        public System.Threading.Tasks.Task ResponseFromHostAsync(string name, string port, string loaclPath, string uri, string scheme) {
            return base.Channel.ResponseFromHostAsync(name, port, loaclPath, uri, scheme);
        }
    }
}
