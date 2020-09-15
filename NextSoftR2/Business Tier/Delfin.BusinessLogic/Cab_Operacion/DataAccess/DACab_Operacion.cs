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
   public partial class BLCab_Operacion
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Cab_Operacion> Loader { get; set; }
      #endregion

      #region [ Constructores ]
      public BLCab_Operacion(IUnityContainer container)
      {
         this.ContainerService = container;
         Loader = new BusinessEntityLoader<Cab_Operacion>();
         Cab_Operacion item = new Cab_Operacion();
         Loader.EntityType = item.GetType();
      }
      #endregion

      #region [ Consultas ]
      private ObservableCollection<Cab_Operacion> SelectAllByFiltros(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Int32 x_FacCliente, Int32 x_FacProveedor, Nullable<Int32> x_COPE_Codigo)
      {
         try
         {
            ObservableCollection<Cab_Operacion> items = new ObservableCollection<Cab_Operacion>();
            Cab_Operacion item = new Cab_Operacion();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESS_TodosByFiltros");
            if (x_ENTC_Codigo != null)
            {
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            }
            else
            {
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
            }
            if (!String.IsNullOrEmpty(x_COPE_NumDoc))
            {
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", x_COPE_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
            }
            else
            {
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", DBNull.Value, SqlDbType.VarChar, 11, ParameterDirection.Input);
            }
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiIni", x_COPE_FecEmiIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiFin", x_COPE_FecEmiFin, SqlDbType.DateTime, 8, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pintFacCliente", x_FacCliente, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintFacProveedor", x_FacProveedor, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Cab_Operacion();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  item.COPE_Profit = item.COPE_ValorVenta - item.COPE_ValorCosto;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private Cab_Operacion SelectOne(Int32 COPE_Codigo)
      {
         try
         {
            Cab_Operacion item = new Cab_Operacion();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESS_UnReg");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }
            }
            return item;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      private bool Insert(ref Cab_Operacion item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESI_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", item.COPE_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmi", item.COPE_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_Observacion", item.COPE_Observacion, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_HBL", item.COPE_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", item.CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransporte", item.ENTC_CodTransporte, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgente", item.ENTC_CodAgente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEstado", item.CONS_CodEstado, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEstado", item.CONS_TabEstado, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCOPE_Excepcion", item.COPE_Excepcion, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Fob", item.COPE_Fob, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Seguro", item.COPE_Seguro, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Flete", item.COPE_Flete, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Cif", item.COPE_Cif, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_PartArancelaria", item.COPE_PartArancelaria, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Ipm", item.COPE_Ipm, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Igv", item.COPE_Igv, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Percepcion", item.COPE_Percepcion, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_TasaDespacho", item.COPE_TasaDespacho, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_AdValorem", item.COPE_AdValorem, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCOPE_1erEmbarque", item.COPE_1erEmbarque, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodCRG", item.CONS_CodCRG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabCRG", item.CONS_TabCRG, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_CodAduana", item.CCOT_CodAduana, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_CodLogistico", item.CCOT_CodLogistico, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_CodTransporte", item.CCOT_CodTransporte, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_Nave", item.COPE_Nave, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_Viaje", item.COPE_Viaje, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_MBL", item.COPE_MBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FechaArribo", item.COPE_FechaArribo, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCOPE_CantidadDias", item.COPE_CantidadDias, SqlDbType.SmallInt, 2, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Kilos", item.COPE_Kilos, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Volumen", item.COPE_Volumen, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCOPEPrecioSada", item.COPE_PrecioSada, SqlDbType.Bit, 1, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int32 _COPE_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCOPE_Codigo"].Value.ToString(), out _COPE_Codigo))
                  { item.COPE_Codigo = _COPE_Codigo; }
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
      private bool Update(ref Cab_Operacion item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", item.COPE_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmi", item.COPE_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_Observacion", item.COPE_Observacion, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_HBL", item.COPE_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", item.CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransporte", item.ENTC_CodTransporte, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgente", item.ENTC_CodAgente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEstado", item.CONS_CodEstado, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEstado", item.CONS_TabEstado, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCOPE_Excepcion", item.COPE_Excepcion, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Fob", item.COPE_Fob, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Seguro", item.COPE_Seguro, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Flete", item.COPE_Flete, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Cif", item.COPE_Cif, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_PartArancelaria", item.COPE_PartArancelaria, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Ipm", item.COPE_Ipm, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Igv", item.COPE_Igv, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Percepcion", item.COPE_Percepcion, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_TasaDespacho", item.COPE_TasaDespacho, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_AdValorem", item.COPE_AdValorem, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCOPE_1erEmbarque", item.COPE_1erEmbarque, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodCRG", item.CONS_CodCRG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabCRG", item.CONS_TabCRG, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_CodAduana", item.CCOT_CodAduana, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_CodLogistico", item.CCOT_CodLogistico, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_CodTransporte", item.CCOT_CodTransporte, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_Nave", item.COPE_Nave, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_Viaje", item.COPE_Viaje, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_MBL", item.COPE_MBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FechaArribo", item.COPE_FechaArribo, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCOPE_CantidadDias", item.COPE_CantidadDias, SqlDbType.SmallInt, 2, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Kilos", item.COPE_Kilos, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCOPE_Volumen", item.COPE_Volumen, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCOPE_PrecioSada", item.COPE_PrecioSada, SqlDbType.Bit, 1, ParameterDirection.Input);

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
      private bool Delete(ref Cab_Operacion item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESD_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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
