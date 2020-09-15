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
		
		System.Data.DataTable GetDTSobreEstadia(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<SobreEstadia> GetAllSobreEstadiaFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<SobreEstadia> GetAllSobreEstadia();
		
		SobreEstadia GetOneSobreEstadia(Int32 CONT_Codigo, Int16 SOES_Item);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveSobreEstadia(ref SobreEstadia Item);
		#endregion
   }
}
