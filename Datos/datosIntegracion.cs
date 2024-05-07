using PatronDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class datosIntegracion
    {
        WS_PCA.API_MostrarServicioPCA wsPca = new WS_PCA.API_MostrarServicioPCA();
        #region Tayu
        public WS_PCA.Servicio ServiciosPCA()
        {
            return wsPca.mostrarServicio();
        }
        public List<WS_PCA.MostrarPagosPCA> mostrarPagosPCAs(string cedula)
        {
            return wsPca.mostrarPagosPCAs(cedula).ToList();
        }
        public bool realizarPagosPCA(string codPago)
        {
            return wsPca.ActualizarEstado(codPago);
        }
        #endregion

        #region Amel
         WS_PIT.API_MostrarServicioPIT wsPit = new WS_PIT.API_MostrarServicioPIT();

        public WS_PIT.Servicio ServiciosPIT()
        {
            return wsPit.mostrarServicio();
        }
        public List<WS_PIT.DTOpago> mostrarPagosPITs(string cedula)
        {
            return wsPit.MostrarPagosPIT(cedula).ToList();
        }
        public bool realizarPagosPIT(string codPago)
        {
            return wsPit.ActualizarEstado(codPago);
        }

        #endregion
        #region Michael 

        WS_PAN.API_MostrarServicioPAN wsPan = new WS_PAN.API_MostrarServicioPAN();

        public WS_PAN.Servicio ServiciosPAN()
        {
            return wsPan.mostrarServicio();
        }

        public List<WS_PAN.MostrarPagosPAN> mostrarPagosPANs(string cedula)
        {
            return wsPan.mostrarPagosPANs(cedula).ToList();
        }

        public bool realizarPagosPAN(string codPago)
        {
            return wsPan.ActualizarEstado(codPago);
        }

        #endregion

        #region Cami

        WS_PTO.API_MostrarServicioPTO wsPto = new WS_PTO.API_MostrarServicioPTO();

        public WS_PTO.Servicio ServiciosPTO()
        {
            return wsPto.mostrarServicio();
        }

        public List<WS_PTO.MostrarPagosPTO> mostrarPagosPTOs(string cedula)
        {
            return wsPto.mostrarPagosPTOs(cedula).ToList();
        }

        public bool realizarPagosPTO(string codPago)
        {
            return wsPto.ActualizarEstado(codPago);
        }

        #endregion
        #region Juan David

        WS_PAL.API_MostrarServicioPAL wsPal = new WS_PAL.API_MostrarServicioPAL();

        public WS_PAL.Servicio ServiciosPAL()
        {
            return wsPal.mostrarServicio();
        }

        public List<WS_PAL.MostrarPagosPAL> mostrarPagosPALs(string cedula)
        {
            return wsPal.mostrarPagosPALs(cedula).ToList();
        }

        public bool realizarPagosPAL(string codPago)
        {
            return wsPal.ActualizarEstado(codPago);
        }

        #endregion
        #region Juan Diego 
        WS_PMX.API_MostrarServicioPMX wsPmx = new WS_PMX.API_MostrarServicioPMX();

        public WS_PMX.Servicio ServiciosPMX()
        {
            return wsPmx.mostrarServicio();
        }

        public List<WS_PMX.MostrarPagosPMX> mostrarPagosPMXs(string cedula)
        {
            return wsPmx.mostrarPagosPMXs(cedula).ToList();
        }

        public bool realizarPagosPMX(string codPago)
        {
            return wsPmx.ActualizarEstado(codPago);
        }

        #endregion

        #region Dario
        WS_PRJ.Api_Integracion wsPrj = new WS_PRJ.Api_Integracion();
        public WS_PRJ.Servicio ServiciosPRJ()
        {
            return wsPrj.mostrarServicio();
        }

        public List<WS_PRJ.DTOPago> mostrarPagosPRJs(string cedula)
        {
            return wsPrj.MostrarPagos(cedula).ToList();
        }
        public bool realizarPagos(string codPago)
        {
            return wsPrj.ActualizarEstado(codPago);
        }
        #endregion

        #region Esteban
        WS_PDT.API_MostrarPagoPDT wsPdt = new WS_PDT.API_MostrarPagoPDT();

        public WS_PDT.ServicioDTO ServiciosPDT()
        {
            return wsPdt.mostrarServicios();
        }
        public List<WS_PDT.MostrarPagosPDT> mostrarPagosPDTs(string cedula)
        {
            return wsPdt.MostrarPagosPDTPorCI(cedula).ToList();
        }

        public bool realizarPagosPDT(string codPago)
        {
            return wsPdt.ActualizarEstado(codPago);
        }

        #endregion

        #region Pato
        WS_PSM.API_MostrarServicioPSM wsPsm = new WS_PSM.API_MostrarServicioPSM();

        public WS_PSM.Servicio ServiciosPSM()
        {
            return wsPsm.mostrarServicio();
        }
        public List<WS_PSM.MostrarPagosPSM> mostrarPagosPSMs(string cedula)
        {
            return wsPsm.mostrarPagosPSMs(cedula).ToList();
        }
        /*
        public bool realizarPagosPSM(string codPago)
        {
            return wsPsm.ActualizarEstado(codPago);
        }*/

        #endregion
        #region Erick
        WS_PMA.API_MostrarServicioPMA wsPma = new WS_PMA.API_MostrarServicioPMA();
        public WS_PMA.Servicio ServiciosPMA()
        {
            return wsPma.mostrarServicio();
        }
        public List<WS_PMA.MostrarPagosPMA> mostrarPagosPMAs(string cedula)
        {
            return wsPma.mostrarPagosPMA(cedula).ToList();
        }
        public bool realizarPagosPMA(string codPago)
        {
            return wsPma.ActualizarEstado(codPago);
        }
        #endregion
        #region pupi
        public mostrarServiciosBancaWeb ServiciosMQUServ()
        {
            WS_MQUServ.APIMQU_MS tempNombreServicio = new WS_MQUServ.APIMQU_MS();

            string[] tempnombre =tempNombreServicio.MostrarDescripcion();
            mostrarServiciosBancaWeb tempServicio = new mostrarServiciosBancaWeb(tempnombre[0], tempnombre[1]);
            return tempServicio;
        }

        public bool ActualizarDatoscodpago(string codPagos)
        {
            try
            {
                WS_MQULst.APIMQU_AD tempActualizarPagos = new WS_MQULst.APIMQU_AD();
                tempActualizarPagos.ActualizarDatoscodpago(codPagos);
                return true;  // No hubo excepciones, operación exitosa.
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción de alguna manera si es necesario, como registrarla en un log.
                Console.WriteLine("Error al actualizar datos de pago: " + ex.Message);
                return false;  // Ocurrió una excepción, operación fallida.
            }
        }


        public List<mostrarPagosBancaWeb> mostrarPagosMQUServ(string cedula)
        {
            WS_MQUPGA.API_MDP temPagos = new WS_MQUPGA.API_MDP();
            var tempPagoslst = temPagos.Mandardatos(cedula).ToList();
            List<mostrarPagosBancaWeb> lstPagosBanca = new List<mostrarPagosBancaWeb>();
            mostrarPagosBancaWeb tempPagosWeb;
            foreach (var item in tempPagoslst)
            {
                tempPagosWeb = new mostrarPagosBancaWeb(item.Cedula, item.CodigoPago,(decimal) item.Monto, item.EstadoPago, item.Servicio);
                lstPagosBanca.Add(tempPagosWeb);
            }

            return lstPagosBanca;
        }

        #endregion
        #region Isaac
        WS_PSA.API_MostrarServiciosPSA wsPSA = new WS_PSA.API_MostrarServiciosPSA();
        public WS_PSA.Servicio ServiciosPSA()
        {
            return wsPSA.mostrarServicio();
        }
        public List<WS_PSA.MostrarPagosPSA> mostrarPagosPSAs(string cedula)
        {
            return wsPSA.MostrarPagosPSA(cedula).ToList();
        }
        public bool realizarPagosPSA(string codPago)
        {
            return wsPSA.ActualizarEstado(codPago);
        }
        #endregion
        #region Francisco 
        WS_PXG.API_MostrarServicioPXG wsPXG = new WS_PXG.API_MostrarServicioPXG();

        public mostrarServiciosBancaWeb ServiciosPXG()
        {
            var tempServ = wsPXG.mostrarServicio();
            mostrarServiciosBancaWeb temBanca = new mostrarServiciosBancaWeb(tempServ.Nombre, tempServ.Descripcion);
            return temBanca;
        }
        public List<mostrarPagosBancaWeb> mostrarPagosPXGs(string cedula)
        {
            var tempPagos = wsPXG.mostrarPagosPXG(cedula).ToList();
            List<mostrarPagosBancaWeb> lstPagos = new List<mostrarPagosBancaWeb>();
            mostrarPagosBancaWeb tempPago;
            foreach (var item in tempPagos)
            {
                tempPago = new mostrarPagosBancaWeb(item.cedula, item.cod_pago, item.monto, item.estado, item.nServicio);
                lstPagos.Add(tempPago);
            }
            return lstPagos;
        }

        public bool realizarPagosPXG(string codPago)
        {
            return wsPXG.actualizarEstado(codPago);
        }

        #endregion

        #region Coya
        WR_PIV.API_MostrarServicioPIV wsPiv = new WR_PIV.API_MostrarServicioPIV();
        public WR_PIV.Servicio ServiciosPIV()
        {
            return wsPiv.mostrarServicio();
        }
        public List<WR_PIV.MostrarPagosPIV> mostrarPagosPIVs(string cedula)
        {
            return wsPiv.mostrarPagosPIVs(cedula).ToList();
        }
        public bool realizarPagosPIV(string codPago)
        {
            return wsPiv.ActualizarEstado(codPago);
        }

        #endregion

        #region Pulso
        WS_PMT.API_MostrarServicioPMT wsPMT = new WS_PMT.API_MostrarServicioPMT();
        public WS_PMT.Servicio ServiciosPMT()
        {
            return wsPMT.mostrarServicio();
        }

        public List<WS_PMT.MostrarPagosPMT> mostrarPagosPMTs(string cedula)
        {
            return wsPMT.mostrarPagosPMT(cedula).ToList();
        }
        public bool realizarPagosPMT(string codPago)
        {
            return wsPMT.ActualizarEstado(codPago);
        }

        #endregion

        #region Ismael
        WS_PDS.API_MostrarServicioPDS wsPDS = new WS_PDS.API_MostrarServicioPDS();

        public WS_PDS.Servicio ServiciosPDS()
        {
            return wsPDS.mostrarServicio();
        }
        public List<WS_PDS.MostrarPagosPDS> mostrarPagosPDSs(string cedula)
        {
            long cedulaLong = long.Parse(cedula);
            return wsPDS.mostrarPagosPDSs(cedulaLong).ToList();
        }

        public bool realizarPagosPDS(string codPago)
        {
            return wsPDS.ActualizarEstado(codPago);
        }
        #endregion
        #region Sergio Davila 
        WS_PSC.API_MostrarServicioPSC wsPSC = new WS_PSC.API_MostrarServicioPSC();
        public WS_PSC.Servicio ServiciosPSC()
        {
            return wsPSC.mostrarServicio();
        }
        public List<WS_PSC.MostrarPagosPSC> mostrarPagosPSCs(string cedula)
        {
            return wsPSC.mostrarPagosPSCs(cedula).ToList();
        }
        /*
        public bool realizarPagosPSC(string codPago)
        {
            return wsPSC.(codPago);
        }*/

        #endregion
        #region Alanis
        WS_PMC.API_MostrarServicioPMC wsPmc = new WS_PMC.API_MostrarServicioPMC();

        public WS_PMC.Servicio ServiciosPMC()
        {
            return wsPmc.mostrarServicio();
        }
        public List<WS_PMC.MostrarPagosPMC> mostrarPagosPMCs(string cedula)
        {
            return wsPmc.mostrarPagosPMCs(cedula).ToList();
        }
        public bool realizarPagosPMC(string codPago)
        {
            return wsPmc.ActualizarEstado(codPago);
        }

        #endregion
        #region Arman
        WS_PIA.API_MostrarServicioPIA wsPia = new WS_PIA.API_MostrarServicioPIA();

        public WS_PIA.Servicio ServiciosPIA()
        {
            return wsPia.MostrarServicio();
        }

        public List<WS_PIA.MostrarPagoPIA> mostrarPagosPIAs(string cedula)
        {
            return wsPia.MostrarPagoPIAs(cedula).ToList();
        }

        public bool realizarPagosPIA(string codPago)
        {
            return wsPia.ActualizarEstado(codPago);
        }
        #endregion

        #region Steve el Guapo Rosero
        WS_PEO.API_MostrarServiciosPEO wsPeo = new WS_PEO.API_MostrarServiciosPEO();

        public WS_PEO.Servicio ServiciosPEO()
        {
            return wsPeo.mostrarServicio();
        }

        public List<WS_PEO.MostrarPagosPEO> mostrarPagosPEOs(string cedula)
        {
            return wsPeo.MostrarPagosPEOs(cedula).ToList();
        }

        public bool realizarPagosPEO(string codPago)
        {
            return wsPeo.ActualizarEstado(codPago);
        }
        #endregion

        #region Matew
        WS_PAH.API_MostrarServicioPAH wsPah = new WS_PAH.API_MostrarServicioPAH();
        public WS_PAH.Servicio ServiciosPAH()
        {
            return wsPah.mostrarServicio();
        }

        public List<WS_PAH.MostrarPagosPAH> mostrarPagosPAHs(string cedula)
        {
            return wsPah.mostrarPagosPCAs(cedula).ToList();
        }
        public bool realizarPagosPAH(string codPago)
        {
            return wsPah.ActualizarEstado(codPago);
        }

        #endregion
    }
}
