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
   public partial class BLCab_Cotizacion_OV
   {
      #region [ Consultas ]
      private System.Data.DataTable OPE_SelectAllByFilterDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            DataSet _ds = new DataSet();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 1)
            { _ds.Tables[0].TableName = "Cab_Cotizacion_OV"; return _ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      private ObservableCollection<Cab_Cotizacion_OV> OPE_SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            ObservableCollection<Cab_Cotizacion_OV> items = new ObservableCollection<Cab_Cotizacion_OV>();
            Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Cab_Cotizacion_OV();
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
      private ObservableCollection<Cab_Cotizacion_OV> OPE_SelectAll()
      {
         try
         {
            ObservableCollection<Cab_Cotizacion_OV> items = new ObservableCollection<Cab_Cotizacion_OV>();
            Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_Todos");
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Cab_Cotizacion_OV();
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

      private Cab_Cotizacion_OV OPE_SelectOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_UnReg");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               //COM_Cab_Cotizacion_OV
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }

               BusinessEntityLoader<Contrato> LoaderContrato = new BusinessEntityLoader<Contrato>();
               Contrato itemContrato = new Contrato();
               LoaderContrato.EntityType = itemContrato.GetType();
               //COM_Contrato
               if (reader.NextResult())
               {
                  if (reader.Read())
                  {
                     LoaderContrato.LoadEntity(reader, itemContrato);
                     itemContrato.Instance = InstanceEntity.Unchanged;
                     item.ItemContrato = itemContrato;
                  }
               }

               BusinessEntityLoader<Det_Cotizacion_OV_Flete> LoaderFlete = new BusinessEntityLoader<Det_Cotizacion_OV_Flete>();
               Det_Cotizacion_OV_Flete itemFlete = new Det_Cotizacion_OV_Flete();
               LoaderFlete.EntityType = itemFlete.GetType();
               //COM_Det_Cotizacion_OV_Flete
               if (reader.NextResult())
               {
                  while (reader.Read())
                  {
                     itemFlete = new Det_Cotizacion_OV_Flete();
                     LoaderFlete.LoadEntity(reader, itemFlete);
                     itemFlete.Instance = InstanceEntity.Unchanged;
                     item.ItemsFlete.Add(itemFlete);
                     itemFlete = null;
                  }
               }

               //COM_Det_Cotizacion_OV_Servicio
               BusinessEntityLoader<Det_Cotizacion_OV_Servicio> LoaderServicio = new BusinessEntityLoader<Det_Cotizacion_OV_Servicio>();
               Det_Cotizacion_OV_Servicio itemServicio = new Det_Cotizacion_OV_Servicio();
               LoaderServicio.EntityType = itemServicio.GetType();
               if (reader.NextResult())
               {
                  while (reader.Read())
                  {
                     itemServicio = new Det_Cotizacion_OV_Servicio();
                     LoaderServicio.LoadEntity(reader, itemServicio);
                     itemServicio.Instance = InstanceEntity.Unchanged;
                     item.ItemsServicio.Add(itemServicio);
                     itemServicio = null;
                  }
               }

               //COM_Det_Cotizacion_OV_Servicio => ChangeControl
               itemServicio = new Det_Cotizacion_OV_Servicio();
               if (reader.NextResult())
               {
                  while (reader.Read())
                  {
                     itemServicio = new Det_Cotizacion_OV_Servicio();
                     LoaderServicio.LoadEntity(reader, itemServicio);
                     itemServicio.Instance = InstanceEntity.Unchanged;
                     item.ItemsServicioChangeControl.Add(itemServicio);
                     itemServicio = null;
                  }
               }


               BusinessEntityLoader<Nave> LoaderNave = new BusinessEntityLoader<Nave>();
               BusinessEntityLoader<NaveViaje> LoaderNaveViaje = new BusinessEntityLoader<NaveViaje>();
               BusinessEntityLoader<DetNaveViaje> LoaderDetNaveViaje = new BusinessEntityLoader<DetNaveViaje>();

               Nave itemNave = new Nave();
               NaveViaje itemNaveViaje = new NaveViaje();
               DetNaveViaje itemDetNaveViaje = new DetNaveViaje();
               LoaderNaveViaje.EntityType = itemNaveViaje.GetType();

               //COM_DetNaveViaje
               if (reader.NextResult())
               {
                  if (reader.Read())
                  {
                     LoaderNave.LoadEntity(reader, itemNave);
                     itemNave.Instance = InstanceEntity.Unchanged;
                     item.ItemNave = itemNave;

                     LoaderNaveViaje.LoadEntity(reader, itemNaveViaje);
                     itemNaveViaje.Instance = InstanceEntity.Unchanged;
                     item.ItemNaveViaje = itemNaveViaje;

                     LoaderDetNaveViaje.LoadEntity(reader, itemDetNaveViaje);
                     itemDetNaveViaje.Instance = InstanceEntity.Unchanged;
                     item.ItemDetNaveViaje = itemDetNaveViaje;

                  }
               }

               //COM_Det_Cotizacion_OV_Novedad
               BusinessEntityLoader<Det_Cotizacion_OV_Novedad> LoaderNovedad = new BusinessEntityLoader<Det_Cotizacion_OV_Novedad>();
               Det_Cotizacion_OV_Novedad itemNovedad = new Det_Cotizacion_OV_Novedad();
               LoaderNovedad.EntityType = itemNovedad.GetType();
               if (reader.NextResult())
               {
                  while (reader.Read())
                  {
                     itemNovedad = new Det_Cotizacion_OV_Novedad();
                     LoaderNovedad.LoadEntity(reader, itemNovedad);
                     itemNovedad.Instance = InstanceEntity.Unchanged;
                     item.ItemsNovedad.Add(itemNovedad);
                     itemNovedad = null;
                  }
               }


               //COM_Det_Cotizacion_OV_Archivo
               BusinessEntityLoader<Det_Cotizacion_OV_Archivo> LoaderArchivo = new BusinessEntityLoader<Det_Cotizacion_OV_Archivo>();
               Det_Cotizacion_OV_Archivo itemArchivo = new Det_Cotizacion_OV_Archivo();
               LoaderArchivo.EntityType = itemArchivo.GetType();
               if (reader.NextResult())
               {
                  while (reader.Read())
                  {
                     itemArchivo = new Det_Cotizacion_OV_Archivo();
                     LoaderArchivo.LoadEntity(reader, itemArchivo);
                     itemArchivo.Instance = InstanceEntity.Unchanged;
                     item.ItemsArchivo.Add(itemArchivo);
                     itemArchivo = null;
                  }
               }


               //COM_Det_Cotizacion_OV_EventosTareas           
               BusinessEntityLoader<Det_Cotizacion_OV_EventosTareas> LoaderEventoTarea = new BusinessEntityLoader<Det_Cotizacion_OV_EventosTareas>();
               Det_Cotizacion_OV_EventosTareas itemEventoTarea = new Det_Cotizacion_OV_EventosTareas();
               LoaderEventoTarea.EntityType = itemEventoTarea.GetType();
               if (reader.NextResult())
               {
                  while (reader.Read())
                  {
                     itemEventoTarea = new Det_Cotizacion_OV_EventosTareas();
                     LoaderEventoTarea.LoadEntity(reader, itemEventoTarea);
                     itemEventoTarea.Instance = InstanceEntity.Unchanged;
                            item.ItemsEventosTareas.Add(itemEventoTarea);
                     itemEventoTarea = null;
                  }
               }


               //Det_CNTR
               BusinessEntityLoader<Det_CNTR> LoaderDet_CNTR = new BusinessEntityLoader<Det_CNTR>();
               Det_CNTR itemDet_CNTR = new Det_CNTR();
               LoaderDet_CNTR.EntityType = itemDet_CNTR.GetType();
               if (reader.NextResult())
               {
                  while (reader.Read())
                  {
                     itemDet_CNTR = new Det_CNTR();
                     LoaderDet_CNTR.LoadEntity(reader, itemDet_CNTR);
                     if (itemDet_CNTR.DHBL_Item.HasValue)
                     { itemDet_CNTR.Instance = InstanceEntity.Unchanged; }
                     else
                     { itemDet_CNTR.Instance = InstanceEntity.Added; }


                     item.ItemsDet_CNTR.Add(itemDet_CNTR);
                     itemDet_CNTR = null;
                  }
               }

               //Anexos
               BusinessEntityLoader<Anexos> LoaderAnexo = new BusinessEntityLoader<Anexos>();
               Anexos itemAnexo = new Anexos();
               LoaderAnexo.EntityType = itemAnexo.GetType();
               if (reader.NextResult())
               {
                  while (reader.Read())
                  {
                     itemAnexo = new Anexos();
                     LoaderAnexo.LoadEntity(reader, itemAnexo);
                     itemAnexo.Instance = InstanceEntity.Unchanged;
                     item.ItemsAnexos.Add(itemAnexo);
                     itemAnexo = null;
                  }
               }

            }
            return item;
         }
         catch (Exception)
         { throw; }
      }
      private Byte[] OPE_SelectOneVersion(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            Byte[] _version = null;
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_UnRegVersion");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);

            Object _value = DataAccessEnterpriseSQL.DAExecuteScalar();
            if (_value != null && _value is Byte[])
            { _version = _value as Byte[]; }

            return _version;
         }
         catch (Exception)
         { throw; }
      }

      private System.Data.DataSet OPE_SelectOneImpresionHBL(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_UnRegImpresionHBL");
            //DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            //DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 4)
            {
               _ds.Tables[0].TableName = "DSOPE001HBL";
               _ds.Tables[1].TableName = "DSOPE001HBLDET";
               _ds.Tables[2].TableName = "DSOPE001DHBL2";
               _ds.Tables[3].TableName = "DSOPE001HBLDET2";
               return _ds;
            }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      private System.Data.DataTable OPE_SelectOneImpresionEtiqueta(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_ImprimirEtiqueta");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 1)
            {
               _ds.Tables[0].TableName = "DTEtiqueta";
               return _ds.Tables[0];
            }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      private Boolean OPE_Insert(ref Cab_Cotizacion_OV Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSI_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", Item.CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPadre", Item.CCOT_NumPadre, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TipoPadre", Item.CCOT_TipoPadre, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Version", Item.CCOT_Version, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Propia", Item.CCOT_Propia, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", Item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", Item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodBroker", Item.ENTC_CodBroker, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgente", Item.ENTC_CodAgente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCustomer", Item.ENTC_CodCustomer, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", Item.ENTC_CodEjecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPresupuesto", Item.CCOT_NumPresupuesto, SqlDbType.Decimal, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmi", Item.CCOT_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecVcto", Item.CCOT_FecVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ServicioLogistico", Item.CCOT_ServicioLogistico, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_CargaRefrigerada", Item.CCOT_CargaRefrigerada, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pnumCCOT_Temperatura", Item.CCOT_Temperatura, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_CargaPeligrosa", Item.CCOT_CargaPeligrosa, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Roundtrip", Item.CCOT_Roundtrip, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_Observaciones", Item.CCOT_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecCierre", Item.CCOT_FecCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Almacenaje", Item.CCOT_Almacenaje, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_SobreEstadia", Item.CCOT_SobreEstadia, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TiempoViaje", Item.CCOT_TiempoViaje, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_ValidezOferta", Item.CCOT_ValidezOferta, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabINC", Item.TIPO_TabINC, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodINC", Item.TIPO_CodINC, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabImo", Item.TIPO_TabImo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodImo", Item.TIPO_CodImo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_ImoUN", Item.CCOT_ImoUN, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", Item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", Item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", Item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE", Item.CONS_TabFLE, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE", Item.CONS_CodFLE, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", Item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", Item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", Item.PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodTrasbordo", Item.PUER_CodTrasbordo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", Item.PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrAprueba", Item.CCOT_UsrAprueba, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecAprueba", Item.CCOT_FecAprueba, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrAceptaRechaza", Item.CCOT_UsrAceptaRechaza, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecAceptaRechaza", Item.CCOT_FecAceptaRechaza, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMOT", Item.TIPO_TabMOT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMOT", Item.TIPO_CodMOT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodShipper", Item.ENTC_CodShipper, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodConsignee", Item.ENTC_CodConsignee, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodNotify", Item.ENTC_CodNotify, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTFT", Item.CONS_TabTFT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTFT", Item.CONS_CodTFT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecTarifa", Item.CCOT_FecTarifa, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_PagoMBL", Item.CCOT_PagoMBL, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_PagoHBL", Item.CCOT_PagoHBL, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_Cntr", Item.DOOV_Cntr, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_HBL", Item.DOOV_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_MBL", Item.DOOV_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_CodReferencia", Item.DOOV_CodReferencia, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDTM", Item.TIPO_TabDTM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDTM", Item.TIPO_CodDTM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", Item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrConfirma", Item.CCOT_UsrConfirma, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecConfirma", Item.CCOT_FecConfirma, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecConcluye", Item.CCOT_FecConcluye, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrConcluye", Item.CCOT_UsrConcluye, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCOT_Profit", Item.CCOT_Profit, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCOT_TEUS", Item.CCOT_TEUS, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCOT_ProfitPRom", Item.CCOT_ProfitPRom, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOOV_FecETDFeeder_IMPO", Item.DOOV_FecETDFeeder_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_Feeder_IMPO", Item.DOOV_Feeder_IMPO, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_EmitirHBL", Item.CCOT_EmitirHBL, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_SADA", Item.CCOT_SADA, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_EnviaAvisoLlegada", Item.CCOT_EnviaAvisoLlegada, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecTrasbordo", Item.CCOT_FecTrasbordo, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Bloqueado", Item.CCOT_Bloqueado, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ServicioTransmision", Item.CCOT_ServicioTransmision, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepTemporal", Item.ENTC_CodDepTemporal, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOOV_FecICA", Item.DOOV_FecICA, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmiDoc", Item.CCOT_FecEmiDoc, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgenteNieto", Item.ENTC_CodAgenteNieto, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodConsigneeNieto", Item.ENTC_CodConsigneeNieto, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodShipperNieto", Item.ENTC_CodShipperNieto, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodNotifyNieto", Item.ENTC_CodNotifyNieto, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarque", Item.DDOV_FecEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_DepTemNegociaAgente", Item.CCOT_DepTemNegociaAgente, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepVacio", Item.ENTC_CodDepVacio, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_CodDepVacio", Item.TIPE_CodDepVacio, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_NumeroBLNieto", Item.DOOV_NumeroBLNieto, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", Item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", Item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecRecDocs", Item.CCOT_FecRecDocs, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ConExcepcion", Item.CCOT_ConExcepcion, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_VBOperaciones", Item.CCOT_VBOperaciones, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_VBLogistico", Item.CCOT_VBLogistico, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_DiferenciaFlete", Item.CCOT_DiferenciaFlete, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_DiferenciaFleteRecup", Item.CCOT_DiferenciaFleteRecup, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDDOV_NroBooking", Item.DDOV_NroBooking, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_DescShipper", Item.DDOV_DescShipper, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_DescConsignee", Item.DDOV_DescConsignee, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_DescNotify", Item.DDOV_DescNotify, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_DescApplyTo", Item.DDOV_DescApplyTo, SqlDbType.VarChar, 1024, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDDOV_HBLNieto", Item.DDOV_HBLNieto, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTRF", Item.TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTRF", Item.TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_PlaceReceipt", Item.DOOV_PlaceReceipt, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_PlaceDelivery", Item.DOOV_PlaceDelivery, SqlDbType.VarChar, 50, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int16 _CCOT_Tipo;
                  if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinCCOT_Tipo"].Value.ToString(), out _CCOT_Tipo))
                  { Item.CCOT_Tipo = _CCOT_Tipo; }
                  Int32 _CCOT_Numero;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_Numero"].Value.ToString(), out _CCOT_Numero))
                  { Item.CCOT_Numero = _CCOT_Numero; }
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
      private Boolean OPE_Update(ref Cab_Cotizacion_OV Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", Item.CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPadre", Item.CCOT_NumPadre, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TipoPadre", Item.CCOT_TipoPadre, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Version", Item.CCOT_Version, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Propia", Item.CCOT_Propia, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", Item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", Item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodBroker", Item.ENTC_CodBroker, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgente", Item.ENTC_CodAgente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCustomer", Item.ENTC_CodCustomer, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", Item.ENTC_CodEjecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPresupuesto", Item.CCOT_NumPresupuesto, SqlDbType.Decimal, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmi", Item.CCOT_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecVcto", Item.CCOT_FecVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ServicioLogistico", Item.CCOT_ServicioLogistico, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_CargaRefrigerada", Item.CCOT_CargaRefrigerada, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pnumCCOT_Temperatura", Item.CCOT_Temperatura, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_CargaPeligrosa", Item.CCOT_CargaPeligrosa, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Roundtrip", Item.CCOT_Roundtrip, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_Observaciones", Item.CCOT_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecCierre", Item.CCOT_FecCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Almacenaje", Item.CCOT_Almacenaje, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_SobreEstadia", Item.CCOT_SobreEstadia, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TiempoViaje", Item.CCOT_TiempoViaje, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_ValidezOferta", Item.CCOT_ValidezOferta, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabINC", Item.TIPO_TabINC, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodINC", Item.TIPO_CodINC, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabImo", Item.TIPO_TabImo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodImo", Item.TIPO_CodImo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_ImoUN", Item.CCOT_ImoUN, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", Item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", Item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", Item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE", Item.CONS_TabFLE, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE", Item.CONS_CodFLE, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", Item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", Item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", Item.PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodTrasbordo", Item.PUER_CodTrasbordo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", Item.PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrAprueba", Item.CCOT_UsrAprueba, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecAprueba", Item.CCOT_FecAprueba, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrAceptaRechaza", Item.CCOT_UsrAceptaRechaza, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecAceptaRechaza", Item.CCOT_FecAceptaRechaza, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMOT", Item.TIPO_TabMOT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMOT", Item.TIPO_CodMOT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodShipper", Item.ENTC_CodShipper, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodConsignee", Item.ENTC_CodConsignee, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodNotify", Item.ENTC_CodNotify, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTFT", Item.CONS_TabTFT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTFT", Item.CONS_CodTFT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecTarifa", Item.CCOT_FecTarifa, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_PagoMBL", Item.CCOT_PagoMBL, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_PagoHBL", Item.CCOT_PagoHBL, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_Cntr", Item.DOOV_Cntr, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_HBL", Item.DOOV_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_MBL", Item.DOOV_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_CodReferencia", Item.DOOV_CodReferencia, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDTM", Item.TIPO_TabDTM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDTM", Item.TIPO_CodDTM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", Item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrConfirma", Item.CCOT_UsrConfirma, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecConfirma", Item.CCOT_FecConfirma, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecConcluye", Item.CCOT_FecConcluye, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrConcluye", Item.CCOT_UsrConcluye, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCOT_Profit", Item.CCOT_Profit, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCOT_TEUS", Item.CCOT_TEUS, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCOT_ProfitPRom", Item.CCOT_ProfitPRom, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOOV_FecETDFeeder_IMPO", Item.DOOV_FecETDFeeder_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_Feeder_IMPO", Item.DOOV_Feeder_IMPO, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_EmitirHBL", Item.CCOT_EmitirHBL, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_SADA", Item.CCOT_SADA, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_EnviaAvisoLlegada", Item.CCOT_EnviaAvisoLlegada, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecTrasbordo", Item.CCOT_FecTrasbordo, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Bloqueado", Item.CCOT_Bloqueado, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ServicioTransmision", Item.CCOT_ServicioTransmision, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepTemporal", Item.ENTC_CodDepTemporal, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmiDoc", Item.CCOT_FecEmiDoc, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOOV_FecICA", Item.DOOV_FecICA, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgenteNieto", Item.ENTC_CodAgenteNieto, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodConsigneeNieto", Item.ENTC_CodConsigneeNieto, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodShipperNieto", Item.ENTC_CodShipperNieto, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodNotifyNieto", Item.ENTC_CodNotifyNieto, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarque", Item.DDOV_FecEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_DepTemNegociaAgente", Item.CCOT_DepTemNegociaAgente, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepVacio", Item.ENTC_CodDepVacio, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_CodDepVacio", Item.TIPE_CodDepVacio, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_NumeroBLNieto", Item.DOOV_NumeroBLNieto, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", Item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", Item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecRecDocs", Item.CCOT_FecRecDocs, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ConExcepcion", Item.CCOT_ConExcepcion, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_VBOperaciones", Item.CCOT_VBOperaciones, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_VBLogistico", Item.CCOT_VBLogistico, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_DiferenciaFlete", Item.CCOT_DiferenciaFlete, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_DiferenciaFleteRecup", Item.CCOT_DiferenciaFleteRecup, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDDOV_NroBooking", Item.DDOV_NroBooking, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_DescShipper", Item.DDOV_DescShipper, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_DescConsignee", Item.DDOV_DescConsignee, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_DescNotify", Item.DDOV_DescNotify, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_DescApplyTo", Item.DDOV_DescApplyTo, SqlDbType.VarChar, 1024, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDDOV_HBLNieto", Item.DDOV_HBLNieto, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTRF", Item.TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTRF", Item.TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_PlaceReceipt", Item.DOOV_PlaceReceipt, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_PlaceDelivery", Item.DOOV_PlaceDelivery, SqlDbType.VarChar, 50, ParameterDirection.Input);

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
      private Boolean OPE_Delete(ref Cab_Cotizacion_OV Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSD_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);

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

      private Boolean OPE_UpdateNumerarHBL(ref Cab_Cotizacion_OV Item, ref String NumeroHBL, String Usuario)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSU_UnRegNumerarHBL");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_NumeroHBL", NumeroHBL, SqlDbType.VarChar, 50, ParameterDirection.InputOutput);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUsuario", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            {
               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchDOOV_NumeroHBL"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchDOOV_NumeroHBL"].Value.ToString()))
               { NumeroHBL = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchDOOV_NumeroHBL"].Value.ToString(); }
               return true;
            }
            else
            { return false; }

         }
         catch (Exception)
         {
            throw;
         }
      }

      private Boolean OPE_Validate_GenerarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, ref String x_mensaje)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_PREFSV_GenerarCuentasCorrientes");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", x_EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", x_SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", x_NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", x_CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", x_CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);

            System.Data.DataSet dsValidacion = DataAccessEnterpriseSQL.DAExecuteDataSet();

            if (dsValidacion != null && dsValidacion.Tables.Count > 0 && dsValidacion.Tables[0].Rows.Count > 0)
            {
               foreach (System.Data.DataRow _drValidacion in dsValidacion.Tables[0].Rows)
               {
                  if (_drValidacion["SERV_Codigo"] == DBNull.Value)
                  { x_mensaje += String.Format("* La Orden de Venta {0} {1}", _drValidacion["CCOT_NumDoc"], _drValidacion["CCOT_Validacion"]) + Environment.NewLine; }
                  else
                  { x_mensaje += String.Format("* La Orden de Venta {0} para el servicio {1}: {2}", _drValidacion["CCOT_NumDoc"], _drValidacion["SERV_Nombre"], _drValidacion["CCOT_Validacion"]) + Environment.NewLine; }
               }
            }

            if (String.IsNullOrEmpty(x_mensaje))
            { return true; }
            else
            { return false; }
         }
         catch (Exception)
         { throw; }
      }
      private Boolean OPE_Insert_GenerarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, Decimal x_CCCT_TipoCambio, DateTime x_CCCT_FecEmision, String x_AUDI_Usuario, ref String x_mensaje)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_PREFSI_GenerarCuentasCorrientes");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", x_EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", x_SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", x_NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", x_CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", x_CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_TipoCambio", x_CCCT_TipoCambio, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecEmision", x_CCCT_FecEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_AUDI_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

            return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
            

            //using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            //{
            //   while (reader.Read())
            //   {
            //      if (String.IsNullOrEmpty(x_mensaje))
            //      { x_mensaje = "Se han encontrado los siguientes servicios con información incompleta" + Environment.NewLine; }
            //      x_mensaje += reader.GetValue(0) + Environment.NewLine;
            //   }
            //}

            //if (String.IsNullOrEmpty(x_mensaje))
            //{ return true; }
            //else
            //{ return false; }
         }
         catch (Exception)
         {
            throw;
         }
      }
      private Boolean OPE_Update_CalculaRebateSave(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            //Nullable<Int32> x_ENTC_CodTransportista, Nullable<Int32> x_ENTC_CodCliente, Nullable<DateTime> x_FEC_IniEmbarque, Nullable<DateTime> x_FEC_FinEmbarque, Nullable<DateTime> x_FEC_IniLlegada, Nullable<DateTime> x_FEC_FinLlegada, String x_NRO_HBL, String x_NRO_OV
            Boolean _tieneTipo = false;
            if (x_REBA_Tipo == "R")
            { DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSU_CalculaRebate"); _tieneTipo = true; }
            else if (x_REBA_Tipo == "G")
            { DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSU_CalculaGRR"); _tieneTipo = true; }
            if (_tieneTipo)
            {
               if (x_filters != null && x_filters.Count > 0)
               {
                  foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
                  { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
               }

               //DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", x_ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", x_ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarqueIni", x_FEC_IniEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarqueFin", x_FEC_FinEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecLlegadaIni", x_FEC_IniLlegada, SqlDbType.DateTime, 8, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecLlegadaFin", x_FEC_FinLlegada, SqlDbType.DateTime, 8, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_HBL", x_NRO_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", x_NRO_OV, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return false; }
         }
         catch (Exception)
         {
            throw;
         }
      }
      #endregion

      #region [ Reportes ]
      public System.Data.DataTable SelectStatment(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 NVIA_Codigo, Nullable<Int16> CCOT_Tipo, Nullable<Int32> CCOT_Numero, String Usuario, Decimal TIPC_TipoCambio, Boolean SCOT_ChangeControl, Boolean CCOT_ServicioTransmision)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_PREFSS_GenerarStatment");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", Usuario, SqlDbType.VarChar, 20);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", System.DBNull.Value, SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", System.DBNull.Value, SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", System.DBNull.Value, SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", System.DBNull.Value, SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_FecEmiDesde", System.DBNull.Value, SqlDbType.DateTime, 8);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_FecEmiHasta", System.DBNull.Value, SqlDbType.DateTime, 8);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE1", "FLE", SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE1", "001", SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE2", "FLE", SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE2", "002", SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE3", "FLE", SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE3", "003", SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE4", "FLE", SqlDbType.Char, 3);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE4", "004", SqlDbType.Char, 3);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_TipoCambio", TIPC_TipoCambio, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbtiSERV_SinChangeControl", SCOT_ChangeControl, SqlDbType.Bit, 1);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbtiCCOT_ServicioTransmision", CCOT_ServicioTransmision, SqlDbType.Bit, 1);

            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 1)
            { _ds.Tables[0].TableName = "Statment"; return _ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet SelectReporteGerencia(String REPO_StoredProcedure, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime REPO_FechaInicio, DateTime REPO_FechaTermino, Decimal TIPC_TipoCambio)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure(REPO_StoredProcedure);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREPO_FechaInicio", REPO_FechaInicio, SqlDbType.DateTime, 8);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREPO_FechaTermino", REPO_FechaTermino, SqlDbType.DateTime, 8);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_TipoCambio", TIPC_TipoCambio, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);

            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null)
            { return _ds; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet SelectReporteGerencia(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure(REPO_StoredProcedure);
            DataAccessEnterpriseSQL.DASqlCommand.CommandTimeout = 3000;
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }

            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null)
            { return _ds; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }

      public System.Data.DataTable SelectStatmentChange(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure(REPO_StoredProcedure);
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }

            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count > 0 && _ds.Tables[0] != null && _ds.Tables[0].Rows.Count > 0)
            { return _ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}