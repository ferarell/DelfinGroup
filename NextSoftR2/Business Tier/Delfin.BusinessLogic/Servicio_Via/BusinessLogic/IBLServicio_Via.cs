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
	public partial interface IBLServicio_Via
	{
		#region [ Consultas ]
		ObservableCollection<Servicio_Via> GetAll();
		Servicio_Via GetOne(String CONS_TabVIA, String CONS_CodVIA, Int32 SERV_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Servicio_Via Item);
		Boolean Save(ref ObservableCollection<Servicio_Via> Items);
		#endregion
	}
}
