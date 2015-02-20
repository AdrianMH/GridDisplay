﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GridDisplayClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GridRow", Namespace="http://schemas.datacontract.org/2004/07/GridDislpayEntities")]
    [System.SerializableAttribute()]
    public partial class GridRow : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ArchivedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
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
        public bool Archived {
            get {
                return this.ArchivedField;
            }
            set {
                if ((this.ArchivedField.Equals(value) != true)) {
                    this.ArchivedField = value;
                    this.RaisePropertyChanged("Archived");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductDto", Namespace="http://schemas.datacontract.org/2004/07/GridDislpayEntities")]
    [System.SerializableAttribute()]
    public partial class ProductDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ArchivedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] CategoriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public bool Archived {
            get {
                return this.ArchivedField;
            }
            set {
                if ((this.ArchivedField.Equals(value) != true)) {
                    this.ArchivedField = value;
                    this.RaisePropertyChanged("Archived");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] Categories {
            get {
                return this.CategoriesField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriesField, value) != true)) {
                    this.CategoriesField = value;
                    this.RaisePropertyChanged("Categories");
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
        public decimal Price {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGridDisplay")]
    public interface IGridDisplay {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGridDisplay/GetProducts", ReplyAction="http://tempuri.org/IGridDisplay/GetProductsResponse")]
        ServiceReference1.GridRow[] GetProducts(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGridDisplay/GetProducts", ReplyAction="http://tempuri.org/IGridDisplay/GetProductsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.GridRow[]> GetProductsAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGridDisplay/Archive", ReplyAction="http://tempuri.org/IGridDisplay/ArchiveResponse")]
        void Archive(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGridDisplay/Archive", ReplyAction="http://tempuri.org/IGridDisplay/ArchiveResponse")]
        System.Threading.Tasks.Task ArchiveAsync(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGridDisplay/Create", ReplyAction="http://tempuri.org/IGridDisplay/CreateResponse")]
        void Create(ServiceReference1.ProductDto product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGridDisplay/Create", ReplyAction="http://tempuri.org/IGridDisplay/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(ServiceReference1.ProductDto product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGridDisplayChannel : ServiceReference1.IGridDisplay, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GridDisplayClient : System.ServiceModel.ClientBase<ServiceReference1.IGridDisplay>, ServiceReference1.IGridDisplay {
        
        public GridDisplayClient() {
        }
        
        public GridDisplayClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GridDisplayClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GridDisplayClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GridDisplayClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceReference1.GridRow[] GetProducts(string filter) {
            return base.Channel.GetProducts(filter);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GridRow[]> GetProductsAsync(string filter) {
            return base.Channel.GetProductsAsync(filter);
        }
        
        public void Archive(int productId) {
            base.Channel.Archive(productId);
        }
        
        public System.Threading.Tasks.Task ArchiveAsync(int productId) {
            return base.Channel.ArchiveAsync(productId);
        }
        
        public void Create(ServiceReference1.ProductDto product) {
            base.Channel.Create(product);
        }
        
        public System.Threading.Tasks.Task CreateAsync(ServiceReference1.ProductDto product) {
            return base.Channel.CreateAsync(product);
        }
    }
}
