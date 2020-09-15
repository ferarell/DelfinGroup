using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCuentasBancarias
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CuentasBancarias> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CuentasBancarias> GetAll();
		CuentasBancarias GetOne(Int16 EMPR_Codigo, String CUBA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref CuentasBancarias Item);
		Boolean Save(ref ObservableCollection<CuentasBancarias> Items);
		#endregion
	}
}
