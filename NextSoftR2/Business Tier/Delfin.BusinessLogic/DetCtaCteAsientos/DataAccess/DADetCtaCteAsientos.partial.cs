using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLDetCtaCteAsientos
   {
      #region [ Consultas ]

      #endregion

      #region [ Metodos ]

      private bool Delete(Int16 EMPR_Codigo, Int32 CCCT_Codigo)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DCCASD_UnRegPorCtaCte");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
            else
            { return false; }
         }
         catch (Exception)
         { throw; }
      }

      #endregion
   }
}
