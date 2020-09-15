using System;
using System.Linq;
using System.Text;
using System.Data; 
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCab_Seguimientos
	{
		#region [ Consultas ]
      DataTable SendMail();
		#endregion
		
		#region [ Metodos ]

	    Boolean GetExisteSeguimientoOperacion(Cab_Seguimientos item);

	    #endregion
	}
}
