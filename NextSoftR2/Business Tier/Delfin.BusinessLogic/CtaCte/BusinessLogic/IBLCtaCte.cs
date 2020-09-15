using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCtaCte
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CtaCte> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<CtaCte> GetAll();
		CtaCte GetOne(Int16 EMPR_Codigo, Int32 CCCT_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref CtaCte Item);
        String SaveILD(ref CtaCte Item);
		Boolean Save(ref ObservableCollection<CtaCte> Items);
		#endregion
	}
}
