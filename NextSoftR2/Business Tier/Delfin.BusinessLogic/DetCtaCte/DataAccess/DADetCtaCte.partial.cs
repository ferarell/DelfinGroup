using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLDetCtaCte
   {
      #region [ Consultas ]

      #endregion

      #region [ Metodos ]

      private bool InsertUpdate(ref DetCtaCte Item)
      {
         try
         {

            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DCCTSI_InsertUpdate");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", Item.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinDCCT_Item", Item.DCCT_Item, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTDC", Item.CONS_TabTDC, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTDC", Item.CONS_CodTDC, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_CodReferencia", Item.CCCT_CodReferencia, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinDCCT_ItemReferencia", Item.DCCT_ItemReferencia, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDCCT_TipoPago", Item.DCCT_TipoPago, SqlDbType.Char, 1, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDCCT_FechaTrans", Item.DCCT_FechaTrans, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCCT_TipoCambio", Item.DCCT_TipoCambio, SqlDbType.Decimal, 10, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCCT_MontoDebe", Item.DCCT_MontoDebe, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCCT_MontoHaber", Item.DCCT_MontoHaber, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCCT_MontoDebeD", Item.DCCT_MontoDebeD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCCT_MontoHaberD", Item.DCCT_MontoHaberD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCCT_PPago", Item.DCCT_PPago, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCCT_PPagoD", Item.DCCT_PPagoD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDCCT_PagoDetraccion", Item.DCCT_PagoDetraccion, SqlDbType.Bit, 1, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            {
               Int16 _EMPR_Codigo;
               if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinEMPR_Codigo"].Value.ToString(), out _EMPR_Codigo))
               { Item.EMPR_Codigo = _EMPR_Codigo; }
               Int32 _CCCT_Codigo;
               if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCCT_Codigo"].Value.ToString(), out _CCCT_Codigo))
               { Item.CCCT_Codigo = _CCCT_Codigo; }
               Int16 _DCCT_Item;
               if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinDCCT_Item"].Value.ToString(), out _DCCT_Item))
               { Item.DCCT_Item = _DCCT_Item; }
               return true;
            }
            else
            { return false; }

         }
         catch (Exception)
         { throw; }
      }

      #endregion
   }
}
