using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDetCtaCteAsientos
	{
		#region [ Consultas ]
		
		#endregion
		
		#region [ Metodos ]

      Boolean DeleteForCtaCte(Int16 EMPR_Codigo, Int32 CCCT_Codigo);

		#endregion
	}
}
