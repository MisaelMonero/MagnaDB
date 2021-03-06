﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerTester.ServiceReference4 {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoComprobante", Namespace="http://schemas.datacontract.org/2004/07/SaleDomains")]
    public enum TipoComprobante : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CreditoFiscal = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ConsumidorFinal = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotaDebito = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotaCredito = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProveedorInformal = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnicoIngreso = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GastosMenores = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RegimenEspecial = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Gubernamental = 15,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference4.ISalesServer")]
    public interface ISalesServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesServer/GetNextVenta", ReplyAction="http://tempuri.org/ISalesServer/GetNextVentaResponse")]
        long GetNextVenta(string nameDominio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesServer/GetNextVenta", ReplyAction="http://tempuri.org/ISalesServer/GetNextVentaResponse")]
        System.Threading.Tasks.Task<long> GetNextVentaAsync(string nameDominio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesServer/CreateDominio", ReplyAction="http://tempuri.org/ISalesServer/CreateDominioResponse")]
        bool CreateDominio(string nameDominio, string parteFija);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesServer/CreateDominio", ReplyAction="http://tempuri.org/ISalesServer/CreateDominioResponse")]
        System.Threading.Tasks.Task<bool> CreateDominioAsync(string nameDominio, string parteFija);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesServer/GetNextComprobante", ReplyAction="http://tempuri.org/ISalesServer/GetNextComprobanteResponse")]
        string GetNextComprobante(string nameDominio, ServerTester.ServiceReference4.TipoComprobante tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesServer/GetNextComprobante", ReplyAction="http://tempuri.org/ISalesServer/GetNextComprobanteResponse")]
        System.Threading.Tasks.Task<string> GetNextComprobanteAsync(string nameDominio, ServerTester.ServiceReference4.TipoComprobante tipo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISalesServerChannel : ServerTester.ServiceReference4.ISalesServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SalesServerClient : System.ServiceModel.ClientBase<ServerTester.ServiceReference4.ISalesServer>, ServerTester.ServiceReference4.ISalesServer {
        
        public SalesServerClient() {
        }
        
        public SalesServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalesServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long GetNextVenta(string nameDominio) {
            return base.Channel.GetNextVenta(nameDominio);
        }
        
        public System.Threading.Tasks.Task<long> GetNextVentaAsync(string nameDominio) {
            return base.Channel.GetNextVentaAsync(nameDominio);
        }
        
        public bool CreateDominio(string nameDominio, string parteFija) {
            return base.Channel.CreateDominio(nameDominio, parteFija);
        }
        
        public System.Threading.Tasks.Task<bool> CreateDominioAsync(string nameDominio, string parteFija) {
            return base.Channel.CreateDominioAsync(nameDominio, parteFija);
        }
        
        public string GetNextComprobante(string nameDominio, ServerTester.ServiceReference4.TipoComprobante tipo) {
            return base.Channel.GetNextComprobante(nameDominio, tipo);
        }
        
        public System.Threading.Tasks.Task<string> GetNextComprobanteAsync(string nameDominio, ServerTester.ServiceReference4.TipoComprobante tipo) {
            return base.Channel.GetNextComprobanteAsync(nameDominio, tipo);
        }
    }
}
