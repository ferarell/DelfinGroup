using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLAnexos
	{
		#region [ Consultas ]
      System.Data.DataTable GetOnePrint(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int16 ANEX_Item);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
