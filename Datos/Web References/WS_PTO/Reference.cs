﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Datos.WS_PTO {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="API_MostrarServicioPTOSoap", Namespace="http://tempuri.org/")]
    public partial class API_MostrarServicioPTO : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback mostrarServicioOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarEstadoOperationCompleted;
        
        private System.Threading.SendOrPostCallback mostrarPagosPTOsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public API_MostrarServicioPTO() {
            this.Url = global::Datos.Properties.Settings.Default.Datos_WS_PTO_API_MostrarServicioPTO;
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
        public event mostrarServicioCompletedEventHandler mostrarServicioCompleted;
        
        /// <remarks/>
        public event ActualizarEstadoCompletedEventHandler ActualizarEstadoCompleted;
        
        /// <remarks/>
        public event mostrarPagosPTOsCompletedEventHandler mostrarPagosPTOsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/mostrarServicio", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Servicio mostrarServicio() {
            object[] results = this.Invoke("mostrarServicio", new object[0]);
            return ((Servicio)(results[0]));
        }
        
        /// <remarks/>
        public void mostrarServicioAsync() {
            this.mostrarServicioAsync(null);
        }
        
        /// <remarks/>
        public void mostrarServicioAsync(object userState) {
            if ((this.mostrarServicioOperationCompleted == null)) {
                this.mostrarServicioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmostrarServicioOperationCompleted);
            }
            this.InvokeAsync("mostrarServicio", new object[0], this.mostrarServicioOperationCompleted, userState);
        }
        
        private void OnmostrarServicioOperationCompleted(object arg) {
            if ((this.mostrarServicioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.mostrarServicioCompleted(this, new mostrarServicioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ActualizarEstado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ActualizarEstado(string clientes) {
            object[] results = this.Invoke("ActualizarEstado", new object[] {
                        clientes});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ActualizarEstadoAsync(string clientes) {
            this.ActualizarEstadoAsync(clientes, null);
        }
        
        /// <remarks/>
        public void ActualizarEstadoAsync(string clientes, object userState) {
            if ((this.ActualizarEstadoOperationCompleted == null)) {
                this.ActualizarEstadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarEstadoOperationCompleted);
            }
            this.InvokeAsync("ActualizarEstado", new object[] {
                        clientes}, this.ActualizarEstadoOperationCompleted, userState);
        }
        
        private void OnActualizarEstadoOperationCompleted(object arg) {
            if ((this.ActualizarEstadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarEstadoCompleted(this, new ActualizarEstadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/mostrarPagosPTOs", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MostrarPagosPTO[] mostrarPagosPTOs(string cedula) {
            object[] results = this.Invoke("mostrarPagosPTOs", new object[] {
                        cedula});
            return ((MostrarPagosPTO[])(results[0]));
        }
        
        /// <remarks/>
        public void mostrarPagosPTOsAsync(string cedula) {
            this.mostrarPagosPTOsAsync(cedula, null);
        }
        
        /// <remarks/>
        public void mostrarPagosPTOsAsync(string cedula, object userState) {
            if ((this.mostrarPagosPTOsOperationCompleted == null)) {
                this.mostrarPagosPTOsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmostrarPagosPTOsOperationCompleted);
            }
            this.InvokeAsync("mostrarPagosPTOs", new object[] {
                        cedula}, this.mostrarPagosPTOsOperationCompleted, userState);
        }
        
        private void OnmostrarPagosPTOsOperationCompleted(object arg) {
            if ((this.mostrarPagosPTOsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.mostrarPagosPTOsCompleted(this, new mostrarPagosPTOsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Servicio {
        
        private string nombreField;
        
        private string descripcionField;
        
        /// <remarks/>
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class MostrarPagosPTO {
        
        private string cedulaField;
        
        private string cod_pagoField;
        
        private decimal montoField;
        
        private string estadoField;
        
        private string nServicioField;
        
        /// <remarks/>
        public string cedula {
            get {
                return this.cedulaField;
            }
            set {
                this.cedulaField = value;
            }
        }
        
        /// <remarks/>
        public string cod_pago {
            get {
                return this.cod_pagoField;
            }
            set {
                this.cod_pagoField = value;
            }
        }
        
        /// <remarks/>
        public decimal monto {
            get {
                return this.montoField;
            }
            set {
                this.montoField = value;
            }
        }
        
        /// <remarks/>
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
        
        /// <remarks/>
        public string nServicio {
            get {
                return this.nServicioField;
            }
            set {
                this.nServicioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void mostrarServicioCompletedEventHandler(object sender, mostrarServicioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class mostrarServicioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal mostrarServicioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Servicio Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Servicio)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void ActualizarEstadoCompletedEventHandler(object sender, ActualizarEstadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ActualizarEstadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ActualizarEstadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void mostrarPagosPTOsCompletedEventHandler(object sender, mostrarPagosPTOsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class mostrarPagosPTOsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal mostrarPagosPTOsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MostrarPagosPTO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MostrarPagosPTO[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591