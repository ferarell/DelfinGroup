using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLTipificaciones
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Tipificaciones> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Tipificaciones> GetAll();
		Tipificaciones GetOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int16 TIPD_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Tipificaciones Item);
		Boolean Save(ref ObservableCollection<Tipificaciones> Items);
		#endregion
	}
}
