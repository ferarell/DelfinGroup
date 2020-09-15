using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLMovimientoFlujo
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<MovimientoFlujo> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<MovimientoFlujo> GetAll();
		MovimientoFlujo GetOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int16 MFLU_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref MovimientoFlujo Item);
		Boolean Save(ref ObservableCollection<MovimientoFlujo> Items);
		#endregion
	}
}
