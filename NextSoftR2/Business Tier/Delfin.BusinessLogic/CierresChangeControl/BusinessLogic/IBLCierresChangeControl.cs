using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCierresChangeControl
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CierresChangeControl> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CierresChangeControl> GetAll();
		CierresChangeControl GetOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CHAN_Anio, String CHAN_Mes);
		#endregion
		
		#region [ Metodos ]
      Boolean Save(ref CierresChangeControl Item, ref String MensajeError);
      Boolean Save(ref ObservableCollection<CierresChangeControl> Items, ref String MensajeError);
		#endregion
	}
}
