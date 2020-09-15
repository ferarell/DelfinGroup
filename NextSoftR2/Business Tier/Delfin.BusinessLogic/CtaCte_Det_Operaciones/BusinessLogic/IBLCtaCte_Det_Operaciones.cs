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
	public partial interface IBLCtaCte_Det_Operaciones
	{
		#region [ Consultas ]
		ObservableCollection<CtaCte_Det_Operaciones> GetAll();
		CtaCte_Det_Operaciones GetOne(Int32 DCTO_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref CtaCte_Det_Operaciones Item);
		Boolean Save(ref ObservableCollection<CtaCte_Det_Operaciones> Items);
		#endregion
	}
}
