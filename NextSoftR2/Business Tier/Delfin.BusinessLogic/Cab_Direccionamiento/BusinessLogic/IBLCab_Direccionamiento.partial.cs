using System;
using System.Linq;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCab_Direccionamiento
	{
		#region [ Consultas ]
       DataTable GetForward(String Buque, String Viaje);
		#endregion
		
		#region [ Metodos ]
      Boolean SaveDepTemporal(DataTable _dt);
		#endregion
	}
}
