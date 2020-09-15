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
		
		System.Data.DataTable GetDTGastosBancarios(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<GastosBancarios> GetAllGastosBancariosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<GastosBancarios> GetAllGastosBancarios();
		
		GastosBancarios GetOneGastosBancarios(Int16 EMPR_Codigo, Int32 TRAN_Codigo, Int32 GBAN_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveGastosBancarios(ref GastosBancarios Item);
		#endregion
   }
}
