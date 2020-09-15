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
		
		System.Data.DataTable GetDTEntidadLimiteCredito(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<EntidadLimiteCredito> GetAllEntidadLimiteCreditoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<EntidadLimiteCredito> GetAllEntidadLimiteCredito();
		
		EntidadLimiteCredito GetOneEntidadLimiteCredito(Int32 ENTC_Codigo, Int16 TIPE_Codigo, String ENLI_Tipos, Int16 ENLI_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveEntidadLimiteCredito(ref EntidadLimiteCredito Item);
		#endregion
   }
}
