﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcInterfazUsuario.srvCurrency {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srvCurrency.IsrvCurrency")]
    public interface IsrvCurrency {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/recCurrency_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/recCurrency_ENTResponse")]
        System.Collections.Generic.List<Entidades.Currency> recCurrency_ENT();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/recCurrency_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/recCurrency_ENTResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Currency>> recCurrency_ENTAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/recCurrencyXId_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/recCurrencyXId_ENTResponse")]
        Entidades.Currency recCurrencyXId_ENT(string pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/recCurrencyXId_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/recCurrencyXId_ENTResponse")]
        System.Threading.Tasks.Task<Entidades.Currency> recCurrencyXId_ENTAsync(string pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/insCurrency_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/insCurrency_ENTResponse")]
        bool insCurrency_ENT(Entidades.Currency pCurrency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/insCurrency_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/insCurrency_ENTResponse")]
        System.Threading.Tasks.Task<bool> insCurrency_ENTAsync(Entidades.Currency pCurrency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/modCurrency_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/modCurrency_ENTResponse")]
        bool modCurrency_ENT(Entidades.Currency pCurrency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/modCurrency_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/modCurrency_ENTResponse")]
        System.Threading.Tasks.Task<bool> modCurrency_ENTAsync(Entidades.Currency pCurrency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/delCurrency_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/delCurrency_ENTResponse")]
        bool delCurrency_ENT(Entidades.Currency pCurrency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvCurrency/delCurrency_ENT", ReplyAction="http://tempuri.org/IsrvCurrency/delCurrency_ENTResponse")]
        System.Threading.Tasks.Task<bool> delCurrency_ENTAsync(Entidades.Currency pCurrency);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IsrvCurrencyChannel : mvcInterfazUsuario.srvCurrency.IsrvCurrency, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IsrvCurrencyClient : System.ServiceModel.ClientBase<mvcInterfazUsuario.srvCurrency.IsrvCurrency>, mvcInterfazUsuario.srvCurrency.IsrvCurrency {
        
        public IsrvCurrencyClient() {
        }
        
        public IsrvCurrencyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IsrvCurrencyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsrvCurrencyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsrvCurrencyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Entidades.Currency> recCurrency_ENT() {
            return base.Channel.recCurrency_ENT();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Currency>> recCurrency_ENTAsync() {
            return base.Channel.recCurrency_ENTAsync();
        }
        
        public Entidades.Currency recCurrencyXId_ENT(string pId) {
            return base.Channel.recCurrencyXId_ENT(pId);
        }
        
        public System.Threading.Tasks.Task<Entidades.Currency> recCurrencyXId_ENTAsync(string pId) {
            return base.Channel.recCurrencyXId_ENTAsync(pId);
        }
        
        public bool insCurrency_ENT(Entidades.Currency pCurrency) {
            return base.Channel.insCurrency_ENT(pCurrency);
        }
        
        public System.Threading.Tasks.Task<bool> insCurrency_ENTAsync(Entidades.Currency pCurrency) {
            return base.Channel.insCurrency_ENTAsync(pCurrency);
        }
        
        public bool modCurrency_ENT(Entidades.Currency pCurrency) {
            return base.Channel.modCurrency_ENT(pCurrency);
        }
        
        public System.Threading.Tasks.Task<bool> modCurrency_ENTAsync(Entidades.Currency pCurrency) {
            return base.Channel.modCurrency_ENTAsync(pCurrency);
        }
        
        public bool delCurrency_ENT(Entidades.Currency pCurrency) {
            return base.Channel.delCurrency_ENT(pCurrency);
        }
        
        public System.Threading.Tasks.Task<bool> delCurrency_ENTAsync(Entidades.Currency pCurrency) {
            return base.Channel.delCurrency_ENTAsync(pCurrency);
        }
    }
}
