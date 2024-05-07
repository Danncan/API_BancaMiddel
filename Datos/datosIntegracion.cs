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



    }
}
