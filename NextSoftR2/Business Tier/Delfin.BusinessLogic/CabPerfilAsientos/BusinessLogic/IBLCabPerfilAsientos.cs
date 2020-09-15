using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCabPerfilAsientos
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CabPerfilAsientos> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CabPerfilAsientos> GetAll();
		CabPerfilAsientos GetOne(String CABP_Ano, String CABP_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref CabPerfilAsientos Item);
		Boolean Save(ref ObservableCollection<CabPerfilAsientos> Items);
		#endregion
	}
}
