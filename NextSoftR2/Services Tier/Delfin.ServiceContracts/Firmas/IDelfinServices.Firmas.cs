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
		
		System.Data.DataTable GetDTFirmas(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Firmas> GetAllFirmasFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Firmas> GetAllFirmas();
		
		Firmas GetOneFirmas(Int16 EMPR_Codigo, Int32 FIRM_Codigo, String CUBA_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveFirmas(ref Firmas Item);
		#endregion
   }
}
