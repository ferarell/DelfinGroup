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
		
		System.Data.DataTable GetDTDet_CNTR(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Det_CNTR> GetAllDet_CNTRFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Det_CNTR> GetAllDet_CNTR();
		
		Det_CNTR GetOneDet_CNTR(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int32 DHBL_Item);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveDet_CNTR(ref Det_CNTR Item);
		#endregion
   }
}
