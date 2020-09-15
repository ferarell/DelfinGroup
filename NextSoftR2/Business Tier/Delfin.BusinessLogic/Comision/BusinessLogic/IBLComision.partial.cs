using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLComision
	{
		#region [ Consultas ]
      Boolean GetValidar(Int32 COMI_Codigo, DateTime COMI_FecIni, DateTime COMI_FecFin);
		#endregion
		
		#region [ Metodos ]
      Boolean SaveComisiones(ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);//(Int32 NVIA_Codigo, String Usuario);
		#endregion
	}
}
