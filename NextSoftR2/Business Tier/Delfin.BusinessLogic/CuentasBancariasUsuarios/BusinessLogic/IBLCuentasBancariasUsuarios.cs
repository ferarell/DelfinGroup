using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCuentasBancariasUsuarios
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CuentasBancariasUsuarios> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CuentasBancariasUsuarios> GetAll();
		CuentasBancariasUsuarios GetOne(Int16 EMPR_Codigo, String CUBA_Codigo, String USER_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref CuentasBancariasUsuarios Item);
		Boolean Save(ref ObservableCollection<CuentasBancariasUsuarios> Items);
		#endregion
	}
}
