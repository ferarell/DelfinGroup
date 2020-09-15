using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLChequera
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Chequera> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Chequera> GetAll();
		Chequera GetOne(Int16 EMPR_Codigo, Int32 CHEQ_Codigo, String CUBA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Chequera Item);
		Boolean Save(ref ObservableCollection<Chequera> Items);
		#endregion
	}
}
