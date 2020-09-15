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
	public partial interface IBLEntidad_Acuerdo
	{
		#region [ Consultas ]
		ObservableCollection<Entidad_Acuerdo> GetAll();
		Entidad_Acuerdo GetOne(Int32 ENTC_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Entidad_Acuerdo Item);
		Boolean Save(ref ObservableCollection<Entidad_Acuerdo> Items);
		#endregion
	}
}
