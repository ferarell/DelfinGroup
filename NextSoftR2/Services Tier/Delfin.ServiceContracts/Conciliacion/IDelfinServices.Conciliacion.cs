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
		
		System.Data.DataTable GetDTConciliacion(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Conciliacion> GetAllConciliacionFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Conciliacion> GetAllConciliacion();
		
		Conciliacion GetOneConciliacion(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int32 CONC_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveConciliacion(ref Conciliacion Item);
		#endregion
   }
}
