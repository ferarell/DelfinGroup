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
	public partial interface IBLDet_Direccionamiento
	{
		#region [ Consultas ]
      System.Data.DataTable GetDetalleForward(Int32 _Operacion);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
