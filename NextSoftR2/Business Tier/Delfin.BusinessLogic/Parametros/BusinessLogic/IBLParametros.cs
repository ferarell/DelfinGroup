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
	public partial interface IBLParametros
	{
		#region [ Consultas ]
		ObservableCollection<Parametros> GetAll();
		Parametros GetOne(Int32 PARA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Parametros Item);
		Boolean Save(ref ObservableCollection<Parametros> Items);
		#endregion
	}
}
