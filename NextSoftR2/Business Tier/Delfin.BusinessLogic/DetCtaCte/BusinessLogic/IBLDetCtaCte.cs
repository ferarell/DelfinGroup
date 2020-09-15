using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDetCtaCte
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DetCtaCte> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DetCtaCte> GetAll();
		DetCtaCte GetOne(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Int16 DCCT_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DetCtaCte Item);
		Boolean Save(ref ObservableCollection<DetCtaCte> Items);
		#endregion
	}
}
