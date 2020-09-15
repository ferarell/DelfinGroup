using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDet_Comision
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Det_Comision> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Det_Comision> GetAll();
		Det_Comision GetOne(Int32 COMI_Codigo, Int32 DCOM_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Comision Item);
		Boolean Save(ref ObservableCollection<Det_Comision> Items);
		#endregion
	}
}
