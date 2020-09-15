using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLEntidadCuentaBancaria
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<EntidadCuentaBancaria> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<EntidadCuentaBancaria> GetAll();
		EntidadCuentaBancaria GetOne(Int32 ENTC_Codigo, String TIPO_TabBCO, String TIPO_CodBCO);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref EntidadCuentaBancaria Item);
		Boolean Save(ref ObservableCollection<EntidadCuentaBancaria> Items);
		#endregion
	}
}
