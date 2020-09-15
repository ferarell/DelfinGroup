using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLPreFacturacion
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<PreFacturacion> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<PreFacturacion> GetAll();
		PreFacturacion GetOne(String PFAC_Numero);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref PreFacturacion Item);
		Boolean Save(ref ObservableCollection<PreFacturacion> Items);
		#endregion
	}
}
