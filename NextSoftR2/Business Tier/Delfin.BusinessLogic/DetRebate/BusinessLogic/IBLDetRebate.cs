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
	public partial interface IBLDetRebate
	{
		#region [ Consultas ]
		ObservableCollection<DetRebate> GetAll();
		DetRebate GetOne(Int32 DREB_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DetRebate Item);
		Boolean Save(ref ObservableCollection<DetRebate> Items);
		#endregion
	}
}
