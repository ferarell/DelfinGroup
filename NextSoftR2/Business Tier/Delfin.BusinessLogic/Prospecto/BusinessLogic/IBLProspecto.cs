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
	public partial interface IBLProspecto
	{
		#region [ Consultas ]
		ObservableCollection<Prospecto> GetAll();
		Prospecto GetOne(Int32 PROS_codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Prospecto Item);
		Boolean Save(ref ObservableCollection<Prospecto> Items);
		#endregion
	}
}
