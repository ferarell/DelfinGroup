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
		System.Data.DataTable GetDTFlujo(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<Flujo> GetAllFlujoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<Flujo> GetAllFlujo();
		[OperationContract]
		Flujo GetOneFlujo(Int16 EMPR_Codigo, String FLUJ_Codigo);

		#endregion

		#region [ Metodos ]
		[OperationContract]
		Boolean SaveFlujo(ref Flujo Item);
		#endregion
   }
}
