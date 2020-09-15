using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCab_MBL
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Cab_MBL> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Cab_MBL> GetAll();
		Cab_MBL GetOne(Int32 CMBL_codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Cab_MBL Item);
		Boolean Save(ref ObservableCollection<Cab_MBL> Items);
		#endregion
	}
}
