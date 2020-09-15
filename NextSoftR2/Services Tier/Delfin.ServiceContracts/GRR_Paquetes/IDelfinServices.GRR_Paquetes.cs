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
		
		System.Data.DataTable GetDTGRR_Paquetes(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<GRR_Paquetes> GetAllGRR_PaquetesFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<GRR_Paquetes> GetAllGRR_Paquetes();
		
		GRR_Paquetes GetOneGRR_Paquetes(String REBA_Tipo, Int32 REBA_Codigo, Int32 PACK_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveGRR_Paquetes(ref GRR_Paquetes Item);
		#endregion
   }
}
