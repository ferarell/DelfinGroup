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
		System.Data.DataTable GetDTDetPerfilAsientos(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<DetPerfilAsientos> GetAllDetPerfilAsientosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<DetPerfilAsientos> GetAllDetPerfilAsientos();
		[OperationContract]
		DetPerfilAsientos GetOneDetPerfilAsientos(String CABP_Ano, String CABP_Codigo, Int16 DETP_Item);

		#endregion

		#region [ Metodos ]
		[OperationContract]
		Boolean SaveDetPerfilAsientos(ref DetPerfilAsientos Item);
		#endregion
   }
}
