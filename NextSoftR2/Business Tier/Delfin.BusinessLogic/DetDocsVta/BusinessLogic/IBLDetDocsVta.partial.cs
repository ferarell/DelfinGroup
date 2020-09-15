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
	public partial interface IBLDetDocsVta
	{
		#region [ Consultas ]

	    DataTable GetAllServiciosPorDOCV_CodigoFactura(Int32 x_DOCV_Codigo);

	    #endregion

	    #region [ Metodos ]

	    #endregion
	}
}
