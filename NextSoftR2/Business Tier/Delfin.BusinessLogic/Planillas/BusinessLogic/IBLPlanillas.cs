using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLPlanillas
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Planillas> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Planillas> GetAll();
		Planillas GetOne(Int16 EMPR_Codigo, String PLAN_Tipo, String PLAN_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Planillas Item);
		Boolean Save(ref ObservableCollection<Planillas> Items);
		#endregion
	}
}
