using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLGRR_Contrato
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<GRR_Contrato> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<GRR_Contrato> GetAll();
      GRR_Contrato GetOne(String REBA_Tipo, Int32 REBA_Codigo, Int32 CONT_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref GRR_Contrato Item);
		Boolean Save(ref ObservableCollection<GRR_Contrato> Items);
		#endregion
	}
}
