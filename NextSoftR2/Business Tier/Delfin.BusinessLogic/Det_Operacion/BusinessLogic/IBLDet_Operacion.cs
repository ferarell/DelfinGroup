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
	public partial interface IBLDet_Operacion
	{
		#region [ Consultas ]
        ObservableCollection<Det_Operacion> GetAllByOperacion(Int32 x_COPE_Codigo);
		Det_Operacion GetOne(Int32 DOPE_Item, Int32 COPE_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save( Det_Operacion Item);
		Boolean Save(ref ObservableCollection<Det_Operacion> Items);
		#endregion
	}
}
