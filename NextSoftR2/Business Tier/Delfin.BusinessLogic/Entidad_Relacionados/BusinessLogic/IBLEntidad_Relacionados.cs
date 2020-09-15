using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLEntidad_Relacionados
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Entidad_Relacionados> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<Entidad_Relacionados> GetAll();
		Entidad_Relacionados GetOne(Int32 RELA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Entidad_Relacionados Item);
		Boolean Save(ref ObservableCollection<Entidad_Relacionados> Items);
		#endregion
	}
}
