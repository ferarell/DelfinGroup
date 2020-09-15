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
	public partial interface IBLCab_Tarjas
	{
		#region [ Consultas ]
		ObservableCollection<Cab_Tarjas> GetAll();
		Cab_Tarjas GetOne(Int32 TARJ_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Cab_Tarjas Item);
		Boolean Save(ref ObservableCollection<Cab_Tarjas> Items);
		#endregion
	}
}
