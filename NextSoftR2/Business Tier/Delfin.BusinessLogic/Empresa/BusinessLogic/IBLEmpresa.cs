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
	public partial interface IBLEmpresa
	{
		#region [ Consultas ]
		ObservableCollection<Empresa> GetAll();
		Empresa GetOne(Int16 EMPR_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Empresa Item);
		Boolean Save(ref ObservableCollection<Empresa> Items);
		#endregion
	}
}
