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
	public partial interface IBLDet_Cotizacion_OV_Flete
	{
		#region [ Consultas ]
		ObservableCollection<Det_Cotizacion_OV_Flete> GetAll();
		Det_Cotizacion_OV_Flete GetOne(Int32 CCOT_Numero, Int32 DCOT_Item, Int16 CCOT_Tipo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Cotizacion_OV_Flete Item, Boolean Tran);
		Boolean Save(ref ObservableCollection<Det_Cotizacion_OV_Flete> Items);
		#endregion
	}
}
