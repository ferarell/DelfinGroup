using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLAgMaritimoEntidad
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<AgMaritimoEntidad> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<AgMaritimoEntidad> GetAll();
		AgMaritimoEntidad GetOne(Int32 AGMA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref AgMaritimoEntidad Item);
		Boolean Save(ref ObservableCollection<AgMaritimoEntidad> Items);
		#endregion
	}
}
