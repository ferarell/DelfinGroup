using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.BusinessLogic
{
	public partial class BLDetDocsVta
	{
		#region [ Consultas ]
        public DataTable GetAllServiciosPorDOCV_CodigoFactura(Int32 x_DOCV_Codigo)
        {
            try
            {
                return SelectAllServiciosPorDOCV_CodigoFactura(x_DOCV_Codigo);
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
