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
	public partial class BLLiquidacion
	{
		#region [ Consultas ]

		#endregion

		#region [ Metodos ]

      private bool UpdateCambiarEstado(ref Liquidacion Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_LIQUSU_UnRegCambiarEstado");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLIQU_Codigo", Item.LIQU_Codigo, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrLIQU_Estado", Item.LIQU_Estado, SqlDbType.Char, 1, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }


		#endregion
	}
}
