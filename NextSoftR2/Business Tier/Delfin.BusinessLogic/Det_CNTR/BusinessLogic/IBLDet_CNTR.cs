using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDet_CNTR
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Det_CNTR> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Det_CNTR> GetAll();
		Det_CNTR GetOne(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int32 DHBL_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_CNTR Item);
		Boolean Save(ref ObservableCollection<Det_CNTR> Items);
		#endregion
	}
}
