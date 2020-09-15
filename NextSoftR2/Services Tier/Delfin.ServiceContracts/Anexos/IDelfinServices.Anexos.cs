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
		
		System.Data.DataTable GetDTAnexos(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Anexos> GetAllAnexosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Anexos> GetAllAnexos();
		
		Anexos GetOneAnexos(Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 ANEX_Item);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveAnexos(ref Anexos Item);
		#endregion
   }
}
