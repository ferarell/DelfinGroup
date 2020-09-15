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
		
		System.Data.DataTable GetDTLiqCtaCte(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<LiqCtaCte> GetAllLiqCtaCteFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<LiqCtaCte> GetAllLiqCtaCte();
		
		LiqCtaCte GetOneLiqCtaCte(Int16 EMPR_Codigo, String LIQU_Codigo, Int32 CCCT_Codigo, Int16 LCCC_Item);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveLiqCtaCte(ref LiqCtaCte Item);
		#endregion
   }
}
