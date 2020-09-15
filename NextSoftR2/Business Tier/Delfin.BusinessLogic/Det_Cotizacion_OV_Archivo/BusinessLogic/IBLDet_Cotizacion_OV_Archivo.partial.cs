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
	public partial interface IBLDet_Cotizacion_OV_Archivo
	{
		#region [ Consultas ]
      ObservableCollection<Det_Cotizacion_OV_Archivo> GetAllByCab_Cotizacion_OV(Int32 CCOT_Numero, Int16 CCOT_Tipo);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
