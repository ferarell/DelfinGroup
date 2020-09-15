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
	public partial class BLDet_Operacion_Servicio
	{
		#region [ Consultas ]
        public DataSet GetAllServiciosAdicionalesReporte(Int32? x_ENTC_Codigo, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, String x_TipoReporteAdicional)
        {
            try
            {
                return SelectAllServiciosAdicionalesReporte(x_ENTC_Codigo,x_COPE_FecEmiIni,x_COPE_FecEmiFin,x_TipoReporteAdicional); 
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
        public Boolean UpdateDetServicioOperacionPreFactura(Int32 x_COPE_Codigo, Int32 x_SOPE_Item, Int16 x_PDDO_Item, Int32 x_DOCV_Codigo, String x_CONS_CodEST)
        {
            try
            {
                Boolean m_isCorrect = true;
                m_isCorrect = UpdateDetServicioOperacion(x_COPE_Codigo, x_SOPE_Item, x_PDDO_Item, x_DOCV_Codigo, x_CONS_CodEST);
                return m_isCorrect;
            }
            catch (Exception)
            { throw; }
        }
		#endregion
	}
}
