using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLLiqCtaCte
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<LiqCtaCte> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<LiqCtaCte> GetAll();
		LiqCtaCte GetOne(Int16 EMPR_Codigo, String LIQU_Codigo, Int32 CCCT_Codigo, Int16 LCCC_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref LiqCtaCte Item);
		Boolean Save(ref ObservableCollection<LiqCtaCte> Items);
		#endregion
	}
}
