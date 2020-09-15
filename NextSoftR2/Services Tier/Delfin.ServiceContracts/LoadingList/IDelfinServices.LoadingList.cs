using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
		#region [ Consultas ]
		
		System.Data.DataTable GetDTLoadingList(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<LoadingList> GetAllLoadingListFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<LoadingList> GetAllLoadingList();
		
		LoadingList GetOneLoadingList(Int32 LOAD_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveLoadingList(ref LoadingList Item);
		#endregion
   }
}
