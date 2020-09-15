using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLGRR_Paquetes
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<GRR_Paquetes> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<GRR_Paquetes> GetAll();
		GRR_Paquetes GetOne(String REBA_Tipo, Int32 REBA_Codigo, Int32 PACK_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref GRR_Paquetes Item);
		Boolean Save(ref ObservableCollection<GRR_Paquetes> Items);
		#endregion
	}
}
