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
	public partial interface IBLContrato
	{
		#region [ Consultas ]
		ObservableCollection<Contrato> GetAll(Int16 EMPR_Codigo);
      Contrato GetOne(Int16 EMPR_Codigo, Int32 CONT_Codigo);
		#endregion
		
		#region [ Metodos ]
      Int32 Save(ref Contrato Item, Boolean Tarifario);
		Boolean Save(ref ObservableCollection<Contrato> Items);
		#endregion
	}
}
