﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SW_CIDEAUTOS.ServicioBanco {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://bancoweb.azurewebsites.net", ConfigurationName="ServicioBanco.WebServiceBancoSoap")]
    public interface WebServiceBancoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://bancoweb.azurewebsites.net/ConsultarTarjeta", ReplyAction="*")]
        bool ConsultarTarjeta();
        
        [System.ServiceModel.OperationContractAttribute(Action="https://bancoweb.azurewebsites.net/ConsultarTarjeta", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ConsultarTarjetaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceBancoSoapChannel : SW_CIDEAUTOS.ServicioBanco.WebServiceBancoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceBancoSoapClient : System.ServiceModel.ClientBase<SW_CIDEAUTOS.ServicioBanco.WebServiceBancoSoap>, SW_CIDEAUTOS.ServicioBanco.WebServiceBancoSoap {
        
        public WebServiceBancoSoapClient() {
        }
        
        public WebServiceBancoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceBancoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceBancoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceBancoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ConsultarTarjeta() {
            return base.Channel.ConsultarTarjeta();
        }
        
        public System.Threading.Tasks.Task<bool> ConsultarTarjetaAsync() {
            return base.Channel.ConsultarTarjetaAsync();
        }
    }
}
