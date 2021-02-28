﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.PlaybuhService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PlaybuhService.IServiceNetwork")]
    public interface IServiceNetwork {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/GetEmployees", ReplyAction="http://tempuri.org/IServiceNetwork/GetEmployeesResponse")]
        BLogic.Model.Employee[] GetEmployees(bool showArchive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/GetEmployees", ReplyAction="http://tempuri.org/IServiceNetwork/GetEmployeesResponse")]
        System.Threading.Tasks.Task<BLogic.Model.Employee[]> GetEmployeesAsync(bool showArchive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/AddEmployee", ReplyAction="http://tempuri.org/IServiceNetwork/AddEmployeeResponse")]
        int AddEmployee(string firstName, string lastName, string middleName, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/AddEmployee", ReplyAction="http://tempuri.org/IServiceNetwork/AddEmployeeResponse")]
        System.Threading.Tasks.Task<int> AddEmployeeAsync(string firstName, string lastName, string middleName, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/RemoveEmployee", ReplyAction="http://tempuri.org/IServiceNetwork/RemoveEmployeeResponse")]
        void RemoveEmployee(int employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/RemoveEmployee", ReplyAction="http://tempuri.org/IServiceNetwork/RemoveEmployeeResponse")]
        System.Threading.Tasks.Task RemoveEmployeeAsync(int employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/ChangeEmployeeFullName", ReplyAction="http://tempuri.org/IServiceNetwork/ChangeEmployeeFullNameResponse")]
        void ChangeEmployeeFullName(int employeeId, string firstName, string lastName, string middleName, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/ChangeEmployeeFullName", ReplyAction="http://tempuri.org/IServiceNetwork/ChangeEmployeeFullNameResponse")]
        System.Threading.Tasks.Task ChangeEmployeeFullNameAsync(int employeeId, string firstName, string lastName, string middleName, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/GetContragents", ReplyAction="http://tempuri.org/IServiceNetwork/GetContragentsResponse")]
        BLogic.Model.Contragent[] GetContragents(bool showArchive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/GetContragents", ReplyAction="http://tempuri.org/IServiceNetwork/GetContragentsResponse")]
        System.Threading.Tasks.Task<BLogic.Model.Contragent[]> GetContragentsAsync(bool showArchive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/AddContragent", ReplyAction="http://tempuri.org/IServiceNetwork/AddContragentResponse")]
        void AddContragent(string title, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/AddContragent", ReplyAction="http://tempuri.org/IServiceNetwork/AddContragentResponse")]
        System.Threading.Tasks.Task AddContragentAsync(string title, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/ChangeContragentData", ReplyAction="http://tempuri.org/IServiceNetwork/ChangeContragentDataResponse")]
        void ChangeContragentData(int contragentId, string title, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/ChangeContragentData", ReplyAction="http://tempuri.org/IServiceNetwork/ChangeContragentDataResponse")]
        System.Threading.Tasks.Task ChangeContragentDataAsync(int contragentId, string title, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/RemoveContragent", ReplyAction="http://tempuri.org/IServiceNetwork/RemoveContragentResponse")]
        void RemoveContragent(int contragentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNetwork/RemoveContragent", ReplyAction="http://tempuri.org/IServiceNetwork/RemoveContragentResponse")]
        System.Threading.Tasks.Task RemoveContragentAsync(int contragentId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceNetworkChannel : Client.PlaybuhService.IServiceNetwork, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceNetworkClient : System.ServiceModel.ClientBase<Client.PlaybuhService.IServiceNetwork>, Client.PlaybuhService.IServiceNetwork {
        
        public ServiceNetworkClient() {
        }
        
        public ServiceNetworkClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceNetworkClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNetworkClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNetworkClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BLogic.Model.Employee[] GetEmployees(bool showArchive) {
            return base.Channel.GetEmployees(showArchive);
        }
        
        public System.Threading.Tasks.Task<BLogic.Model.Employee[]> GetEmployeesAsync(bool showArchive) {
            return base.Channel.GetEmployeesAsync(showArchive);
        }
        
        public int AddEmployee(string firstName, string lastName, string middleName, string description) {
            return base.Channel.AddEmployee(firstName, lastName, middleName, description);
        }
        
        public System.Threading.Tasks.Task<int> AddEmployeeAsync(string firstName, string lastName, string middleName, string description) {
            return base.Channel.AddEmployeeAsync(firstName, lastName, middleName, description);
        }
        
        public void RemoveEmployee(int employeeId) {
            base.Channel.RemoveEmployee(employeeId);
        }
        
        public System.Threading.Tasks.Task RemoveEmployeeAsync(int employeeId) {
            return base.Channel.RemoveEmployeeAsync(employeeId);
        }
        
        public void ChangeEmployeeFullName(int employeeId, string firstName, string lastName, string middleName, string description) {
            base.Channel.ChangeEmployeeFullName(employeeId, firstName, lastName, middleName, description);
        }
        
        public System.Threading.Tasks.Task ChangeEmployeeFullNameAsync(int employeeId, string firstName, string lastName, string middleName, string description) {
            return base.Channel.ChangeEmployeeFullNameAsync(employeeId, firstName, lastName, middleName, description);
        }
        
        public BLogic.Model.Contragent[] GetContragents(bool showArchive) {
            return base.Channel.GetContragents(showArchive);
        }
        
        public System.Threading.Tasks.Task<BLogic.Model.Contragent[]> GetContragentsAsync(bool showArchive) {
            return base.Channel.GetContragentsAsync(showArchive);
        }
        
        public void AddContragent(string title, string comment) {
            base.Channel.AddContragent(title, comment);
        }
        
        public System.Threading.Tasks.Task AddContragentAsync(string title, string comment) {
            return base.Channel.AddContragentAsync(title, comment);
        }
        
        public void ChangeContragentData(int contragentId, string title, string comment) {
            base.Channel.ChangeContragentData(contragentId, title, comment);
        }
        
        public System.Threading.Tasks.Task ChangeContragentDataAsync(int contragentId, string title, string comment) {
            return base.Channel.ChangeContragentDataAsync(contragentId, title, comment);
        }
        
        public void RemoveContragent(int contragentId) {
            base.Channel.RemoveContragent(contragentId);
        }
        
        public System.Threading.Tasks.Task RemoveContragentAsync(int contragentId) {
            return base.Channel.RemoveContragentAsync(contragentId);
        }
    }
}
