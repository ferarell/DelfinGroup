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
	public partial class BLCab_Cotizacion
	{
		#region [ Consultas ]
      public System.Data.DataTable PrintCotizacion(Int32 x_CCOT_Codigo)
      {
         try
         {
            return ImprimirCotizacion(x_CCOT_Codigo);
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
  	#endregion
		
		#region [ Metodos ]
        public Boolean AprobarAnularCotizacion(Int32 x_CCOT_Codigo, String x_Estado, String x_AUDI_UsrMod)
        {
            try
            {
                Boolean m_isCorrect = true;
                Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
                m_isCorrect = AprobarAnular(x_CCOT_Codigo, x_Estado, x_AUDI_UsrMod);
                if (m_isCorrect)
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                else
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
                return m_isCorrect;
            }
            catch (Exception)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
        }
		#endregion
	}
}
