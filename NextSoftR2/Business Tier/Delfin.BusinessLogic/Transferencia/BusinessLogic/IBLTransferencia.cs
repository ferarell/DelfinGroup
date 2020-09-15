using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLTransferencia
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Transferencia> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Transferencia> GetAll();
		Transferencia GetOne(Int16 EMPR_Codigo, Int32 TRAN_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Transferencia Item);
		Boolean Save(ref ObservableCollection<Transferencia> Items);
		#endregion
	}
}
