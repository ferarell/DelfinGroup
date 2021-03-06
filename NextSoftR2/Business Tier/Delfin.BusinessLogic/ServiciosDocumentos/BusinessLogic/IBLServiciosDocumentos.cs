using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLServiciosDocumentos
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<ServiciosDocumentos> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<ServiciosDocumentos> GetAll();
		ServiciosDocumentos GetOne(Int32 SERV_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref ServiciosDocumentos Item);
		Boolean Save(ref ObservableCollection<ServiciosDocumentos> Items);
		#endregion
	}
}
