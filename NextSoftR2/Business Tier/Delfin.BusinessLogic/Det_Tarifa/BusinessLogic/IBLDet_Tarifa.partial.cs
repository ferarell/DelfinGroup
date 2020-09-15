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
	public partial interface IBLDet_Tarifa
	{
		#region [ Consultas ]
        ObservableCollection<Det_Tarifa> GetAllDet_TarifaByTarifario(Int32 x_CTAR_Codigo, String x_CTAR_Tipo);
        ObservableCollection<Det_Tarifa> GetAllTarifasByCotizacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero, Int32? x_CTAR_CodigoTransporte, Boolean x_Filtros);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
