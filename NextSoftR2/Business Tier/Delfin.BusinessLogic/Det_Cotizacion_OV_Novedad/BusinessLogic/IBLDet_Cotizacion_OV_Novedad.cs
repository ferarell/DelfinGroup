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
	public partial interface IBLDet_Cotizacion_OV_Novedad
	{
		#region [ Consultas ]
		ObservableCollection<Det_Cotizacion_OV_Novedad> GetAll();
		Det_Cotizacion_OV_Novedad GetOne(Int32 OVNO_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Cotizacion_OV_Novedad Item);
		Boolean Save(ref ObservableCollection<Det_Cotizacion_OV_Novedad> Items);
		#endregion
	}
}
