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
	public partial interface IBLCab_Cotizacion
	{
		#region [ Consultas ]
      System.Data.DataTable PrintCotizacion(Int32 x_CCOT_Codigo);
		#endregion
		
		#region [ Metodos ]
        Boolean AprobarAnularCotizacion(Int32 x_CCOT_Codigo, String x_Estado, String x_AUDI_UsrMod);
		#endregion
	}
}
