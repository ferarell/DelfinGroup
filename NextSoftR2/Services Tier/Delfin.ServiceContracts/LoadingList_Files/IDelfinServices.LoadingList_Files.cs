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
		
		System.Data.DataTable GetDTLoadingList_Files(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<LoadingList_Files> GetAllLoadingList_FilesFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<LoadingList_Files> GetAllLoadingList_Files();
		
		LoadingList_Files GetOneLoadingList_Files(Int32 LOAD_Codigo, Int32 FILE_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveLoadingList_Files(ref LoadingList_Files Item);
		#endregion
   }
}
