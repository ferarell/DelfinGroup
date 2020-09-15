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
      ObservableCollection<Det_Cotizacion_OV_Servicio> GetAllByCab_Cotizacion_OV(Int16 CCOT_Tipo, Int32 CCOT_Numero);
		#endregion
		
		#region [ Metodos ]
      Boolean SaveDocumento(ref Det_Cotizacion_OV_Servicio Item);
		#endregion
	}
}
