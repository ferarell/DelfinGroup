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
		
		System.Data.DataTable GetDTDet_Comision(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Det_Comision> GetAllDet_ComisionFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Det_Comision> GetAllDet_Comision();
		
		Det_Comision GetOneDet_Comision(Int32 COMI_Codigo, Int32 DCOM_Item);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveDet_Comision(ref Det_Comision Item);
		#endregion
   }
}
