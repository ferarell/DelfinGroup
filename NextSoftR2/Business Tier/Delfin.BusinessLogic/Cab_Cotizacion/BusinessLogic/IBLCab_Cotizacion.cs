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
	public partial interface IBLCab_Cotizacion
	{
		#region [ Consultas ]
        ObservableCollection<Cab_Cotizacion> GetAllByFiltros(Int32? x_ENTC_Codigo, String x_CCOT_NumDoc, DateTime x_CCOT_FecEmiIni, DateTime x_CCOT_FecEmiFin);
		Cab_Cotizacion GetOne(Int32 CCOT_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Cab_Cotizacion Item);
		Boolean Save(ref ObservableCollection<Cab_Cotizacion> Items);
		#endregion
	}
}
