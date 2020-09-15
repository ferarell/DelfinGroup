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
	public partial class BLTiposEntidad
	{
		#region [ Consultas ]
      public ObservableCollection<TiposEntidad> GetTodos()
      {
         try
         {
            return SelectTodos();
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
