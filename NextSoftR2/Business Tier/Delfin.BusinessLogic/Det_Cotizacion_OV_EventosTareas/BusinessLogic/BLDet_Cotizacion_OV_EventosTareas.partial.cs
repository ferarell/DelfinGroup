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
	public partial class BLDet_Cotizacion_OV_EventosTareas
	{
		#region [ Consultas ]
      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAllByCotizacion_OV(Int32 CCOT_Numero, Int16 CCOT_Tipo)
      {
         try
         {
            return SelectAllByCotizacion_OV(CCOT_Numero, CCOT_Tipo);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
