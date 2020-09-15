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
	public partial interface IBLPaquete
	{
		#region [ Consultas ]
		ObservableCollection<Paquete> GetAll();
		Paquete GetOne(Int32 PACK_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Paquete Item);
		Boolean Save(ref ObservableCollection<Paquete> Items);
		#endregion
	}
}
