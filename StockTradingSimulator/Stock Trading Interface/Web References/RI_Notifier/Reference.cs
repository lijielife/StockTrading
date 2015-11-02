﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3053
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 2.0.50727.3053 版自动生成。
// 
#pragma warning disable 1591

namespace Stock_Trading_Simulator_Kernel.RI_Notifier {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="RI_SyncNotifySoap", Namespace="http://tempuri.org/")]
    public partial class RI_SyncNotify : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RI_UserOrders_HandledOperationCompleted;
        
        private System.Threading.SendOrPostCallback RI_ClearOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public RI_SyncNotify() {
            this.Url = global::Stock_Trading_Simulator_Kernel.Properties.Settings.Default.SimKrn_RI_Notifier_RI_SyncNotify;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event RI_UserOrders_HandledCompletedEventHandler RI_UserOrders_HandledCompleted;
        
        /// <remarks/>
        public event RI_ClearCompletedEventHandler RI_ClearCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RI_UserOrders_Handled", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RI_UserOrders_Handled(int playID, int userID, int orderID, byte result) {
            this.Invoke("RI_UserOrders_Handled", new object[] {
                        playID,
                        userID,
                        orderID,
                        result});
        }
        
        /// <remarks/>
        public void RI_UserOrders_HandledAsync(int playID, int userID, int orderID, byte result) {
            this.RI_UserOrders_HandledAsync(playID, userID, orderID, result, null);
        }
        
        /// <remarks/>
        public void RI_UserOrders_HandledAsync(int playID, int userID, int orderID, byte result, object userState) {
            if ((this.RI_UserOrders_HandledOperationCompleted == null)) {
                this.RI_UserOrders_HandledOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRI_UserOrders_HandledOperationCompleted);
            }
            this.InvokeAsync("RI_UserOrders_Handled", new object[] {
                        playID,
                        userID,
                        orderID,
                        result}, this.RI_UserOrders_HandledOperationCompleted, userState);
        }
        
        private void OnRI_UserOrders_HandledOperationCompleted(object arg) {
            if ((this.RI_UserOrders_HandledCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RI_UserOrders_HandledCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RI_Clear", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RI_Clear(int playID) {
            this.Invoke("RI_Clear", new object[] {
                        playID});
        }
        
        /// <remarks/>
        public void RI_ClearAsync(int playID) {
            this.RI_ClearAsync(playID, null);
        }
        
        /// <remarks/>
        public void RI_ClearAsync(int playID, object userState) {
            if ((this.RI_ClearOperationCompleted == null)) {
                this.RI_ClearOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRI_ClearOperationCompleted);
            }
            this.InvokeAsync("RI_Clear", new object[] {
                        playID}, this.RI_ClearOperationCompleted, userState);
        }
        
        private void OnRI_ClearOperationCompleted(object arg) {
            if ((this.RI_ClearCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RI_ClearCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void RI_UserOrders_HandledCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void RI_ClearCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591