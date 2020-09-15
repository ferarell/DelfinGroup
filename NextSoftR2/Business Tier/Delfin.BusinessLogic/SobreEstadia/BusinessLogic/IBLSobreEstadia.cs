using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLSobreEstadia
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<SobreEstadia> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<SobreEstadia> GetAll();
		SobreEstadia GetOne(Int32 CONT_Codigo, Int16 SOES_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref SobreEstadia Item);
		Boolean Save(ref ObservableCollection<SobreEstadia> Items);
		#endregion
	}
}
