using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDet_Tarjas
	{
		#region [ Consultas ]

        DataTable GetAllServiciosDetTarjas(Int32 x_DOCV_Codigo, String x_TIPO_CodMND, Decimal x_TipoCambio);

	    #endregion

	    #region [ Metodos ]

	    Boolean UpdateDetTarjasPreFacturacion(Int32 x_TARJ_Codigo, Int32 x_DTAJ_Item, Int16 x_PDDO_Item,Int32 x_DOCV_Codigo, String x_CONS_CodETJ);

	    #endregion
	}
}
