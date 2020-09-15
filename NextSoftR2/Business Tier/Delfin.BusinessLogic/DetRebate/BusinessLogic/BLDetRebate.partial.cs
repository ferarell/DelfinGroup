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
	public partial class BLDetRebate
	{
		#region [ Consultas ]
      public ObservableCollection<DetRebate> GetAllByRebate(Int32 REBA_Codigo)
      {
         try
         {
            return SelectAllByRebate(REBA_Codigo);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
