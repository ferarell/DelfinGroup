using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLGestionVentas
	{
		#region [ Consultas ]
		ObservableCollection<GestionVentas> GetAll();
		GestionVentas GetOne(Int32 GEST_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref GestionVentas Item);
		Boolean Save(ref ObservableCollection<GestionVentas> Items);
		#endregion
	}
}
