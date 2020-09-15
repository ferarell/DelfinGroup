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
		
		System.Data.DataTable GetDTCuentaBancosUsuarios(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<CuentasBancariasUsuarios> GetAllCuentaBancosUsuariosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<CuentasBancariasUsuarios> GetAllCuentaBancosUsuarios();
		
		CuentasBancariasUsuarios GetOneCuentaBancosUsuarios(Int16 EMPR_Codigo, String CUBA_Codigo, String USER_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveCuentaBancosUsuarios(ref CuentasBancariasUsuarios Item);
		#endregion
   }
}
