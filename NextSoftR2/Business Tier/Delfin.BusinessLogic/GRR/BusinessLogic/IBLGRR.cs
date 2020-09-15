using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLGRR
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<GRR> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<GRR> GetAll();
		GRR GetOne(String REBA_Tipo, Int32 REBA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref GRR Item);
		Boolean Save(ref ObservableCollection<GRR> Items);
		#endregion
	}
}
