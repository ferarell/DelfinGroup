using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLLiquidacion
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Liquidacion> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Liquidacion> GetAll();
		Liquidacion GetOne(Int16 EMPR_Codigo, String LIQU_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Liquidacion Item);
		Boolean Save(ref ObservableCollection<Liquidacion> Items);
		#endregion
	}
}
