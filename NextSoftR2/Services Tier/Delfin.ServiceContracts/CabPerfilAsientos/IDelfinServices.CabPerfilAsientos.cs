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
		System.Data.DataTable GetDTCabPerfilAsientos(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<CabPerfilAsientos> GetAllCabPerfilAsientosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<CabPerfilAsientos> GetAllCabPerfilAsientos();
		[OperationContract]
		CabPerfilAsientos GetOneCabPerfilAsientos(String CABP_Ano, String CABP_Codigo);

		#endregion

		#region [ Metodos ]
		[OperationContract]
		Boolean SaveCabPerfilAsientos(ref CabPerfilAsientos Item);
		#endregion
   }
}
