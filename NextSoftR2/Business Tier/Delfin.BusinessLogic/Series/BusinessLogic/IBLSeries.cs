using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLSeries
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Series> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Series> GetAll();
		Series GetOne(Int16 EMPR_Codigo, String SERI_Serie, String TIPO_TabTDO, String TIPO_CodTDO);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Series Item);
		Boolean Save(ref ObservableCollection<Series> Items);
		#endregion
	}
}
