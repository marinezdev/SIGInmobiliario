﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIG_WebApplication.Application.WSCorreo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.asae.com.mx", ConfigurationName="WSCorreo.CorreoSoap")]
    public interface CorreoSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento host del espacio de nombres http://www.asae.com.mx no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.asae.com.mx/CorreoMetPrivado", ReplyAction="*")]
        SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoResponse CorreoMetPrivado(SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.asae.com.mx/CorreoMetPrivado", ReplyAction="*")]
        System.Threading.Tasks.Task<SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoResponse> CorreoMetPrivadoAsync(SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento host del espacio de nombres http://www.asae.com.mx no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.asae.com.mx/CorreoAsaeTickets", ReplyAction="*")]
        SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsResponse CorreoAsaeTickets(SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.asae.com.mx/CorreoAsaeTickets", ReplyAction="*")]
        System.Threading.Tasks.Task<SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsResponse> CorreoAsaeTicketsAsync(SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CorreoMetPrivadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CorreoMetPrivado", Namespace="http://www.asae.com.mx", Order=0)]
        public SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequestBody Body;
        
        public CorreoMetPrivadoRequest() {
        }
        
        public CorreoMetPrivadoRequest(SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.asae.com.mx")]
    public partial class CorreoMetPrivadoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string host;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int puerto;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string contra;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string from;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Subject;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string body;
        
        public CorreoMetPrivadoRequestBody() {
        }
        
        public CorreoMetPrivadoRequestBody(string host, int puerto, string usuario, string contra, string Email, string from, string Subject, string body) {
            this.host = host;
            this.puerto = puerto;
            this.usuario = usuario;
            this.contra = contra;
            this.Email = Email;
            this.from = from;
            this.Subject = Subject;
            this.body = body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CorreoMetPrivadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CorreoMetPrivadoResponse", Namespace="http://www.asae.com.mx", Order=0)]
        public SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoResponseBody Body;
        
        public CorreoMetPrivadoResponse() {
        }
        
        public CorreoMetPrivadoResponse(SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.asae.com.mx")]
    public partial class CorreoMetPrivadoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CorreoMetPrivadoResult;
        
        public CorreoMetPrivadoResponseBody() {
        }
        
        public CorreoMetPrivadoResponseBody(string CorreoMetPrivadoResult) {
            this.CorreoMetPrivadoResult = CorreoMetPrivadoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CorreoAsaeTicketsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CorreoAsaeTickets", Namespace="http://www.asae.com.mx", Order=0)]
        public SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequestBody Body;
        
        public CorreoAsaeTicketsRequest() {
        }
        
        public CorreoAsaeTicketsRequest(SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.asae.com.mx")]
    public partial class CorreoAsaeTicketsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string host;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int puerto;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string contra;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string EmailCopia;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string from;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Subject;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string body;
        
        public CorreoAsaeTicketsRequestBody() {
        }
        
        public CorreoAsaeTicketsRequestBody(string host, int puerto, string usuario, string contra, string Email, string EmailCopia, string from, string Subject, string body) {
            this.host = host;
            this.puerto = puerto;
            this.usuario = usuario;
            this.contra = contra;
            this.Email = Email;
            this.EmailCopia = EmailCopia;
            this.from = from;
            this.Subject = Subject;
            this.body = body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CorreoAsaeTicketsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CorreoAsaeTicketsResponse", Namespace="http://www.asae.com.mx", Order=0)]
        public SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsResponseBody Body;
        
        public CorreoAsaeTicketsResponse() {
        }
        
        public CorreoAsaeTicketsResponse(SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.asae.com.mx")]
    public partial class CorreoAsaeTicketsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CorreoAsaeTicketsResult;
        
        public CorreoAsaeTicketsResponseBody() {
        }
        
        public CorreoAsaeTicketsResponseBody(string CorreoAsaeTicketsResult) {
            this.CorreoAsaeTicketsResult = CorreoAsaeTicketsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CorreoSoapChannel : SIG_WebApplication.Application.WSCorreo.CorreoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CorreoSoapClient : System.ServiceModel.ClientBase<SIG_WebApplication.Application.WSCorreo.CorreoSoap>, SIG_WebApplication.Application.WSCorreo.CorreoSoap {
        
        public CorreoSoapClient() {
        }
        
        public CorreoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CorreoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CorreoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CorreoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoResponse SIG_WebApplication.Application.WSCorreo.CorreoSoap.CorreoMetPrivado(SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequest request) {
            return base.Channel.CorreoMetPrivado(request);
        }
        
        public string CorreoMetPrivado(string host, int puerto, string usuario, string contra, string Email, string from, string Subject, string body) {
            SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequest inValue = new SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequest();
            inValue.Body = new SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequestBody();
            inValue.Body.host = host;
            inValue.Body.puerto = puerto;
            inValue.Body.usuario = usuario;
            inValue.Body.contra = contra;
            inValue.Body.Email = Email;
            inValue.Body.from = from;
            inValue.Body.Subject = Subject;
            inValue.Body.body = body;
            SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoResponse retVal = ((SIG_WebApplication.Application.WSCorreo.CorreoSoap)(this)).CorreoMetPrivado(inValue);
            return retVal.Body.CorreoMetPrivadoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoResponse> SIG_WebApplication.Application.WSCorreo.CorreoSoap.CorreoMetPrivadoAsync(SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequest request) {
            return base.Channel.CorreoMetPrivadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoResponse> CorreoMetPrivadoAsync(string host, int puerto, string usuario, string contra, string Email, string from, string Subject, string body) {
            SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequest inValue = new SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequest();
            inValue.Body = new SIG_WebApplication.Application.WSCorreo.CorreoMetPrivadoRequestBody();
            inValue.Body.host = host;
            inValue.Body.puerto = puerto;
            inValue.Body.usuario = usuario;
            inValue.Body.contra = contra;
            inValue.Body.Email = Email;
            inValue.Body.from = from;
            inValue.Body.Subject = Subject;
            inValue.Body.body = body;
            return ((SIG_WebApplication.Application.WSCorreo.CorreoSoap)(this)).CorreoMetPrivadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsResponse SIG_WebApplication.Application.WSCorreo.CorreoSoap.CorreoAsaeTickets(SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequest request) {
            return base.Channel.CorreoAsaeTickets(request);
        }
        
        public string CorreoAsaeTickets(string host, int puerto, string usuario, string contra, string Email, string EmailCopia, string from, string Subject, string body) {
            SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequest inValue = new SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequest();
            inValue.Body = new SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequestBody();
            inValue.Body.host = host;
            inValue.Body.puerto = puerto;
            inValue.Body.usuario = usuario;
            inValue.Body.contra = contra;
            inValue.Body.Email = Email;
            inValue.Body.EmailCopia = EmailCopia;
            inValue.Body.from = from;
            inValue.Body.Subject = Subject;
            inValue.Body.body = body;
            SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsResponse retVal = ((SIG_WebApplication.Application.WSCorreo.CorreoSoap)(this)).CorreoAsaeTickets(inValue);
            return retVal.Body.CorreoAsaeTicketsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsResponse> SIG_WebApplication.Application.WSCorreo.CorreoSoap.CorreoAsaeTicketsAsync(SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequest request) {
            return base.Channel.CorreoAsaeTicketsAsync(request);
        }
        
        public System.Threading.Tasks.Task<SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsResponse> CorreoAsaeTicketsAsync(string host, int puerto, string usuario, string contra, string Email, string EmailCopia, string from, string Subject, string body) {
            SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequest inValue = new SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequest();
            inValue.Body = new SIG_WebApplication.Application.WSCorreo.CorreoAsaeTicketsRequestBody();
            inValue.Body.host = host;
            inValue.Body.puerto = puerto;
            inValue.Body.usuario = usuario;
            inValue.Body.contra = contra;
            inValue.Body.Email = Email;
            inValue.Body.EmailCopia = EmailCopia;
            inValue.Body.from = from;
            inValue.Body.Subject = Subject;
            inValue.Body.body = body;
            return ((SIG_WebApplication.Application.WSCorreo.CorreoSoap)(this)).CorreoAsaeTicketsAsync(inValue);
        }
    }
}
