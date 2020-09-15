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
	public partial class BLDet_Tarjas
	{
		#region [ Consultas ]
      public DataTable GetAllServiciosDetTarjas(Int32 x_DOCV_Codigo, String x_TIPO_CodMND, Decimal x_TipoCambio)
        {
            try
            {
                return SelectAllServiciosDetTarjas(x_DOCV_Codigo, x_TIPO_CodMND, x_TipoCambio);
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
        public Boolean UpdateDetTarjasPreFacturacion(Int32 x_TARJ_Codigo, Int32 x_DTAJ_Item, Int16 x_PDDO_Item, Int32 x_DOCV_Codigo, String x_CONS_CodETJ)
        {
            try
            {
                Boolean m_isCorrect = true;
                m_isCorrect = UpdateDetTarjas(x_TARJ_Codigo, x_DTAJ_Item, x_PDDO_Item, x_DOCV_Codigo,x_CONS_CodETJ);
                return m_isCorrect;
            }
            catch (Exception)
            { throw; }
        }
		#endregion
	}
}
