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
	public partial interface IBLTarifa
	{
		#region [ Consultas ]
		ObservableCollection<Tarifa> GetAll();
      Tarifa GetOne(Int32 TARI_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Tarifa Item, Boolean Tran = true);
		Boolean Save(ref ObservableCollection<Tarifa> Items);
		#endregion
	}
}
