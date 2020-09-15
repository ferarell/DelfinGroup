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
	public partial interface IBLSucursales
	{
		#region [ Consultas ]
		ObservableCollection<Sucursales> GetAll();
		Sucursales GetOne(Int16 SUCR_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Sucursales Item);
		Boolean Save(ref ObservableCollection<Sucursales> Items);
		#endregion
	}
}
