﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flight.Provider.ProductWS.PolicyServiceNS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestBase", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkSearchRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkApplyRequest))]
    public partial class RequestBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AppIDField;
        
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
        public int AppID {
            get {
                return this.AppIDField;
            }
            set {
                if ((this.AppIDField.Equals(value) != true)) {
                    this.AppIDField = value;
                    this.RaisePropertyChanged("AppID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PolicyRemarkSearchRequest", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity.RequestDTO")]
    [System.SerializableAttribute()]
    public partial class PolicyRemarkSearchRequest : Flight.Provider.ProductWS.PolicyServiceNS.RequestBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Flight.Provider.ProductWS.PolicyServiceNS.RequestPaging PagingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PolicyTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProviderIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Flight.Provider.ProductWS.PolicyServiceNS.RequestPaging Paging {
            get {
                return this.PagingField;
            }
            set {
                if ((object.ReferenceEquals(this.PagingField, value) != true)) {
                    this.PagingField = value;
                    this.RaisePropertyChanged("Paging");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PolicyType {
            get {
                return this.PolicyTypeField;
            }
            set {
                if ((this.PolicyTypeField.Equals(value) != true)) {
                    this.PolicyTypeField = value;
                    this.RaisePropertyChanged("PolicyType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProviderId {
            get {
                return this.ProviderIdField;
            }
            set {
                if ((this.ProviderIdField.Equals(value) != true)) {
                    this.ProviderIdField = value;
                    this.RaisePropertyChanged("ProviderId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PolicyRemarkApplyRequest", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity.RequestDTO")]
    [System.SerializableAttribute()]
    public partial class PolicyRemarkApplyRequest : Flight.Provider.ProductWS.PolicyServiceNS.RequestBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkDTO PolicyRemarkField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Operate {
            get {
                return this.OperateField;
            }
            set {
                if ((object.ReferenceEquals(this.OperateField, value) != true)) {
                    this.OperateField = value;
                    this.RaisePropertyChanged("Operate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkDTO PolicyRemark {
            get {
                return this.PolicyRemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.PolicyRemarkField, value) != true)) {
                    this.PolicyRemarkField = value;
                    this.RaisePropertyChanged("PolicyRemark");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PolicyRemarkDTO", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity.RequestDTO")]
    [System.SerializableAttribute()]
    public partial class PolicyRemarkDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PolicyRemarkIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PolicyTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProviderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemarkField;
        
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
        public int PolicyRemarkId {
            get {
                return this.PolicyRemarkIdField;
            }
            set {
                if ((this.PolicyRemarkIdField.Equals(value) != true)) {
                    this.PolicyRemarkIdField = value;
                    this.RaisePropertyChanged("PolicyRemarkId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PolicyType {
            get {
                return this.PolicyTypeField;
            }
            set {
                if ((this.PolicyTypeField.Equals(value) != true)) {
                    this.PolicyTypeField = value;
                    this.RaisePropertyChanged("PolicyType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProviderId {
            get {
                return this.ProviderIdField;
            }
            set {
                if ((this.ProviderIdField.Equals(value) != true)) {
                    this.ProviderIdField = value;
                    this.RaisePropertyChanged("ProviderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark {
            get {
                return this.RemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarkField, value) != true)) {
                    this.RemarkField = value;
                    this.RaisePropertyChanged("Remark");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestPaging", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity")]
    [System.SerializableAttribute()]
    public partial class RequestPaging : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageIndexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageSizeField;
        
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
        public int PageIndex {
            get {
                return this.PageIndexField;
            }
            set {
                if ((this.PageIndexField.Equals(value) != true)) {
                    this.PageIndexField = value;
                    this.RaisePropertyChanged("PageIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageSize {
            get {
                return this.PageSizeField;
            }
            set {
                if ((this.PageSizeField.Equals(value) != true)) {
                    this.PageSizeField = value;
                    this.RaisePropertyChanged("PageSize");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseBase", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkSearchResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkApplyResponse))]
    public partial class ResponseBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrMsgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        public string ErrMsg {
            get {
                return this.ErrMsgField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrMsgField, value) != true)) {
                    this.ErrMsgField = value;
                    this.RaisePropertyChanged("ErrMsg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PolicyRemarkSearchResponse", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity.ResponseDTO")]
    [System.SerializableAttribute()]
    public partial class PolicyRemarkSearchResponse : Flight.Provider.ProductWS.PolicyServiceNS.ResponseBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkDTO> DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Flight.Provider.ProductWS.PolicyServiceNS.ResponsePaging PagingField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkDTO> Data {
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
        public Flight.Provider.ProductWS.PolicyServiceNS.ResponsePaging Paging {
            get {
                return this.PagingField;
            }
            set {
                if ((object.ReferenceEquals(this.PagingField, value) != true)) {
                    this.PagingField = value;
                    this.RaisePropertyChanged("Paging");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PolicyRemarkApplyResponse", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity.ResponseDTO")]
    [System.SerializableAttribute()]
    public partial class PolicyRemarkApplyResponse : Flight.Provider.ProductWS.PolicyServiceNS.ResponseBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponsePaging", Namespace="http://schemas.datacontract.org/2004/07/Flight.Product.Entity")]
    [System.SerializableAttribute()]
    public partial class ResponsePaging : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageIndexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalCountField;
        
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
        public int PageCount {
            get {
                return this.PageCountField;
            }
            set {
                if ((this.PageCountField.Equals(value) != true)) {
                    this.PageCountField = value;
                    this.RaisePropertyChanged("PageCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageIndex {
            get {
                return this.PageIndexField;
            }
            set {
                if ((this.PageIndexField.Equals(value) != true)) {
                    this.PageIndexField = value;
                    this.RaisePropertyChanged("PageIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageSize {
            get {
                return this.PageSizeField;
            }
            set {
                if ((this.PageSizeField.Equals(value) != true)) {
                    this.PageSizeField = value;
                    this.RaisePropertyChanged("PageSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalCount {
            get {
                return this.TotalCountField;
            }
            set {
                if ((this.TotalCountField.Equals(value) != true)) {
                    this.TotalCountField = value;
                    this.RaisePropertyChanged("TotalCount");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PolicyServiceNS.IPolicyService")]
    public interface IPolicyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyService/GetString", ReplyAction="http://tempuri.org/IPolicyService/GetStringResponse")]
        string GetString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyService/PolicyRemarkApply", ReplyAction="http://tempuri.org/IPolicyService/PolicyRemarkApplyResponse")]
        Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkApplyResponse PolicyRemarkApply(Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkApplyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolicyService/PolicyRemarkSearch", ReplyAction="http://tempuri.org/IPolicyService/PolicyRemarkSearchResponse")]
        Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkSearchResponse PolicyRemarkSearch(Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkSearchRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPolicyServiceChannel : Flight.Provider.ProductWS.PolicyServiceNS.IPolicyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PolicyServiceClient : System.ServiceModel.ClientBase<Flight.Provider.ProductWS.PolicyServiceNS.IPolicyService>, Flight.Provider.ProductWS.PolicyServiceNS.IPolicyService {
        
        public PolicyServiceClient() {
        }
        
        public PolicyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PolicyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolicyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolicyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetString() {
            return base.Channel.GetString();
        }
        
        public Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkApplyResponse PolicyRemarkApply(Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkApplyRequest request) {
            return base.Channel.PolicyRemarkApply(request);
        }
        
        public Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkSearchResponse PolicyRemarkSearch(Flight.Provider.ProductWS.PolicyServiceNS.PolicyRemarkSearchRequest request) {
            return base.Channel.PolicyRemarkSearch(request);
        }
    }
}
