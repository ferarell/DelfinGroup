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
	public partial interface IBLDet_Cotizacion
	{
		#region [ Consultas ]
        ObservableCollection<Det_Cotizacion> GetAllByCotizacion(Int32 x_CCOT_Codigo, String x_CTAR_Tipo);
		Det_Cotizacion GetOne(Int32 CCOT_Codigo, Int32 DCOT_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Cotizacion Item);
		Boolean Save(ref ObservableCollection<Det_Cotizacion> Items);
		#endregion
	}
}
