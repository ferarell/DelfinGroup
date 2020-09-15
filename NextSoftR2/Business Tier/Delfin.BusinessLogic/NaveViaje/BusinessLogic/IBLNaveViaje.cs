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
	public partial interface IBLNaveViaje
	{
		#region [ Consultas ]
		ObservableCollection<NaveViaje> GetAll();
		NaveViaje GetOne(Int32 NVIA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Int32 Save(ref NaveViaje Item);
		Boolean Save(ref ObservableCollection<NaveViaje> Items);
		#endregion
	}
}
