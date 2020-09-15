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
		
		System.Data.DataTable GetDTCab_MBL(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Cab_MBL> GetAllCab_MBLFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Cab_MBL> GetAllCab_MBL();
		
		Cab_MBL GetOneCab_MBL(Int32 CMBL_codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveCab_MBL(ref Cab_MBL Item);
		#endregion
   }
}
