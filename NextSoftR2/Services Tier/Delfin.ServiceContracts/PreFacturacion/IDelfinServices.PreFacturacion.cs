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
		
		System.Data.DataTable GetDTPreFacturacion(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<PreFacturacion> GetAllPreFacturacionFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<PreFacturacion> GetAllPreFacturacion();
		
		PreFacturacion GetOnePreFacturacion(String PFAC_Numero);

		#endregion

		#region [ Metodos ]
		
		Boolean SavePreFacturacion(ref PreFacturacion Item);
		#endregion
   }
}
