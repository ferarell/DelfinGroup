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
	public partial interface IBLCab_Tarifa
	{
		#region [ Consultas ]
		ObservableCollection<Cab_Tarifa> GetAll();
		Cab_Tarifa GetOne(String CTAR_Tipo, Int32 CTAR_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Cab_Tarifa Item);
		Boolean Save(ref ObservableCollection<Cab_Tarifa> Items);
		#endregion
	}
}
