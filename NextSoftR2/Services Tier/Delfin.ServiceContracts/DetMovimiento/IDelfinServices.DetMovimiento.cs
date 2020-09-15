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
		
		System.Data.DataTable GetDTDetMovimiento(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<DetMovimiento> GetAllDetMovimientoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<DetMovimiento> GetAllDetMovimiento();
		
		DetMovimiento GetOneDetMovimiento(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int16 DMOV_Item);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveDetMovimiento(ref DetMovimiento Item);
		#endregion
   }
}
