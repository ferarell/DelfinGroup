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
   public partial interface IBLDet_Cotizacion_OV_EventosTareas
	{
		#region [ Consultas ]
      ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAll();
      Det_Cotizacion_OV_EventosTareas GetOne(Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 EVEN_Item);
		#endregion
		
		#region [ Metodos ]
      Boolean Save(ref Det_Cotizacion_OV_EventosTareas Item, Boolean Tran);
      Boolean Save(ref ObservableCollection<Det_Cotizacion_OV_EventosTareas> Items);
		#endregion
	}
}
