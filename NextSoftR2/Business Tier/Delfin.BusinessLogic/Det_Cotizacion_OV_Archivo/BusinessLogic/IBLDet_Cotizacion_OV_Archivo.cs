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
		ObservableCollection<Det_Cotizacion_OV_Archivo> GetAll();
		Det_Cotizacion_OV_Archivo GetOne(Int32 OVAR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Cotizacion_OV_Archivo Item);
		Boolean Save(ref ObservableCollection<Det_Cotizacion_OV_Archivo> Items);
		#endregion
	}
}
