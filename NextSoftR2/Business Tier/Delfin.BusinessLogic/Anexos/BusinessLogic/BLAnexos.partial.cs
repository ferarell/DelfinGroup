using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLAnexos
	{
		#region [ Consultas ]
      public System.Data.DataTable GetOnePrint(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int16 ANEX_Item)
      {
         try
         {
            return SelectOnePrint(CCOT_Tipo, CCOT_Numero, ANEX_Item);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
