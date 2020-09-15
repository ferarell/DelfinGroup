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
   public partial class BLPlanillas
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Planillas> Loader { get; set; }
      #endregion

      #region [ Constructores ]
      public BLPlanillas(IUnityContainer container)
      {
         this.ContainerService = container;
         Loader = new BusinessEntityLoader<Planillas>();
         Planillas Item = new Planillas();
         Loader.EntityType = Item.GetType();
      }
      #endregion

      #region [ Consultas ]
      private System.Data.DataTable SelectAllByFilterDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            DataSet _ds = new DataSet();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_PLANSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 1)
            { _ds.Tables[0].TableName = "Planillas"; return _ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      private ObservableCollection<Planillas> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            ObservableCollection<Planillas> items = new ObservableCollection<Planillas>();
            Planillas item = new Planillas();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_PLANSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Planillas();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception)
         { throw; }
      }
      private ObservableCollection<Planillas> SelectAll()
      {
         try
         {
            ObservableCollection<Planillas> items = new ObservableCollection<Planillas>();
            Planillas item = new Planillas();
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_PLANSS_Todos");
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Planillas();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception)
         { throw; }
      }
      private Planillas SelectOne(Int16 EMPR_Codigo, String PLAN_Tipo, String PLAN_Codigo)
      {
         try
         {
            Planillas item = new Planillas();
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_PLANSS_UnReg");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Tipo", PLAN_Tipo, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Codigo", PLAN_Codigo, SqlDbType.VarChar, 20, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }
               else
               { throw new Exception("No se encontro el registro."); }
            }
            return item;
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      private bool Insert(ref Planillas Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_PLANSI_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Tipo", Item.PLAN_Tipo, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Codigo", Item.PLAN_Codigo, SqlDbType.VarChar, 20, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", Item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", Item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmPLAN_FechaEmision", Item.PLAN_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Concepto", Item.PLAN_Concepto, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Archivo", Item.PLAN_Archivo, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Lote", Item.PLAN_Lote, SqlDbType.Char, 6, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", Item.ItemCuentasBancarias.CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.ItemCuentasBancarias.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int16 _EMPR_Codigo;
                  if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinEMPR_Codigo"].Value.ToString(), out _EMPR_Codigo))
                  { Item.EMPR_Codigo = _EMPR_Codigo; }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrPLAN_Tipo"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrPLAN_Tipo"].Value.ToString()))
                  { Item.PLAN_Tipo = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrPLAN_Tipo"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchPLAN_Codigo"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchPLAN_Codigo"].Value.ToString()))
                  { Item.PLAN_Codigo = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchPLAN_Codigo"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchPLAN_Archivo"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchPLAN_Codigo"].Value.ToString()))
                  { Item.PLAN_Archivo = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchPLAN_Archivo"].Value.ToString(); }
                  return true;
               }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }
      private bool Update(ref Planillas Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_PLANSU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Tipo", Item.PLAN_Tipo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Codigo", Item.PLAN_Codigo, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", Item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", Item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmPLAN_FechaEmision", Item.PLAN_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Concepto", Item.PLAN_Concepto, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Archivo", Item.PLAN_Archivo, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Lote", Item.PLAN_Lote, SqlDbType.Char, 6, ParameterDirection.Input);

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
      private bool Delete(ref Planillas Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_PLANSD_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Tipo", Item.PLAN_Tipo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Codigo", Item.PLAN_Codigo, SqlDbType.VarChar, 20, ParameterDirection.Input);

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

      private bool UpdateRDetraccion(Infrastructure.Aspect.Constants.CRespuestaDetracciones Item)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSU_UnRegRespuestaDetracciones");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", Item.TipoComprobante, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_DocIden", Item.NroDocProveedor, SqlDbType.VarChar, 25, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Serie", Item.Serie, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Numero", Item.Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_NroDetraccion", Item.NroConstancia, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecDetraccion", Item.Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

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
