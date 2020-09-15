using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessEntity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLDet_Operacion
   {
      #region [ Consultas ]
      public DataTable SelectAyudaOperacionXProveedor(Int32 x_COPE_Codigo, String x_Moneda, Decimal x_TipoCambio, Int32 x_CCCT_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESS_OperativoProveedor");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", x_Moneda, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPOCambio", x_TipoCambio, SqlDbType.Decimal, 10, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", x_CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
      public bool ActualizaEstado(Int32 x_COPE_Codigo, String x_CTAR_Tipo, Int32 x_CCCT_Codigo, Int16 x_TIPE_Codigo, Int32 x_ENTC_Codigo, Decimal x_Monto, Boolean x_UltimoCosto, String x_Usuario, String x_DOPE_Items)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESS_ActualizarEstado");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCTAR_Tipo", x_CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", x_CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPE_Codigo", x_TIPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMonto", x_Monto, SqlDbType.Decimal, 10, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbitUltimoMonto", x_UltimoCosto, SqlDbType.Bit, 1, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUsuario", x_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOPE_Items", x_DOPE_Items, SqlDbType.VarChar, 4000, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            {
               return true;
            }
            else
            { return false; }
         }
         catch (Exception ex)
         { throw ex; }
      }

      public bool EliminarServicioCtaCte(CtaCte ItemCtaCte)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DCTO_UnRegCtaCte");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
            else
            { return false; }
         }
         catch (Exception ex)
         { throw ex; }
      }


      public ObservableCollection<Det_Operacion> SelectAllByDOCV_Codigo(Int32 x_DOCV_Codigo)
      {
         try
         {
            ObservableCollection<Det_Operacion> items = new ObservableCollection<Det_Operacion>();
            Det_Operacion item = new Det_Operacion();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESS_TodosByDOCV_Codigo");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", x_DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Det_Operacion();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable ServicioByOperacion(Int32 x_COPE_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESS_TodosByCOPE_Codigo");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
               return _dt.Tables[0];
            }
            else
            { return null; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      private bool UpdateDetOperacion(Int32 x_COPE_Codigo, Int32 x_DOPE_Item, Int16 x_PDDO_Item, Int32 x_DOCV_Codigo, String x_CONS_CodEST)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESU_UnRegPorPreFacturacion");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", x_DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);

            if (x_PDDO_Item > 0)
            {
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", x_PDDO_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);

            }
            else
            {
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", DBNull.Value, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            }
            if (x_DOCV_Codigo > 0)
            {
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", x_DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            }
            else
            {
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
            }
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", x_CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
            else
            { return false; }

         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable VerificaServicioFacturado(Int32 x_COPE_Codigo, Int32 x_DOPE_Item)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESS_Proveedor_ServciosFacturados");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", x_DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
               return _dt.Tables[0];
            }
            else
            { return null; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
