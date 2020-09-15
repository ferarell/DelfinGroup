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
	public partial interface IBLCab_Cotizacion_OV
	{
		#region [ Consultas ]
		ObservableCollection<Cab_Cotizacion_OV> GetAll(Int16 EMPR_Codigo, Int16 SUCR_Codigo);
      Cab_Cotizacion_OV GetOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo);
		#endregion
		
		#region [ Metodos ]
      Cab_Cotizacion_OV Save(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError);
      Cab_Cotizacion_OV Save(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError, Cab_Cotizacion_OV.TipoInterfaz x_opcion);
		Boolean Save(ref ObservableCollection<Cab_Cotizacion_OV> Items);
		#endregion
	}
}
