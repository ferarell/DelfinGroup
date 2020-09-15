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
		System.Data.DataTable GetDTTipificaciones(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<Tipificaciones> GetAllTipificacionesFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<Tipificaciones> GetAllTipificaciones();
		[OperationContract]
		Tipificaciones GetOneTipificaciones(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int16 TIPD_Item);

		#endregion

		#region [ Metodos ]
		[OperationContract]
		Boolean SaveTipificaciones(ref Tipificaciones Item);
		#endregion
   }
}
