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
		[OperationContract]
		System.Data.DataTable GetDTDetCtaCteAsientos(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<DetCtaCteAsientos> GetAllDetCtaCteAsientosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<DetCtaCteAsientos> GetAllDetCtaCteAsientos();
		[OperationContract]
		DetCtaCteAsientos GetOneDetCtaCteAsientos(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Int16 DCCA_Item);

		#endregion

		#region [ Metodos ]
		[OperationContract]
		Boolean SaveDetCtaCteAsientos(ref DetCtaCteAsientos Item);
		#endregion
   }
}
