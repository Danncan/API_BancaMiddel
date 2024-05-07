using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Middleware;
using PatronDiseño;

namespace API_BancaIntegrada
{
    /// <summary>
    /// Summary description for Api_BancaWebIntegracion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_BancaWebIntegracion : System.Web.Services.WebService
    {
        MiddlewareAPIBanca middlewareAPIBanca = new MiddlewareAPIBanca();


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod] 

        public List<mostrarServiciosBancaWeb> lstServicios()
        {
            return middlewareAPIBanca.lstServicios();
        }
        [WebMethod]
        public List<mostrarPagosBancaWeb> lstPagosCI(string cedula, string serviceName)
        {
            return middlewareAPIBanca.lstPagosCI(cedula, serviceName);
        }
        [WebMethod]
        public bool realizarPagos(string codPago, string serviceName)
        {
            return middlewareAPIBanca.realizarPagos(codPago, serviceName);
        }
    }
}
