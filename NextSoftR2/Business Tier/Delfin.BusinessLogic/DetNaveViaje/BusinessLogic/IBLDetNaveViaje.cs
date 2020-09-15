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
	public partial interface IBLDetNaveViaje
	{
		#region [ Consultas ]
		ObservableCollection<DetNaveViaje> GetAll();
		DetNaveViaje GetOne(Int32 DVIA_Codigo, Int32 NVIA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DetNaveViaje Item);
		Boolean Save(ref ObservableCollection<DetNaveViaje> Items);
		#endregion
	}
}
