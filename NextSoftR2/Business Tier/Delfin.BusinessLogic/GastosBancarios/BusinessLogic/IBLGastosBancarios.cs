using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLGastosBancarios
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<GastosBancarios> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<GastosBancarios> GetAll();
		GastosBancarios GetOne(Int16 EMPR_Codigo, Int32 TRAN_Codigo, Int32 GBAN_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref GastosBancarios Item);
		Boolean Save(ref ObservableCollection<GastosBancarios> Items);
		#endregion
	}
}
