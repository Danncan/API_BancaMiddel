using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using PatronDiseño;

namespace Middleware
{
    public class MiddlewareAPIBanca
    {
        datosIntegracion datosIntegracion = new datosIntegracion();

        public List<mostrarServiciosBancaWeb> lstServicios()
        {
            var tempPCA = datosIntegracion.ServiciosPCA();
            List<mostrarServiciosBancaWeb> lstServiciosBanca = new List<mostrarServiciosBancaWeb>();
            mostrarServiciosBancaWeb servicios = new mostrarServiciosBancaWeb(tempPCA.Nombre, tempPCA.Descripcion);
            lstServiciosBanca.Add(servicios);

             var tempPit = datosIntegracion.ServiciosPIT();
            servicios = new mostrarServiciosBancaWeb(tempPit.Nombre, tempPit.Descripcion);           
            lstServiciosBanca.Add(servicios);

            var tempPan = datosIntegracion.ServiciosPAN();
            servicios = new mostrarServiciosBancaWeb(tempPan.Nombre, tempPan.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPTO = datosIntegracion.ServiciosPTO();
            servicios = new mostrarServiciosBancaWeb(tempPTO.Nombre, tempPTO.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPAL = datosIntegracion.ServiciosPAL();
            servicios = new mostrarServiciosBancaWeb(tempPAL.Nombre, tempPAL.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPMX = datosIntegracion.ServiciosPMX();
            servicios = new mostrarServiciosBancaWeb(tempPMX.Nombre, tempPMX.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPRJ= datosIntegracion.ServiciosPRJ();
            servicios = new mostrarServiciosBancaWeb(tempPRJ.Nombre, tempPRJ.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPDT = datosIntegracion.ServiciosPDT();
            servicios = new mostrarServiciosBancaWeb(tempPDT.Nombre, tempPDT.Descripcion);
            lstServiciosBanca.Add(servicios);




            return lstServiciosBanca;

        }
        public List<mostrarPagosBancaWeb> lstPagosCI(string cedula,string serviceName)
        {
            //string ci, string codPago,decimal monto ,string estado,string nServicio

            List<mostrarPagosBancaWeb> lstPagosBanca = new List<mostrarPagosBancaWeb>();
            switch (serviceName)
            {
                case "PagoColegiaturas":
                    var tempPagos = datosIntegracion.mostrarPagosPCAs(cedula);
                    foreach (var item in tempPagos)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Servicio de Internet":
                    var tempPagosPIT = datosIntegracion.mostrarPagosPITs(cedula);
                    foreach (var item in tempPagosPIT)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, (decimal) item.monto, item.estado, item.nservicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago de Almacenamiento en la nube":
                    var tempPagosPAN = datosIntegracion.mostrarPagosPANs(cedula);
                    foreach (var item in tempPagosPAN)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago de Planes de Teléfono":
                    var tempPagosPTO = datosIntegracion.mostrarPagosPTOs(cedula);
                    foreach (var item in tempPagosPTO)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago Transportes":
                    var tempPagosPDT = datosIntegracion.mostrarPagosPDTs(cedula);
                    foreach (var item in tempPagosPDT)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Suscripcion AudioLibros":
                    var tempPagosPAL = datosIntegracion.mostrarPagosPDTs(cedula);
                    foreach (var item in tempPagosPAL)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;  
                case "Pago de Suscripcion MAX":
                    var tempPagosPMX = datosIntegracion.mostrarPagosPMXs(cedula);
                    foreach (var item in tempPagosPMX)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Recarga de Juegos Gacha":
                    var tempPagosPRJ = datosIntegracion.mostrarPagosPRJs(cedula);
                    foreach (var item in tempPagosPRJ)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.Cedula, item.Cod_Pago, item.Monto, item.Estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                default:
                    break;
            }
            
            return lstPagosBanca;
        }
       
        public bool realizarPagos(string codPago,string serviceName)
        {
            switch(serviceName)
            {
                case "PagoColegiaturas":
                    return datosIntegracion.realizarPagosPCA(codPago);
                case "Servicio de Internet":
                    return datosIntegracion.realizarPagosPIT(codPago);
                default:
                    break;
                case "Pago de Almacenamiento en la nube":
                    return datosIntegracion.realizarPagosPAN(codPago);
                case "Pago de Planes de Teléfono":
                    return datosIntegracion.realizarPagosPTO(codPago);
                case "Pago Transportes":
                    return datosIntegracion.realizarPagosPDT(codPago);
                case "Suscripcion AudioLibros":
                    return datosIntegracion.realizarPagosPAL(codPago);
                case "Pago de Suscripcion MAX":
                    return datosIntegracion.realizarPagosPMX(codPago);
                case "Recarga de Juegos Gacha":
                    return datosIntegracion.realizarPagos(codPago);
            }
            return false;
        }
    }
}
