using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLTransferencia
	{
		#region [ Consultas ]
		
		#endregion
		
		#region [ Metodos ]

      Boolean Save(ref Transferencia Item, Transferencia.TOperacion x_opcion);
		
		#endregion
	}
}