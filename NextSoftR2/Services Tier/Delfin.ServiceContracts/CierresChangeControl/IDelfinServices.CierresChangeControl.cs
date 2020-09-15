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
		System.Data.DataTable GetDTCierresChangeControl(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<CierresChangeControl> GetAllCierresChangeControlFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<CierresChangeControl> GetAllCierresChangeControl();
		[OperationContract]
		CierresChangeControl GetOneCierresChangeControl(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CHAN_Anio, String CHAN_Mes);

		#endregion

		#region [ Metodos ]
		[OperationContract]
      Boolean SaveCierresChangeControl(ref CierresChangeControl Item, ref String MensajeError);
		#endregion
   }
}
