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
	public partial interface IBLDet_Cotizacion_OV_Servicio
	{
		#region [ Consultas ]
		ObservableCollection<Det_Cotizacion_OV_Servicio> GetAll();
		Det_Cotizacion_OV_Servicio GetOne(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int32 SCOT_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Cotizacion_OV_Servicio Item, Boolean tran);
		Boolean Save(ref ObservableCollection<Det_Cotizacion_OV_Servicio> Items);
		#endregion
	}
}
