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
      ObservableCollection<DetRebate> GetAllByRebate(Int32 REBA_Codigo);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
