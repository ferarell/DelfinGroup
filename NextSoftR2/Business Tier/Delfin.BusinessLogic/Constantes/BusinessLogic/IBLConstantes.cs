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
	public partial interface IBLConstantes
	{
		#region [ Consultas ]
		ObservableCollection<Constantes> GetAll();
		Constantes GetOne(String CONS_CodTabla, String CONS_CodTipo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Constantes Item);
		Boolean Save(ref ObservableCollection<Constantes> Items);
		#endregion
	}
}
