using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using System.Data;

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Cotizacion
	{
		#region [ Consultas ]
        public ObservableCollection<Det_Cotizacion> GetAllDet_CotizacionByOperacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero, Int32? x_CTAR_CodigoTransporte)
        {
            try
            {
                return SelectAllDet_CotizacionByOperacion(x_CTAR_CodigoLogistico, x_CTAR_CodigoAduanero, x_CTAR_CodigoTransporte);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataTable GetAllAyudaCotizacion(Int32? x_ENTC_CodigoCliente, Int32? x_ENTC_CodigoLNaviera, String x_NroCotizacion, String x_CTAR_Tipo, Int32 x_CCOT_Codigo)
        {
            try
            {
                return SelectAllAyudaCotizacion(x_ENTC_CodigoCliente,x_ENTC_CodigoLNaviera,x_NroCotizacion, x_CTAR_Tipo, x_CCOT_Codigo);
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
