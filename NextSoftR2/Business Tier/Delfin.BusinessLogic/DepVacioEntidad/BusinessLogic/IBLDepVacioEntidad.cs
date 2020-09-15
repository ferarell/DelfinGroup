using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDepVacioEntidad
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DepVacioEntidad> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DepVacioEntidad> GetAll();
		DepVacioEntidad GetOne(Int32 DEVA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DepVacioEntidad Item);
		Boolean Save(ref ObservableCollection<DepVacioEntidad> Items);
		#endregion
	}
}
