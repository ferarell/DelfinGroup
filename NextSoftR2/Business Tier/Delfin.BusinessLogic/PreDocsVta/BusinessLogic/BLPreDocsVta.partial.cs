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
	public partial class BLPreDocsVta
	{
		#region [ Consultas ]
      public DataTable GetAllServiciosPreFactura(Int32 x_COPE_Codigo, String x_TIPO_CodMND, Decimal x_TIPO_Cambio)
        {
            try
            {
               return SelectAllServiciosPreFactura(x_COPE_Codigo, x_TIPO_CodMND, x_TIPO_Cambio);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataTable GetOneSerieFactura(String x_CORR_ServerName, String x_CORR_CodCorr)
        {
            try
            {
                return SelectOneSerieFactura(x_CORR_ServerName, x_CORR_CodCorr);
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
