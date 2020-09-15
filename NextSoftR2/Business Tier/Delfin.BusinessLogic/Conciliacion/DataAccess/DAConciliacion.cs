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
   public partial class BLConciliacion
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Conciliacion> Loader { get; set; }
      #endregion

      #region [ Constructores ]
      public BLConciliacion(IUnityContainer container)
      {
         this.ContainerService = container;
         Loader = new BusinessEntityLoader<Conciliacion>();
         Conciliacion Item = new Conciliacion();
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
            { DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CONCSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 1)
            { _ds.Tables[0].TableName = "Conciliacion"; return _ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      private ObservableCollection<Conciliacion> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            ObservableCollection<Conciliacion> items = new ObservableCollection<Conciliacion>();
            Conciliacion item = new Conciliacion();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CONCSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Conciliacion();
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
      private ObservableCollection<Conciliacion> SelectAll()
      {
         try
         {
            ObservableCollection<Conciliacion> items = new ObservableCollection<Conciliacion>();
            Conciliacion item = new Conciliacion();
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CONCSS_Todos");
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Conciliacion();
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
      private Conciliacion SelectOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int32 CONC_Codigo)
      {
         try
         {
            Conciliacion item = new Conciliacion();
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CONCSS_UnReg");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONC_Codigo", CONC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
      private bool Insert(ref Conciliacion Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CONCSI_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONC_Codigo", Item.CONC_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONC_Periodo", Item.CONC_Periodo, SqlDbType.VarChar, 10, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCONC_MontoBCO", Item.CONC_MontoBCO, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONC_FecConciliacion", Item.CONC_FecConciliacion, SqlDbType.DateTime, 8, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int16 _EMPR_Codigo;
                  if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinEMPR_Codigo"].Value.ToString(), out _EMPR_Codigo))
                  { Item.EMPR_Codigo = _EMPR_Codigo; }
                  Int32 _MOVI_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintMOVI_Codigo"].Value.ToString(), out _MOVI_Codigo))
                  { Item.MOVI_Codigo = _MOVI_Codigo; }
                  Int32 _CONC_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCONC_Codigo"].Value.ToString(), out _CONC_Codigo))
                  { Item.CONC_Codigo = _CONC_Codigo; }
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
      private bool Update(ref Conciliacion Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CONCSU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONC_Codigo", Item.CONC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONC_Periodo", Item.CONC_Periodo, SqlDbType.VarChar, 10, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCONC_MontoBCO", Item.CONC_MontoBCO, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONC_FecConciliacion", Item.CONC_FecConciliacion, SqlDbType.DateTime, 8, ParameterDirection.Input);

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
      private bool Delete(ref Conciliacion Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted && Item.CONC_Codigo != null)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CONCSD_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONC_Codigo", Item.CONC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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
