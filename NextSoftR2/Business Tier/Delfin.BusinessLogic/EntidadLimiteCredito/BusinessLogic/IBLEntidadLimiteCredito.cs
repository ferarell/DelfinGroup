using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLEntidadLimiteCredito
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<EntidadLimiteCredito> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<EntidadLimiteCredito> GetAll();
		EntidadLimiteCredito GetOne(Int32 ENTC_Codigo, Int16 TIPE_Codigo, String ENLI_Tipos, Int16 ENLI_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref EntidadLimiteCredito Item);
		Boolean Save(ref ObservableCollection<EntidadLimiteCredito> Items);
		#endregion
	}
}
