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
	public partial class BLConstantes
	{
		#region [ Consultas ]
      public ObservableCollection<Constantes> GetAllByConstanteTabla(String CONS_CodTabla)
      {
         try
         {
            return SelectAllByConstantesTabla(CONS_CodTabla);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
