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
	public partial interface IBLDet_Cotizacion_Servicio
	{
		#region [ Consultas ]
      ObservableCollection<Det_Cotizacion_Servicio> GetAllByCotizacion(Int32 x_CCOT_Codigo, String x_SCOT_Tipo);
		Det_Cotizacion_Servicio GetOne(Int32 CCOT_Codigo, Int32 SCOT_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Cotizacion_Servicio Item);
		Boolean Save(ref ObservableCollection<Det_Cotizacion_Servicio> Items);
		#endregion
	}
}
