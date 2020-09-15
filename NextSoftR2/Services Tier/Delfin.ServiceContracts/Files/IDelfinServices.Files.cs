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
		
		System.Data.DataTable GetDTFiles(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Files> GetAllFilesFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Files> GetAllFiles();
		
		Files GetOneFiles(Int32 FILE_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveFiles(ref Files Item);
		#endregion
   }
}
