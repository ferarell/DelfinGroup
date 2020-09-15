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
	public partial class BLParametros
	{
		#region [ Consultas ]
      public Parametros GetOneByClave(String PARA_Clave)
      {
         try
         {
            return SelectOneByClave(PARA_Clave);
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Parametros> GetAllByClave(String PARA_Clave)
      {
          try
          {
              return SelectAllByClave(PARA_Clave);
          }
          catch (Exception)
          { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
