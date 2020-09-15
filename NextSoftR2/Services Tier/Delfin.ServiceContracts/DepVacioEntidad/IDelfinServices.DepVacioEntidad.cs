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
		
		System.Data.DataTable GetDTDepVacioEntidad(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<DepVacioEntidad> GetAllDepVacioEntidadFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<DepVacioEntidad> GetAllDepVacioEntidad();
		
		DepVacioEntidad GetOneDepVacioEntidad(Int32 DEVA_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveDepVacioEntidad(ref DepVacioEntidad Item);
		#endregion
   }
}
