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
   public partial class BLDet_CNTR
   {
      #region [ Consultas ]
      private DataTable SelectAllDet_CntrByNaveViaje(Nullable<Int32> NVIA_Codigo, Int16 TIPO_Vobo, Nullable<Int32> CCOT_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_VoBo");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_VoBo", TIPO_Vobo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
               return _dt.Tables[0];
            }
            return null;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private System.Data.DataSet SelectAllByPrintMatriz(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_DHBLSS_UnReg_ImprimirMatriz");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);

            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 2)
            { 
               _ds.Tables[0].TableName = "DTMatrizDraft";
               _ds.Tables[1].TableName = "DTMatrizDraftDetail"; 
               return _ds; 
            }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]

      #endregion
   }
}
