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
		
		System.Data.DataTable GetDTChequera(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Chequera> GetAllChequeraFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Chequera> GetAllChequera();
		
		Chequera GetOneChequera(Int16 EMPR_Codigo, Int32 CHEQ_Codigo, String CUBA_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveChequera(ref Chequera Item);
		#endregion
   }
}
