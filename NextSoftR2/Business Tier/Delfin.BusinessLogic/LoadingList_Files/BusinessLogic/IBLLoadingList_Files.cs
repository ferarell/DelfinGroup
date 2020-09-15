using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLLoadingList_Files
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<LoadingList_Files> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<LoadingList_Files> GetAll();
		LoadingList_Files GetOne(Int32 LOAD_Codigo, Int32 FILE_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref LoadingList_Files Item);
		Boolean Save(ref ObservableCollection<LoadingList_Files> Items);
		#endregion
	}
}
