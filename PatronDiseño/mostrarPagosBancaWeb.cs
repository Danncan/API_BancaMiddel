using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño
{
    public class mostrarPagosBancaWeb
    {
        public mostrarPagosBancaWeb()
        {
        }

        public mostrarPagosBancaWeb(string ci, string codPago,decimal monto ,string estado,string nServicio)
        {
            this.cedula = ci;
            this.cod_pago = codPago;
            this.monto = monto; 
            this.estado = estado;
            this.nServicio = nServicio;
        }
        public string cedula { get; set; }
        public string cod_pago { get; set; }
        public decimal monto { get; set; }
        public string estado { get; set; }
        public string nServicio { get; set; }
    }
}
