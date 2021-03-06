﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerTester.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/SaleDomainsServer")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFacturacionServer")]
    public interface IFacturacionServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacionServer/GetNoFactura", ReplyAction="http://tempuri.org/IFacturacionServer/GetNoFacturaResponse")]
        int GetNoFactura(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacionServer/GetNoFactura", ReplyAction="http://tempuri.org/IFacturacionServer/GetNoFacturaResponse")]
        System.Threading.Tasks.Task<int> GetNoFacturaAsync(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacionServer/CreateDominio", ReplyAction="http://tempuri.org/IFacturacionServer/CreateDominioResponse")]
        bool CreateDominio(string domainName, int conteoFactura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacionServer/CreateDominio", ReplyAction="http://tempuri.org/IFacturacionServer/CreateDominioResponse")]
        System.Threading.Tasks.Task<bool> CreateDominioAsync(string domainName, int conteoFactura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacionServer/GetData", ReplyAction="http://tempuri.org/IFacturacionServer/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacionServer/GetData", ReplyAction="http://tempuri.org/IFacturacionServer/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacionServer/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IFacturacionServer/GetDataUsingDataContractResponse")]
        ServerTester.ServiceReference1.CompositeType GetDataUsingDataContract(ServerTester.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacionServer/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IFacturacionServer/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServerTester.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ServerTester.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFacturacionServerChannel : ServerTester.ServiceReference1.IFacturacionServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FacturacionServerClient : System.ServiceModel.ClientBase<ServerTester.ServiceReference1.IFacturacionServer>, ServerTester.ServiceReference1.IFacturacionServer {
        
        public FacturacionServerClient() {
        }
        
        public FacturacionServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FacturacionServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FacturacionServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FacturacionServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetNoFactura(string key) {
            return base.Channel.GetNoFactura(key);
        }
        
        public System.Threading.Tasks.Task<int> GetNoFacturaAsync(string key) {
            return base.Channel.GetNoFacturaAsync(key);
        }
        
        public bool CreateDominio(string domainName, int conteoFactura) {
            return base.Channel.CreateDominio(domainName, conteoFactura);
        }
        
        public System.Threading.Tasks.Task<bool> CreateDominioAsync(string domainName, int conteoFactura) {
            return base.Channel.CreateDominioAsync(domainName, conteoFactura);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ServerTester.ServiceReference1.CompositeType GetDataUsingDataContract(ServerTester.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ServerTester.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ServerTester.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
