using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLServiciosLineaNegocio
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<ServiciosLineaNegocio> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<ServiciosLineaNegocio> GetAll();
        ServiciosLineaNegocio GetOne(Int32 SERV_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref ServiciosLineaNegocio Item);
		Boolean Save(ref ObservableCollection<ServiciosLineaNegocio> Items);
		#endregion
	}
}
