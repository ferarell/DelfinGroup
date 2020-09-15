using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDetPerfilAsientos
	{
		#region [ Consultas ]
		System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DetPerfilAsientos> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		ObservableCollection<DetPerfilAsientos> GetAll();
		DetPerfilAsientos GetOne(String CABP_Ano, String CABP_Codigo, Int16 DETP_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DetPerfilAsientos Item);
		Boolean Save(ref ObservableCollection<DetPerfilAsientos> Items);
		#endregion
	}
}
