﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34003
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Servicios/", ConfigurationName="ServiceReference1.servicio")]
    public interface servicio {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/getVersionRequest", ReplyAction="http://Servicios/servicio/getVersionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Hospital.ServiceReference1.getVersionResponse getVersion(Hospital.ServiceReference1.getVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/getVersionRequest", ReplyAction="http://Servicios/servicio/getVersionResponse")]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.getVersionResponse> getVersionAsync(Hospital.ServiceReference1.getVersionRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/operationRequest", ReplyAction="http://Servicios/servicio/operationResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Hospital.ServiceReference1.operationResponse operation(Hospital.ServiceReference1.operationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/operationRequest", ReplyAction="http://Servicios/servicio/operationResponse")]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.operationResponse> operationAsync(Hospital.ServiceReference1.operationRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/dbSintomasRequest", ReplyAction="http://Servicios/servicio/dbSintomasResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Hospital.ServiceReference1.dbSintomasResponse dbSintomas(Hospital.ServiceReference1.dbSintomasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/dbSintomasRequest", ReplyAction="http://Servicios/servicio/dbSintomasResponse")]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.dbSintomasResponse> dbSintomasAsync(Hospital.ServiceReference1.dbSintomasRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/OtroRequest", ReplyAction="http://Servicios/servicio/OtroResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Hospital.ServiceReference1.OtroResponse Otro(Hospital.ServiceReference1.OtroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/OtroRequest", ReplyAction="http://Servicios/servicio/OtroResponse")]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.OtroResponse> OtroAsync(Hospital.ServiceReference1.OtroRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/listaEnfermedadesRequest", ReplyAction="http://Servicios/servicio/listaEnfermedadesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Hospital.ServiceReference1.listaEnfermedadesResponse listaEnfermedades(Hospital.ServiceReference1.listaEnfermedadesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/listaEnfermedadesRequest", ReplyAction="http://Servicios/servicio/listaEnfermedadesResponse")]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.listaEnfermedadesResponse> listaEnfermedadesAsync(Hospital.ServiceReference1.listaEnfermedadesRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/dereRequest", ReplyAction="http://Servicios/servicio/dereResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Hospital.ServiceReference1.dereResponse dere(Hospital.ServiceReference1.dereRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicios/servicio/dereRequest", ReplyAction="http://Servicios/servicio/dereResponse")]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.dereResponse> dereAsync(Hospital.ServiceReference1.dereRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersion", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class getVersionRequest {
        
        public getVersionRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersionResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class getVersionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public getVersionResponse() {
        }
        
        public getVersionResponse(int @return) {
            this.@return = @return;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicios/")]
    public partial class resultado : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int casosField;
        
        private string municipioField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int casos {
            get {
                return this.casosField;
            }
            set {
                this.casosField = value;
                this.RaisePropertyChanged("casos");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string municipio {
            get {
                return this.municipioField;
            }
            set {
                this.municipioField = value;
                this.RaisePropertyChanged("municipio");
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicios/")]
    public partial class dato : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string dato1Field;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("dato", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string dato1 {
            get {
                return this.dato1Field;
            }
            set {
                this.dato1Field = value;
                this.RaisePropertyChanged("dato1");
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicios/")]
    public partial class sintomas : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idsintomaField;
        
        private string sintomaField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int idsintoma {
            get {
                return this.idsintomaField;
            }
            set {
                this.idsintomaField = value;
                this.RaisePropertyChanged("idsintoma");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string sintoma {
            get {
                return this.sintomaField;
            }
            set {
                this.sintomaField = value;
                this.RaisePropertyChanged("sintoma");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="operation", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class operationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int departamento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int enfermedad;
        
        public operationRequest() {
        }
        
        public operationRequest(int departamento, int enfermedad) {
            this.departamento = departamento;
            this.enfermedad = enfermedad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="operationResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class operationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Hospital.ServiceReference1.resultado[] @return;
        
        public operationResponse() {
        }
        
        public operationResponse(Hospital.ServiceReference1.resultado[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="dbSintomas", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class dbSintomasRequest {
        
        public dbSintomasRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="dbSintomasResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class dbSintomasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Hospital.ServiceReference1.sintomas[] @return;
        
        public dbSintomasResponse() {
        }
        
        public dbSintomasResponse(Hospital.ServiceReference1.sintomas[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Otro", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class OtroRequest {
        
        public OtroRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OtroResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class OtroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public OtroResponse() {
        }
        
        public OtroResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listaEnfermedades", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class listaEnfermedadesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("sintoma", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] sintoma;
        
        public listaEnfermedadesRequest() {
        }
        
        public listaEnfermedadesRequest(string[] sintoma) {
            this.sintoma = sintoma;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listaEnfermedadesResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class listaEnfermedadesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Hospital.ServiceReference1.dato[] @return;
        
        public listaEnfermedadesResponse() {
        }
        
        public listaEnfermedadesResponse(Hospital.ServiceReference1.dato[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="dere", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class dereRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int departamento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int enfermedad;
        
        public dereRequest() {
        }
        
        public dereRequest(int departamento, int enfermedad) {
            this.departamento = departamento;
            this.enfermedad = enfermedad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="dereResponse", WrapperNamespace="http://Servicios/", IsWrapped=true)]
    public partial class dereResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public dereResponse() {
        }
        
        public dereResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface servicioChannel : Hospital.ServiceReference1.servicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class servicioClient : System.ServiceModel.ClientBase<Hospital.ServiceReference1.servicio>, Hospital.ServiceReference1.servicio {
        
        public servicioClient() {
        }
        
        public servicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public servicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public servicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public servicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hospital.ServiceReference1.getVersionResponse Hospital.ServiceReference1.servicio.getVersion(Hospital.ServiceReference1.getVersionRequest request) {
            return base.Channel.getVersion(request);
        }
        
        public int getVersion() {
            Hospital.ServiceReference1.getVersionRequest inValue = new Hospital.ServiceReference1.getVersionRequest();
            Hospital.ServiceReference1.getVersionResponse retVal = ((Hospital.ServiceReference1.servicio)(this)).getVersion(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.getVersionResponse> Hospital.ServiceReference1.servicio.getVersionAsync(Hospital.ServiceReference1.getVersionRequest request) {
            return base.Channel.getVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Hospital.ServiceReference1.getVersionResponse> getVersionAsync() {
            Hospital.ServiceReference1.getVersionRequest inValue = new Hospital.ServiceReference1.getVersionRequest();
            return ((Hospital.ServiceReference1.servicio)(this)).getVersionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hospital.ServiceReference1.operationResponse Hospital.ServiceReference1.servicio.operation(Hospital.ServiceReference1.operationRequest request) {
            return base.Channel.operation(request);
        }
        
        public Hospital.ServiceReference1.resultado[] operation(int departamento, int enfermedad) {
            Hospital.ServiceReference1.operationRequest inValue = new Hospital.ServiceReference1.operationRequest();
            inValue.departamento = departamento;
            inValue.enfermedad = enfermedad;
            Hospital.ServiceReference1.operationResponse retVal = ((Hospital.ServiceReference1.servicio)(this)).operation(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.operationResponse> Hospital.ServiceReference1.servicio.operationAsync(Hospital.ServiceReference1.operationRequest request) {
            return base.Channel.operationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Hospital.ServiceReference1.operationResponse> operationAsync(int departamento, int enfermedad) {
            Hospital.ServiceReference1.operationRequest inValue = new Hospital.ServiceReference1.operationRequest();
            inValue.departamento = departamento;
            inValue.enfermedad = enfermedad;
            return ((Hospital.ServiceReference1.servicio)(this)).operationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hospital.ServiceReference1.dbSintomasResponse Hospital.ServiceReference1.servicio.dbSintomas(Hospital.ServiceReference1.dbSintomasRequest request) {
            return base.Channel.dbSintomas(request);
        }
        
        public Hospital.ServiceReference1.sintomas[] dbSintomas() {
            Hospital.ServiceReference1.dbSintomasRequest inValue = new Hospital.ServiceReference1.dbSintomasRequest();
            Hospital.ServiceReference1.dbSintomasResponse retVal = ((Hospital.ServiceReference1.servicio)(this)).dbSintomas(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.dbSintomasResponse> Hospital.ServiceReference1.servicio.dbSintomasAsync(Hospital.ServiceReference1.dbSintomasRequest request) {
            return base.Channel.dbSintomasAsync(request);
        }
        
        public System.Threading.Tasks.Task<Hospital.ServiceReference1.dbSintomasResponse> dbSintomasAsync() {
            Hospital.ServiceReference1.dbSintomasRequest inValue = new Hospital.ServiceReference1.dbSintomasRequest();
            return ((Hospital.ServiceReference1.servicio)(this)).dbSintomasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hospital.ServiceReference1.OtroResponse Hospital.ServiceReference1.servicio.Otro(Hospital.ServiceReference1.OtroRequest request) {
            return base.Channel.Otro(request);
        }
        
        public int Otro() {
            Hospital.ServiceReference1.OtroRequest inValue = new Hospital.ServiceReference1.OtroRequest();
            Hospital.ServiceReference1.OtroResponse retVal = ((Hospital.ServiceReference1.servicio)(this)).Otro(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.OtroResponse> Hospital.ServiceReference1.servicio.OtroAsync(Hospital.ServiceReference1.OtroRequest request) {
            return base.Channel.OtroAsync(request);
        }
        
        public System.Threading.Tasks.Task<Hospital.ServiceReference1.OtroResponse> OtroAsync() {
            Hospital.ServiceReference1.OtroRequest inValue = new Hospital.ServiceReference1.OtroRequest();
            return ((Hospital.ServiceReference1.servicio)(this)).OtroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hospital.ServiceReference1.listaEnfermedadesResponse Hospital.ServiceReference1.servicio.listaEnfermedades(Hospital.ServiceReference1.listaEnfermedadesRequest request) {
            return base.Channel.listaEnfermedades(request);
        }
        
        public Hospital.ServiceReference1.dato[] listaEnfermedades(string[] sintoma) {
            Hospital.ServiceReference1.listaEnfermedadesRequest inValue = new Hospital.ServiceReference1.listaEnfermedadesRequest();
            inValue.sintoma = sintoma;
            Hospital.ServiceReference1.listaEnfermedadesResponse retVal = ((Hospital.ServiceReference1.servicio)(this)).listaEnfermedades(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.listaEnfermedadesResponse> Hospital.ServiceReference1.servicio.listaEnfermedadesAsync(Hospital.ServiceReference1.listaEnfermedadesRequest request) {
            return base.Channel.listaEnfermedadesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Hospital.ServiceReference1.listaEnfermedadesResponse> listaEnfermedadesAsync(string[] sintoma) {
            Hospital.ServiceReference1.listaEnfermedadesRequest inValue = new Hospital.ServiceReference1.listaEnfermedadesRequest();
            inValue.sintoma = sintoma;
            return ((Hospital.ServiceReference1.servicio)(this)).listaEnfermedadesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hospital.ServiceReference1.dereResponse Hospital.ServiceReference1.servicio.dere(Hospital.ServiceReference1.dereRequest request) {
            return base.Channel.dere(request);
        }
        
        public string dere(int departamento, int enfermedad) {
            Hospital.ServiceReference1.dereRequest inValue = new Hospital.ServiceReference1.dereRequest();
            inValue.departamento = departamento;
            inValue.enfermedad = enfermedad;
            Hospital.ServiceReference1.dereResponse retVal = ((Hospital.ServiceReference1.servicio)(this)).dere(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Hospital.ServiceReference1.dereResponse> Hospital.ServiceReference1.servicio.dereAsync(Hospital.ServiceReference1.dereRequest request) {
            return base.Channel.dereAsync(request);
        }
        
        public System.Threading.Tasks.Task<Hospital.ServiceReference1.dereResponse> dereAsync(int departamento, int enfermedad) {
            Hospital.ServiceReference1.dereRequest inValue = new Hospital.ServiceReference1.dereRequest();
            inValue.departamento = departamento;
            inValue.enfermedad = enfermedad;
            return ((Hospital.ServiceReference1.servicio)(this)).dereAsync(inValue);
        }
    }
}
