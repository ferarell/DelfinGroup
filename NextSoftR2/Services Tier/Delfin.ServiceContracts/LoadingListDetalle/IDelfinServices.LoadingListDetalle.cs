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
		
		System.Data.DataTable GetDTLoadingListDetalle(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<LoadingListDetalle> GetAllLoadingListDetalleFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<LoadingListDetalle> GetAllLoadingListDetalle();
		
		LoadingListDetalle GetOneLoadingListDetalle(Int32 LOAD_Codigo, Int16 LODE_Item);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveLoadingListDetalle(ref LoadingListDetalle Item);
		#endregion
   }
}
