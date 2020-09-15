using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDet_Tarifa_Servicio
	{
		#region [ Consultas ]
        ObservableCollection<Det_Tarifa_Servicio> GetAllDet_ServicioByTarifario(Int32 x_CTAR_Codigo, String x_CTAR_Tipo);
        ObservableCollection<Det_Tarifa_Servicio> GetAllServiciosTarifaByCotizacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
