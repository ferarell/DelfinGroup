using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLLoadingListDetalle
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<LoadingListDetalle> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<LoadingListDetalle> GetAll();
		LoadingListDetalle GetOne(Int32 LOAD_Codigo, Int16 LODE_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref LoadingListDetalle Item);
		Boolean Save(ref ObservableCollection<LoadingListDetalle> Items);
		#endregion
	}
}
