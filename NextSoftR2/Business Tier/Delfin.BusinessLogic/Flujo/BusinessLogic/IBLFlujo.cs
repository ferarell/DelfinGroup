using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLFlujo
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Flujo> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Flujo> GetAll();
		Flujo GetOne(Int16 EMPR_Codigo, String FLUJ_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Flujo Item);
		Boolean Save(ref ObservableCollection<Flujo> Items);
		#endregion
	}
}
