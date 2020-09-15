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
using Infrastructure.Aspect.BusinessEntity;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLRebate
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Rebate> Loader { get; set; }
      #endregion

      #region [ Constructores ]
      public BLRebate(IUnityContainer container)
      {
         this.ContainerService = container;
         Loader = new BusinessEntityLoader<Rebate>();
         Rebate item = new Rebate();
         Loader.EntityType = item.GetType();
      }
      #endregion

      #region [ Consultas ]
      private ObservableCollection<Rebate> SelectAll(string x_CONC_TabReb, string x_CONC_CodReb, string x_ENTC_CodTransportista, DateTime x_REBA_FecIni)
      {
         try
         {

            ObservableCollection<Rebate> items = new ObservableCollection<Rebate>();
            Rebate item = new Rebate();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_RebateAllByFiltros");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONC_TabReb", x_CONC_TabReb, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONC_CodReb", x_CONC_CodReb, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", x_ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREBA_FecIni", x_REBA_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);


            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Rebate();
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
      private Rebate SelectOne(Int32 REBA_Codigo)
      {
         try
         {
            Rebate item = new Rebate();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Rebate");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      private bool Insert(ref Rebate item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Rebate");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREBA_FecIni", item.REBA_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREBA_FecFin", item.REBA_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", item.PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", item.PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONC_TabReb", item.CONC_TabReb, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONC_CodReb", item.CONC_CodReb, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int32 _REBA_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintREBA_Codigo"].Value.ToString(), out _REBA_Codigo))
                  { item.REBA_Codigo = _REBA_Codigo; }
                  return true;
               }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      private bool Update(ref Rebate item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Rebate");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREBA_FecIni", item.REBA_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREBA_FecFin", item.REBA_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", item.PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", item.PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONC_TabReb", item.CONC_TabReb, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONC_CodReb", item.CONC_CodReb, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      private bool Delete(ref Rebate item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ELIMINAR_Rebate");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}