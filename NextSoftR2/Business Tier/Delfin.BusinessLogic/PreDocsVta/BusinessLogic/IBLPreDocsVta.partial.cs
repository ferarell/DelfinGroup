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
	public partial interface IBLPreDocsVta
	{
		#region [ Consultas ]

      DataTable GetAllServiciosPreFactura(Int32 x_COPE_Codigo, String x_TIPO_CodMND, Decimal x_TIPO_Cambio);
        DataTable GetOneSerieFactura(String x_CORR_ServerName, String x_CORR_CodCorr);

	    #endregion

	    #region [ Metodos ]

	    #endregion
	}
}
