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
		
		System.Data.DataTable GetDTExcepciones(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Excepciones> GetAllExcepcionesFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Excepciones> GetAllExcepciones();
		
		Excepciones GetOneExcepciones(Int32 EXCE_Interno, Int16 EMPR_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveExcepciones(ref Excepciones Item);
		#endregion
   }
}
