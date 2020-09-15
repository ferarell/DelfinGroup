using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLAnexos
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Anexos> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Anexos> GetAll();
		Anexos GetOne(Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 ANEX_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Anexos Item);
		Boolean Save(ref ObservableCollection<Anexos> Items);
		#endregion
	}
}
