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
		
		System.Data.DataTable GetDTAgMaritimoEntidad(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<AgMaritimoEntidad> GetAllAgMaritimoEntidadFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<AgMaritimoEntidad> GetAllAgMaritimoEntidad();
		
		AgMaritimoEntidad GetOneAgMaritimoEntidad(Int32 AGMA_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveAgMaritimoEntidad(ref AgMaritimoEntidad Item);
		#endregion
   }
}
