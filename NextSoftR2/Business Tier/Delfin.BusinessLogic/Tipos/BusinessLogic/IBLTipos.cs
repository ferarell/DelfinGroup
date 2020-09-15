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
	public partial interface IBLTipos
	{
		#region [ Consultas ]
		ObservableCollection<Tipos> GetAll();
		Tipos GetOne(String TIPO_CodTabla, String TIPO_CodTipo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Tipos Item);
		Boolean Save(ref ObservableCollection<Tipos> Items);
		#endregion
	}
}
