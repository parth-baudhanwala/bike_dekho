﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BikeDekho_Client.BikeDekhoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BikeClass", Namespace="http://schemas.datacontract.org/2004/07/BikeDekho_CRUD")]
    [System.SerializableAttribute()]
    public partial class BikeClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
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
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserClass", Namespace="http://schemas.datacontract.org/2004/07/BikeDekho_CRUD")]
    [System.SerializableAttribute()]
    public partial class UserClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BikeDekhoService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Register", ReplyAction="http://tempuri.org/IService/RegisterResponse")]
        int Register(string name, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Register", ReplyAction="http://tempuri.org/IService/RegisterResponse")]
        System.Threading.Tasks.Task<int> RegisterAsync(string name, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        int Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPost", ReplyAction="http://tempuri.org/IService/AddPostResponse")]
        int AddPost(string model, string company, int price, string details, byte[] data, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPost", ReplyAction="http://tempuri.org/IService/AddPostResponse")]
        System.Threading.Tasks.Task<int> AddPostAsync(string model, string company, int price, string details, byte[] data, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemovePost", ReplyAction="http://tempuri.org/IService/RemovePostResponse")]
        int RemovePost(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemovePost", ReplyAction="http://tempuri.org/IService/RemovePostResponse")]
        System.Threading.Tasks.Task<int> RemovePostAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EditPost", ReplyAction="http://tempuri.org/IService/EditPostResponse")]
        int EditPost(string model, string company, int price, string details, byte[] data, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EditPost", ReplyAction="http://tempuri.org/IService/EditPostResponse")]
        System.Threading.Tasks.Task<int> EditPostAsync(string model, string company, int price, string details, byte[] data, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FetchAllBikes", ReplyAction="http://tempuri.org/IService/FetchAllBikesResponse")]
        BikeDekho_Client.BikeDekhoService.BikeClass[] FetchAllBikes(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FetchAllBikes", ReplyAction="http://tempuri.org/IService/FetchAllBikesResponse")]
        System.Threading.Tasks.Task<BikeDekho_Client.BikeDekhoService.BikeClass[]> FetchAllBikesAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FetchAllUserBikes", ReplyAction="http://tempuri.org/IService/FetchAllUserBikesResponse")]
        BikeDekho_Client.BikeDekhoService.BikeClass[] FetchAllUserBikes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FetchAllUserBikes", ReplyAction="http://tempuri.org/IService/FetchAllUserBikesResponse")]
        System.Threading.Tasks.Task<BikeDekho_Client.BikeDekhoService.BikeClass[]> FetchAllUserBikesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUser", ReplyAction="http://tempuri.org/IService/GetUserResponse")]
        BikeDekho_Client.BikeDekhoService.UserClass GetUser(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUser", ReplyAction="http://tempuri.org/IService/GetUserResponse")]
        System.Threading.Tasks.Task<BikeDekho_Client.BikeDekhoService.UserClass> GetUserAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetImage", ReplyAction="http://tempuri.org/IService/GetImageResponse")]
        byte[] GetImage(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetImage", ReplyAction="http://tempuri.org/IService/GetImageResponse")]
        System.Threading.Tasks.Task<byte[]> GetImageAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : BikeDekho_Client.BikeDekhoService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<BikeDekho_Client.BikeDekhoService.IService>, BikeDekho_Client.BikeDekhoService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Register(string name, string email, string password) {
            return base.Channel.Register(name, email, password);
        }
        
        public System.Threading.Tasks.Task<int> RegisterAsync(string name, string email, string password) {
            return base.Channel.RegisterAsync(name, email, password);
        }
        
        public int Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
        
        public int AddPost(string model, string company, int price, string details, byte[] data, int userId) {
            return base.Channel.AddPost(model, company, price, details, data, userId);
        }
        
        public System.Threading.Tasks.Task<int> AddPostAsync(string model, string company, int price, string details, byte[] data, int userId) {
            return base.Channel.AddPostAsync(model, company, price, details, data, userId);
        }
        
        public int RemovePost(int id) {
            return base.Channel.RemovePost(id);
        }
        
        public System.Threading.Tasks.Task<int> RemovePostAsync(int id) {
            return base.Channel.RemovePostAsync(id);
        }
        
        public int EditPost(string model, string company, int price, string details, byte[] data, int id) {
            return base.Channel.EditPost(model, company, price, details, data, id);
        }
        
        public System.Threading.Tasks.Task<int> EditPostAsync(string model, string company, int price, string details, byte[] data, int id) {
            return base.Channel.EditPostAsync(model, company, price, details, data, id);
        }
        
        public BikeDekho_Client.BikeDekhoService.BikeClass[] FetchAllBikes(int userId) {
            return base.Channel.FetchAllBikes(userId);
        }
        
        public System.Threading.Tasks.Task<BikeDekho_Client.BikeDekhoService.BikeClass[]> FetchAllBikesAsync(int userId) {
            return base.Channel.FetchAllBikesAsync(userId);
        }
        
        public BikeDekho_Client.BikeDekhoService.BikeClass[] FetchAllUserBikes() {
            return base.Channel.FetchAllUserBikes();
        }
        
        public System.Threading.Tasks.Task<BikeDekho_Client.BikeDekhoService.BikeClass[]> FetchAllUserBikesAsync() {
            return base.Channel.FetchAllUserBikesAsync();
        }
        
        public BikeDekho_Client.BikeDekhoService.UserClass GetUser(int userId) {
            return base.Channel.GetUser(userId);
        }
        
        public System.Threading.Tasks.Task<BikeDekho_Client.BikeDekhoService.UserClass> GetUserAsync(int userId) {
            return base.Channel.GetUserAsync(userId);
        }
        
        public byte[] GetImage(int id) {
            return base.Channel.GetImage(id);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetImageAsync(int id) {
            return base.Channel.GetImageAsync(id);
        }
    }
}
