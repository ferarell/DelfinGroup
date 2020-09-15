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
	public partial interface IBLCab_Seguimientos
	{
		#region [ Consultas ]
        ObservableCollection<Cab_Seguimientos> GetAllByCabSeguimientoByFiltros(DateTime x_CSEG_FechaEmisionIni, DateTime x_CSEG_FechaEmisionFin, String x_Nave);
		Cab_Seguimientos GetOne(Int32 CSEG_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Cab_Seguimientos Item);
		Boolean Save(ref ObservableCollection<Cab_Seguimientos> Items);
		#endregion
	}
}
