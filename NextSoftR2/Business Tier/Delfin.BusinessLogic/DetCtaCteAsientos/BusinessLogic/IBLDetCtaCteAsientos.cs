using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDetCtaCteAsientos
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DetCtaCteAsientos> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DetCtaCteAsientos> GetAll();
		DetCtaCteAsientos GetOne(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Int16 DCCA_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DetCtaCteAsientos Item);
		Boolean Save(ref ObservableCollection<DetCtaCteAsientos> Items);
		#endregion
	}
}
