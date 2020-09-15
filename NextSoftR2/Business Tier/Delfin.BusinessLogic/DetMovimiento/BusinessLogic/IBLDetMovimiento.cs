using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDetMovimiento
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DetMovimiento> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DetMovimiento> GetAll();
		DetMovimiento GetOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int16 DMOV_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DetMovimiento Item);
		Boolean Save(ref ObservableCollection<DetMovimiento> Items);
		#endregion
	}
}
