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
		
		System.Data.DataTable GetDTCuentasBancarias(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<CuentasBancarias> GetAllCuentasBancariasFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<CuentasBancarias> GetAllCuentasBancarias();
		
		CuentasBancarias GetOneCuentasBancarias(Int16 EMPR_Codigo, String CUBA_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveCuentasBancarias(ref CuentasBancarias Item);
		#endregion
   }
}