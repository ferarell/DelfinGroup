using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLConciliacion
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Conciliacion> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Conciliacion> GetAll();
		Conciliacion GetOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int32 CONC_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Conciliacion Item);
		Boolean Save(ref ObservableCollection<Conciliacion> Items);
		#endregion
	}
}
