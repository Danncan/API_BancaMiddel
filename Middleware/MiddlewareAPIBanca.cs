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

            var tempPSM = datosIntegracion.ServiciosPSM();
            servicios = new mostrarServiciosBancaWeb(tempPSM.Nombre, tempPSM.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPSA= datosIntegracion.ServiciosPSA();
            servicios = new mostrarServiciosBancaWeb(tempPSA.Nombre, tempPSA.Descripcion);
            lstServiciosBanca.Add(servicios);

            var temMQUServ = datosIntegracion.ServiciosMQUServ();
            lstServiciosBanca.Add(temMQUServ);

            var tempPMA = datosIntegracion.ServiciosPMA();
            servicios = new mostrarServiciosBancaWeb(tempPMA.Nombre, tempPMA.Descripcion);
            lstServiciosBanca.Add(servicios);

            var temPXG = datosIntegracion.ServiciosPXG();
            servicios = new mostrarServiciosBancaWeb(temPXG.Nombre, temPXG.Descripcion);
            lstServiciosBanca.Add(servicios);

            var temPIV = datosIntegracion.ServiciosPIV();
            servicios = new mostrarServiciosBancaWeb(temPIV.Nombre, temPIV.Descripcion);
            lstServiciosBanca.Add(servicios);
            var temPMT = datosIntegracion.ServiciosPMT();
            servicios = new mostrarServiciosBancaWeb(temPMT.Nombre, temPMT.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPDS= datosIntegracion.ServiciosPDS();
            servicios = new mostrarServiciosBancaWeb(tempPDS.Nombre, tempPDS.Descripcion);
            lstServiciosBanca.Add(servicios);

            var temPSC= datosIntegracion.ServiciosPSC();
            servicios = new mostrarServiciosBancaWeb(temPSC.Nombre, temPSC.Descripcion);
            lstServiciosBanca.Add(servicios);

            var temPMC = datosIntegracion.ServiciosPMC();
            servicios = new mostrarServiciosBancaWeb(temPMC.Nombre, temPMC.Descripcion);
            lstServiciosBanca.Add(servicios);

            var temPIA = datosIntegracion.ServiciosPIA();
            servicios = new mostrarServiciosBancaWeb(temPIA.Nombre, temPIA.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPEO = datosIntegracion.ServiciosPEO();
            servicios = new mostrarServiciosBancaWeb(tempPEO.Nombre, tempPEO.Descripcion);
            lstServiciosBanca.Add(servicios);

            var tempPAH= datosIntegracion.ServiciosPAH();
            servicios= new mostrarServiciosBancaWeb(tempPAH.Nombre, tempPAH.Descripcion);
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
                case "Pago de Suscripcion de Musica":
                    var tempPagosPSM = datosIntegracion.mostrarPagosPSMs(cedula);
                    foreach (var item in tempPagosPSM)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago Membresia":
                   var temoPagosPMA = datosIntegracion.mostrarPagosPMAs(cedula);
                    foreach (var item in temoPagosPMA)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "MetroQuito":
                    var temPagosMQUServ = datosIntegracion.mostrarPagosMQUServ(cedula);
                    foreach (var item in temPagosMQUServ)
                    {
                        lstPagosBanca.Add(item);
                    }
                    break;
                case "Pago de Agua Potable":
                    var temPagosPSA = datosIntegracion.mostrarPagosPSAs(cedula);
                    foreach (var item in temPagosPSA)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago,(decimal) item.monto, item.estado, item.nServcio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Xbox Game Pass":
                    var temPagosPXG = datosIntegracion.mostrarPagosPXGs(cedula);
                    foreach (var item in temPagosPXG)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago de Impuesto":
                    var temPagosPI = datosIntegracion.mostrarPagosPIVs(cedula);
                    foreach (var item in temPagosPI)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago de Multas de Transito":
                    var temPagosPMT = datosIntegracion.mostrarPagosPMTs(cedula);
                    foreach (var item in temPagosPMT)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago de Seguros":
                    var temPagosPDS = datosIntegracion.mostrarPagosPDSs(cedula);
                    foreach (var item in temPagosPDS)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula.ToString(), item.codpago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago de Servicio de Courier":
                    var temPagosPSC = datosIntegracion.mostrarPagosPSCs(cedula);
                    foreach (var item in temPagosPSC)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula.ToString(), item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago de Mustas CNE":
                    var temPagosPMC = datosIntegracion.mostrarPagosPMCs(cedula);
                    foreach (var item in temPagosPMC)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.CedulaCliente, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
               
                case "Pago de Matricula de Autos":
                    var temPagosPMA = datosIntegracion.mostrarPagosPMAs(cedula);
                    foreach (var item in temPagosPMA)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Pago de Servicio Electrico":
                    var temPagosPEO = datosIntegracion.mostrarPagosPEOs(cedula);
                    foreach (var item in temPagosPEO)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, (decimal) item.monto, item.estado, item.nServcio);
                        lstPagosBanca.Add(pagos);
                    }
                    break;
                case "Reserva de Hospedake":
                    var temPagosPAH = datosIntegracion.mostrarPagosPAHs(cedula);
                    foreach (var item in temPagosPAH)
                    {
                        mostrarPagosBancaWeb pagos = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, (decimal) item.monto, item.estado, item.nServicio);
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
                /*case "Pago de Suscripcion de Musica":
                    return datosIntegracion.realizarPagosPSM(codPago);*/
                case "Pago Membresia":
                    return datosIntegracion.realizarPagosPMA(codPago);
                case "MetroQuito":
                    return datosIntegracion.ActualizarDatoscodpago(codPago);
                case "Pago de Agua Potable":
                    return datosIntegracion.realizarPagosPSA(codPago);  
                case "Xbox Game Pass":
                    return datosIntegracion.realizarPagosPXG(codPago);
                case "Pago de Impuesto":
                    return datosIntegracion.realizarPagosPIV(codPago);
                case "Pago de Multas de Transito":
                    return datosIntegracion.realizarPagosPMT(codPago);
                case "Pago de Seguros":
                    return datosIntegracion.realizarPagosPDS(codPago);
                /*case "Pago de Servicio de Courier":
                    return datosIntegracion.realizarPagosPSC(codPago);*/
                case "Pago de Mustas CNE":
                    return datosIntegracion.realizarPagosPMC(codPago);
                case "Pago de Matricula de Autos":
                    return datosIntegracion.realizarPagosPIA(codPago);
                case "Pago de Servicio Electrico":
                    return datosIntegracion.realizarPagosPEO(codPago);
                case "Reserva de Hospedake":
                    return datosIntegracion.realizarPagosPAH(codPago);
                default:
                    break;
            }
            return false;
        }
    }
}
