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
	public partial class BLServicio_Via
	{
		#region [ Consultas ]
      public ObservableCollection<Servicio_Via> GetAllByServicio(Int32 SERV_Codigo)
      {
         try
         {
            return SelectAllByServicio(SERV_Codigo);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
