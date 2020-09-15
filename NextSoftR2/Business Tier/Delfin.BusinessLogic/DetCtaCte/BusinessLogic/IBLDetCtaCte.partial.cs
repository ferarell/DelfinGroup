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
	public partial interface IBLDetCtaCte
	{
		#region [ Consultas ]
		
		#endregion
		
		#region [ Metodos ]

      Boolean Save(ref DetCtaCte Item, DetCtaCte.TInterfazDetCtaCte x_opcion);
		
		#endregion
	}
}
