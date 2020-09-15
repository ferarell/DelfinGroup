using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLExcepciones
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Excepciones> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Excepciones> GetAll();
		Excepciones GetOne(Int32 EXCE_Interno, Int16 EMPR_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Excepciones Item);
		Boolean Save(ref ObservableCollection<Excepciones> Items);
		#endregion
	}
}
