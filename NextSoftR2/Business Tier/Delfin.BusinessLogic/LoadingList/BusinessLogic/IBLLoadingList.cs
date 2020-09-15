using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLLoadingList
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<LoadingList> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<LoadingList> GetAll();
		LoadingList GetOne(Int32 LOAD_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref LoadingList Item);
		Boolean Save(ref ObservableCollection<LoadingList> Items);
		#endregion
	}
}
