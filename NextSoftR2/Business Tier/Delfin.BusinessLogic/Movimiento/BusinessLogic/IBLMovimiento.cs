using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLMovimiento
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Movimiento> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Movimiento> GetAll();
		Movimiento GetOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Movimiento Item);
		Boolean Save(ref ObservableCollection<Movimiento> Items);
		#endregion
	}
}
