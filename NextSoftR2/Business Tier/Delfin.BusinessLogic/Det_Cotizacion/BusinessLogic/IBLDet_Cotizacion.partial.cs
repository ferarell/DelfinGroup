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
	public partial interface IBLDet_Cotizacion
	{
		#region [ Consultas ]
        ObservableCollection<Det_Cotizacion> GetAllDet_CotizacionByOperacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero, Int32? x_CTAR_CodigoTransporte);
        DataTable GetAllAyudaCotizacion(Int32? x_ENTC_CodigoCliente, Int32? x_ENTC_CodigoLNaviera, String x_NroCotizacion, String x_CTAR_Tipo, Int32 x_CCOT_Codigo);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
