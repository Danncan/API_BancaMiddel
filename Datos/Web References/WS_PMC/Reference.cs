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

namespace Datos.WS_PMC {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="API_MostrarServicioPMCSoap", Namespace="http://tempuri.org/")]
    public partial class API_MostrarServicioPMC : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback mostrarServicioOperationCompleted;
        
        private System.Threading.SendOrPostCallback MostrarPagosPMCOperationCompleted;
        
        private System.Threading.SendOrPostCallback mostrarPagosPMCsOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarEstadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public API_MostrarServicioPMC() {
            this.Url = global::Datos.Properties.Settings.Default.Datos_WS_PMC_API_MostrarServicioPMC;
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
        public event MostrarPagosPMCCompletedEventHandler MostrarPagosPMCCompleted;
        
        /// <remarks/>
        public event mostrarPagosPMCsCompletedEventHandler mostrarPagosPMCsCompleted;
        
        /// <remarks/>
        public event ActualizarEstadoCompletedEventHandler ActualizarEstadoCompleted;
        
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MostrarPagosPMC", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MostrarPagosPMC MostrarPagosPMC(Pago pago) {
            object[] results = this.Invoke("MostrarPagosPMC", new object[] {
                        pago});
            return ((MostrarPagosPMC)(results[0]));
        }
        
        /// <remarks/>
        public void MostrarPagosPMCAsync(Pago pago) {
            this.MostrarPagosPMCAsync(pago, null);
        }
        
        /// <remarks/>
        public void MostrarPagosPMCAsync(Pago pago, object userState) {
            if ((this.MostrarPagosPMCOperationCompleted == null)) {
                this.MostrarPagosPMCOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMostrarPagosPMCOperationCompleted);
            }
            this.InvokeAsync("MostrarPagosPMC", new object[] {
                        pago}, this.MostrarPagosPMCOperationCompleted, userState);
        }
        
        private void OnMostrarPagosPMCOperationCompleted(object arg) {
            if ((this.MostrarPagosPMCCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MostrarPagosPMCCompleted(this, new MostrarPagosPMCCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/mostrarPagosPMCs", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MostrarPagosPMC[] mostrarPagosPMCs(string CedulaCliente) {
            object[] results = this.Invoke("mostrarPagosPMCs", new object[] {
                        CedulaCliente});
            return ((MostrarPagosPMC[])(results[0]));
        }
        
        /// <remarks/>
        public void mostrarPagosPMCsAsync(string CedulaCliente) {
            this.mostrarPagosPMCsAsync(CedulaCliente, null);
        }
        
        /// <remarks/>
        public void mostrarPagosPMCsAsync(string CedulaCliente, object userState) {
            if ((this.mostrarPagosPMCsOperationCompleted == null)) {
                this.mostrarPagosPMCsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmostrarPagosPMCsOperationCompleted);
            }
            this.InvokeAsync("mostrarPagosPMCs", new object[] {
                        CedulaCliente}, this.mostrarPagosPMCsOperationCompleted, userState);
        }
        
        private void OnmostrarPagosPMCsOperationCompleted(object arg) {
            if ((this.mostrarPagosPMCsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.mostrarPagosPMCsCompleted(this, new mostrarPagosPMCsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ActualizarEstado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ActualizarEstado(string cod_pago) {
            object[] results = this.Invoke("ActualizarEstado", new object[] {
                        cod_pago});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ActualizarEstadoAsync(string cod_pago) {
            this.ActualizarEstadoAsync(cod_pago, null);
        }
        
        /// <remarks/>
        public void ActualizarEstadoAsync(string cod_pago, object userState) {
            if ((this.ActualizarEstadoOperationCompleted == null)) {
                this.ActualizarEstadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarEstadoOperationCompleted);
            }
            this.InvokeAsync("ActualizarEstado", new object[] {
                        cod_pago}, this.ActualizarEstadoOperationCompleted, userState);
        }
        
        private void OnActualizarEstadoOperationCompleted(object arg) {
            if ((this.ActualizarEstadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarEstadoCompleted(this, new ActualizarEstadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class MostrarPagosPMC {
        
        private string cedulaClienteField;
        
        private string cod_pagoField;
        
        private decimal montoField;
        
        private string estadoField;
        
        private string nServicioField;
        
        /// <remarks/>
        public string CedulaCliente {
            get {
                return this.cedulaClienteField;
            }
            set {
                this.cedulaClienteField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Proveedor {
        
        private Plan[] planField;
        
        private int idProveedorField;
        
        private string nombreProveedorField;
        
        private string fotoProveedorField;
        
        private System.Nullable<bool> activoProveedorField;
        
        /// <remarks/>
        public Plan[] Plan {
            get {
                return this.planField;
            }
            set {
                this.planField = value;
            }
        }
        
        /// <remarks/>
        public int IdProveedor {
            get {
                return this.idProveedorField;
            }
            set {
                this.idProveedorField = value;
            }
        }
        
        /// <remarks/>
        public string NombreProveedor {
            get {
                return this.nombreProveedorField;
            }
            set {
                this.nombreProveedorField = value;
            }
        }
        
        /// <remarks/>
        public string FotoProveedor {
            get {
                return this.fotoProveedorField;
            }
            set {
                this.fotoProveedorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> ActivoProveedor {
            get {
                return this.activoProveedorField;
            }
            set {
                this.activoProveedorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Plan {
        
        private Contrato[] contratoField;
        
        private Proveedor proveedorField;
        
        private int idPlanField;
        
        private string nombrePlanField;
        
        private System.Nullable<decimal> precioPlanField;
        
        private string descripcionPlanField;
        
        private string fotoPlanField;
        
        private System.Nullable<int> idProveedorField;
        
        private System.Nullable<bool> activoPlanField;
        
        /// <remarks/>
        public Contrato[] Contrato {
            get {
                return this.contratoField;
            }
            set {
                this.contratoField = value;
            }
        }
        
        /// <remarks/>
        public Proveedor Proveedor {
            get {
                return this.proveedorField;
            }
            set {
                this.proveedorField = value;
            }
        }
        
        /// <remarks/>
        public int IdPlan {
            get {
                return this.idPlanField;
            }
            set {
                this.idPlanField = value;
            }
        }
        
        /// <remarks/>
        public string NombrePlan {
            get {
                return this.nombrePlanField;
            }
            set {
                this.nombrePlanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> PrecioPlan {
            get {
                return this.precioPlanField;
            }
            set {
                this.precioPlanField = value;
            }
        }
        
        /// <remarks/>
        public string DescripcionPlan {
            get {
                return this.descripcionPlanField;
            }
            set {
                this.descripcionPlanField = value;
            }
        }
        
        /// <remarks/>
        public string FotoPlan {
            get {
                return this.fotoPlanField;
            }
            set {
                this.fotoPlanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> IdProveedor {
            get {
                return this.idProveedorField;
            }
            set {
                this.idProveedorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> ActivoPlan {
            get {
                return this.activoPlanField;
            }
            set {
                this.activoPlanField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Contrato {
        
        private Cliente clienteField;
        
        private Plan planField;
        
        private Pago[] pagoField;
        
        private int idContratoField;
        
        private System.Nullable<System.DateTime> fechaInicioContratoField;
        
        private System.Nullable<System.DateTime> fechaFinContratoField;
        
        private string cedulaClienteField;
        
        private System.Nullable<int> idPlanField;
        
        private System.Nullable<bool> activoContratoField;
        
        /// <remarks/>
        public Cliente Cliente {
            get {
                return this.clienteField;
            }
            set {
                this.clienteField = value;
            }
        }
        
        /// <remarks/>
        public Plan Plan {
            get {
                return this.planField;
            }
            set {
                this.planField = value;
            }
        }
        
        /// <remarks/>
        public Pago[] Pago {
            get {
                return this.pagoField;
            }
            set {
                this.pagoField = value;
            }
        }
        
        /// <remarks/>
        public int IdContrato {
            get {
                return this.idContratoField;
            }
            set {
                this.idContratoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> FechaInicioContrato {
            get {
                return this.fechaInicioContratoField;
            }
            set {
                this.fechaInicioContratoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> FechaFinContrato {
            get {
                return this.fechaFinContratoField;
            }
            set {
                this.fechaFinContratoField = value;
            }
        }
        
        /// <remarks/>
        public string CedulaCliente {
            get {
                return this.cedulaClienteField;
            }
            set {
                this.cedulaClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> IdPlan {
            get {
                return this.idPlanField;
            }
            set {
                this.idPlanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> ActivoContrato {
            get {
                return this.activoContratoField;
            }
            set {
                this.activoContratoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Cliente {
        
        private Contrato[] contratoField;
        
        private Pago[] pagoField;
        
        private string cedulaClienteField;
        
        private string nombreClienteField;
        
        private string apellidoClienteField;
        
        private string correoClienteField;
        
        private string direccionClienteField;
        
        private string telefonoClienteField;
        
        private System.Nullable<bool> activoClienteField;
        
        /// <remarks/>
        public Contrato[] Contrato {
            get {
                return this.contratoField;
            }
            set {
                this.contratoField = value;
            }
        }
        
        /// <remarks/>
        public Pago[] Pago {
            get {
                return this.pagoField;
            }
            set {
                this.pagoField = value;
            }
        }
        
        /// <remarks/>
        public string CedulaCliente {
            get {
                return this.cedulaClienteField;
            }
            set {
                this.cedulaClienteField = value;
            }
        }
        
        /// <remarks/>
        public string NombreCliente {
            get {
                return this.nombreClienteField;
            }
            set {
                this.nombreClienteField = value;
            }
        }
        
        /// <remarks/>
        public string ApellidoCliente {
            get {
                return this.apellidoClienteField;
            }
            set {
                this.apellidoClienteField = value;
            }
        }
        
        /// <remarks/>
        public string CorreoCliente {
            get {
                return this.correoClienteField;
            }
            set {
                this.correoClienteField = value;
            }
        }
        
        /// <remarks/>
        public string DireccionCliente {
            get {
                return this.direccionClienteField;
            }
            set {
                this.direccionClienteField = value;
            }
        }
        
        /// <remarks/>
        public string TelefonoCliente {
            get {
                return this.telefonoClienteField;
            }
            set {
                this.telefonoClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> ActivoCliente {
            get {
                return this.activoClienteField;
            }
            set {
                this.activoClienteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Pago {
        
        private Cliente clienteField;
        
        private Contrato contratoField;
        
        private int idPagoField;
        
        private System.Nullable<decimal> valorPagoField;
        
        private System.Nullable<System.DateTime> fechaPagoField;
        
        private string estadoPagoField;
        
        private string metodoPagoField;
        
        private System.Nullable<int> idContratoField;
        
        private System.Nullable<bool> activoPagoField;
        
        private string cod_pagoField;
        
        private string cedulaClienteField;
        
        /// <remarks/>
        public Cliente Cliente {
            get {
                return this.clienteField;
            }
            set {
                this.clienteField = value;
            }
        }
        
        /// <remarks/>
        public Contrato Contrato {
            get {
                return this.contratoField;
            }
            set {
                this.contratoField = value;
            }
        }
        
        /// <remarks/>
        public int IdPago {
            get {
                return this.idPagoField;
            }
            set {
                this.idPagoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> ValorPago {
            get {
                return this.valorPagoField;
            }
            set {
                this.valorPagoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> FechaPago {
            get {
                return this.fechaPagoField;
            }
            set {
                this.fechaPagoField = value;
            }
        }
        
        /// <remarks/>
        public string EstadoPago {
            get {
                return this.estadoPagoField;
            }
            set {
                this.estadoPagoField = value;
            }
        }
        
        /// <remarks/>
        public string MetodoPago {
            get {
                return this.metodoPagoField;
            }
            set {
                this.metodoPagoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> IdContrato {
            get {
                return this.idContratoField;
            }
            set {
                this.idContratoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> ActivoPago {
            get {
                return this.activoPagoField;
            }
            set {
                this.activoPagoField = value;
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
        public string CedulaCliente {
            get {
                return this.cedulaClienteField;
            }
            set {
                this.cedulaClienteField = value;
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
    public delegate void MostrarPagosPMCCompletedEventHandler(object sender, MostrarPagosPMCCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MostrarPagosPMCCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MostrarPagosPMCCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MostrarPagosPMC Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MostrarPagosPMC)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void mostrarPagosPMCsCompletedEventHandler(object sender, mostrarPagosPMCsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class mostrarPagosPMCsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal mostrarPagosPMCsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MostrarPagosPMC[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MostrarPagosPMC[])(this.results[0]));
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
}

#pragma warning restore 1591