using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLFirmas
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Firmas> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Firmas> GetAll();
		Firmas GetOne(Int16 EMPR_Codigo, Int32 FIRM_Codigo, String CUBA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Firmas Item);
		Boolean Save(ref ObservableCollection<Firmas> Items);
		#endregion
	}
}
