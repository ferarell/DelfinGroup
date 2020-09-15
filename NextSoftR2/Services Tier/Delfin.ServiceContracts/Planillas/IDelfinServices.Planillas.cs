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
		
		System.Data.DataTable GetDTPlanillas(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Planillas> GetAllPlanillasFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Planillas> GetAllPlanillas();
		
		Planillas GetOnePlanillas(Int16 EMPR_Codigo, String PLAN_Tipo, String PLAN_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SavePlanillas(ref Planillas Item);
		#endregion
   }
}
