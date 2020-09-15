using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDet_Operacion_Servicio
	{
		#region [ Consultas ]
	    DataSet GetAllServiciosAdicionalesReporte(Int32? x_ENTC_Codigo, DateTime x_COPE_FecEmiIni,DateTime x_COPE_FecEmiFin, String x_TipoReporteAdicional);
		#endregion
		
		#region [ Metodos ]

	    Boolean UpdateDetServicioOperacionPreFactura(Int32 x_COPE_Codigo, Int32 x_SOPE_Item, Int16 x_PDDO_Item,Int32 x_DOCV_Codigo, String x_CONS_CodEST);

	    #endregion
	}
}
