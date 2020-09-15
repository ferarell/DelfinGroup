using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLMovimiento
	{
		#region [ Consultas ]

	   Movimiento GetOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Entities.Movimiento.TInterfazMovimiento x_opcion);

		#endregion
		
		#region [ Metodos ]

	   Boolean Save(ref Movimiento Item, Entities.Movimiento.TInterfazMovimiento x_opcion);

      Boolean Save(ref ObservableCollection<Movimiento> Items, Movimiento.TInterfazMovimientos x_opcion);

	   Boolean SaveAnular(ref Movimiento Item);

	   #endregion
	}
}
