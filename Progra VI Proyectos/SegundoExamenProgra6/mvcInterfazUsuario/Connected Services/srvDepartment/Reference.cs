//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcInterfazUsuario.srvDepartment {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srvDepartment.IsrvDeparment")]
    public interface IsrvDeparment {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/recDeparment_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/recDeparment_ENTResponse")]
        System.Collections.Generic.List<Entidades.Department> recDeparment_ENT();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/recDeparment_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/recDeparment_ENTResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Department>> recDeparment_ENTAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/recDepartmentXId_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/recDepartmentXId_ENTResponse")]
        Entidades.Department recDepartmentXId_ENT(int pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/recDepartmentXId_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/recDepartmentXId_ENTResponse")]
        System.Threading.Tasks.Task<Entidades.Department> recDepartmentXId_ENTAsync(int pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/insDepartment_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/insDepartment_ENTResponse")]
        bool insDepartment_ENT(Entidades.Department pDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/insDepartment_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/insDepartment_ENTResponse")]
        System.Threading.Tasks.Task<bool> insDepartment_ENTAsync(Entidades.Department pDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/modDepartment_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/modDepartment_ENTResponse")]
        bool modDepartment_ENT(Entidades.Department pDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/modDepartment_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/modDepartment_ENTResponse")]
        System.Threading.Tasks.Task<bool> modDepartment_ENTAsync(Entidades.Department pDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/delDepartment_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/delDepartment_ENTResponse")]
        bool delDepartment_ENT(Entidades.Department pDepartment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvDeparment/delDepartment_ENT", ReplyAction="http://tempuri.org/IsrvDeparment/delDepartment_ENTResponse")]
        System.Threading.Tasks.Task<bool> delDepartment_ENTAsync(Entidades.Department pDepartment);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IsrvDeparmentChannel : mvcInterfazUsuario.srvDepartment.IsrvDeparment, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IsrvDeparmentClient : System.ServiceModel.ClientBase<mvcInterfazUsuario.srvDepartment.IsrvDeparment>, mvcInterfazUsuario.srvDepartment.IsrvDeparment {
        
        public IsrvDeparmentClient() {
        }
        
        public IsrvDeparmentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IsrvDeparmentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsrvDeparmentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsrvDeparmentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Entidades.Department> recDeparment_ENT() {
            return base.Channel.recDeparment_ENT();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Department>> recDeparment_ENTAsync() {
            return base.Channel.recDeparment_ENTAsync();
        }
        
        public Entidades.Department recDepartmentXId_ENT(int pId) {
            return base.Channel.recDepartmentXId_ENT(pId);
        }
        
        public System.Threading.Tasks.Task<Entidades.Department> recDepartmentXId_ENTAsync(int pId) {
            return base.Channel.recDepartmentXId_ENTAsync(pId);
        }
        
        public bool insDepartment_ENT(Entidades.Department pDepartment) {
            return base.Channel.insDepartment_ENT(pDepartment);
        }
        
        public System.Threading.Tasks.Task<bool> insDepartment_ENTAsync(Entidades.Department pDepartment) {
            return base.Channel.insDepartment_ENTAsync(pDepartment);
        }
        
        public bool modDepartment_ENT(Entidades.Department pDepartment) {
            return base.Channel.modDepartment_ENT(pDepartment);
        }
        
        public System.Threading.Tasks.Task<bool> modDepartment_ENTAsync(Entidades.Department pDepartment) {
            return base.Channel.modDepartment_ENTAsync(pDepartment);
        }
        
        public bool delDepartment_ENT(Entidades.Department pDepartment) {
            return base.Channel.delDepartment_ENT(pDepartment);
        }
        
        public System.Threading.Tasks.Task<bool> delDepartment_ENTAsync(Entidades.Department pDepartment) {
            return base.Channel.delDepartment_ENTAsync(pDepartment);
        }
    }
}
