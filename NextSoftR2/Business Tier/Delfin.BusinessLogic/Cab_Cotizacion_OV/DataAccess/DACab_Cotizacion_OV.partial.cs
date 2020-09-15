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
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
    public partial class BLCab_Cotizacion_OV
    {
        #region [ Consultas ]
        private Cab_Cotizacion_OV SelectOneRelated(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
        {
            try
            {
                Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Cab_Cotizacion_OV_Related");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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

                    BusinessEntityLoader<Det_Cotizacion_OV_Servicio> LoaderServicio = new BusinessEntityLoader<Det_Cotizacion_OV_Servicio>();
                    Det_Cotizacion_OV_Servicio itemServicio = new Det_Cotizacion_OV_Servicio();
                    LoaderServicio.EntityType = itemServicio.GetType();
                    //COM_Det_Cotizacion_OV_Servicio
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
                    if (CCOT_Tipo == 2)
                    {
                        BusinessEntityLoader<DetNaveViaje> LoaderDetNaveViaje = new BusinessEntityLoader<DetNaveViaje>();
                        DetNaveViaje itemDetNaveViaje = new DetNaveViaje();
                        LoaderDetNaveViaje.EntityType = itemDetNaveViaje.GetType();

                        BusinessEntityLoader<NaveViaje> LoaderNaveViaje = new BusinessEntityLoader<NaveViaje>();
                        NaveViaje itemNaveViaje = new NaveViaje();
                        LoaderNaveViaje.EntityType = itemNaveViaje.GetType();
                        //COM_DetNaveViaje
                        if (reader.NextResult())
                        {
                            if (reader.Read())
                            {
                                LoaderDetNaveViaje.LoadEntity(reader, itemDetNaveViaje);
                                itemDetNaveViaje.Instance = InstanceEntity.Unchanged;
                                item.ItemDetNaveViaje = itemDetNaveViaje;

                                LoaderNaveViaje.LoadEntity(reader, itemNaveViaje);
                                itemNaveViaje.Instance = InstanceEntity.Unchanged;
                                item.ItemNaveViaje = itemNaveViaje;
                            }
                        }

                        BusinessEntityLoader<Det_Cotizacion_OV_Novedad> LoaderNovedad = new BusinessEntityLoader<Det_Cotizacion_OV_Novedad>();
                        Det_Cotizacion_OV_Novedad itemNovedad = new Det_Cotizacion_OV_Novedad();
                        LoaderNovedad.EntityType = itemNovedad.GetType();
                        //COM_Det_Cotizacion_OV_Novedad
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

                        BusinessEntityLoader<Det_Cotizacion_OV_Archivo> LoaderArchivo = new BusinessEntityLoader<Det_Cotizacion_OV_Archivo>();
                        Det_Cotizacion_OV_Archivo itemArchivo = new Det_Cotizacion_OV_Archivo();
                        LoaderArchivo.EntityType = itemArchivo.GetType();
                        //COM_Det_Cotizacion_OV_Archivo
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

                        BusinessEntityLoader<Det_Cotizacion_OV_EventosTareas> LoaderEventoTarea = new BusinessEntityLoader<Det_Cotizacion_OV_EventosTareas>();
                        Det_Cotizacion_OV_EventosTareas itemEventoTarea = new Det_Cotizacion_OV_EventosTareas();
                        LoaderEventoTarea.EntityType = itemEventoTarea.GetType();
                        //COM_Det_Cotizacion_OV_EventoTarea
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
                        //COM_Det_Cotizacion_OV_ServicioSeguro
                        BusinessEntityLoader<Det_Cotizacion_OV_Servicio> LoaderServicioSeguro = new BusinessEntityLoader<Det_Cotizacion_OV_Servicio>();
                        Det_Cotizacion_OV_Servicio itemServicioSeguro = new Det_Cotizacion_OV_Servicio();
                        LoaderServicioSeguro.EntityType = itemServicioSeguro.GetType();
                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                itemServicioSeguro = new Det_Cotizacion_OV_Servicio();
                                LoaderServicioSeguro.LoadEntity(reader, itemServicioSeguro);
                                itemServicioSeguro.Instance = InstanceEntity.Unchanged;
                                item.ItemsServicio.Add(itemServicioSeguro);
                                itemServicioSeguro = null;
                            }
                        }
                        //COM_Sobrestadía

                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        private ObservableCollection<Cab_Cotizacion_OV> SelectAllByFiltro(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabFLE, String CONS_CodFLE, String CONS_TabVia, String CONS_CodVia, String CONS_TabEST, String CONS_CodEST, Nullable<Int32> ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodCustomer, Nullable<Int32> ENTC_CodAgente, Nullable<Int32> ENTC_CodBroker, Nullable<Int32> ENTC_CodCliente, Nullable<DateTime> CCOT_FecEmiDesde, Nullable<DateTime> CCOT_FecEmiHasta, String CCOT_NumDoc, String DOOV_HBL, Nullable<Decimal> NoCRM)
        {
            try
            {
                ObservableCollection<Cab_Cotizacion_OV> items = new ObservableCollection<Cab_Cotizacion_OV>();
                Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Cab_Cotizacion_OV");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE", CONS_TabFLE, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE", CONS_CodFLE, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_CodEjecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCustomer", ENTC_CodCustomer, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgente", ENTC_CodAgente, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodBroker", ENTC_CodBroker, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmiDesde", CCOT_FecEmiDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmiHasta", CCOT_FecEmiHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_HBL", DOOV_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPresupuesto", NoCRM, SqlDbType.Decimal, 4, ParameterDirection.Input);



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
            catch (Exception ex)
            { throw ex; }
        }
        private Int32 SelectOneNivelAprobacion(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Cab_Cotizacion_OV_NivelAprobacion");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NivelAprobacion", null, SqlDbType.SmallInt, 2, ParameterDirection.Output);
                DataAccessEnterpriseSQL.DAExecuteNonQuery();

                Int32 _CCOT_NivelAprobacion;
                if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_NivelAprobacion"].Value.ToString(), out _CCOT_NivelAprobacion))
                { return _CCOT_NivelAprobacion; }
                else
                { return -1; }
            }
            catch (Exception)
            { throw; }
        }
        #region[ Pre_Alerta Control de Documentos]
        private DataTable SelectAllCab_OV_Cab_LOADByFiltro(Boolean LOAD_SegundoOk, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVia, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> PUER_codOrigen, String LOAD_HBL, String LOAD_MBL, String CCOT_NumDoc, Nullable<DateTime> LOAD_FecPrimerOkIni, Nullable<DateTime> LOAD_FecPrimerOkFin)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("COM_CCOTSS_LOAD");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_SegundoOK", LOAD_SegundoOk, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", PUER_codOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_MBL", LOAD_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_HBL", LOAD_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecPrimerOkIni", LOAD_FecPrimerOkIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecPrimerOkFin", LOAD_FecPrimerOkFin, SqlDbType.DateTime, 8, ParameterDirection.Input);

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

        private DataTable SelectAllOVSinLOAD(String CONS_TabRGM, String CONS_CodRGM)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("COM_CCOTSS_SinLoadingList");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);

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

        public System.Data.DataSet ComparaFleteCosto(System.Data.DataTable x_FleteCostoExcel)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_ComparaFleteCosto");
                DataAccessEnterpriseSQL.DAAgregarParametro("@FleteCostoExcel", x_FleteCostoExcel, SqlDbType.Structured);

                _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (_dt != null && _dt.Tables.Count > 0)
                {
                    return _dt;
                }
                return null;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion


        #endregion

        #region [ Metodos ]
        private bool Versionar(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario, ref Int32 CCOT_NumeroNew, ref Int16 CCOT_TipoNew, ref String MensajeError)
        {
            try
            {
                DataAccessEnterpriseSQL.DABeginTransaction();

                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Cab_Cotizacion_OV_Versionar");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumeroNew", CCOT_NumeroNew, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TipoNew", CCOT_TipoNew, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMensajeError", MensajeError, SqlDbType.VarChar, 1024, ParameterDirection.InputOutput);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                {
                    Int32 _CCOT_Numero;
                    if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_NumeroNew"].Value.ToString(), out _CCOT_Numero))
                    {
                        CCOT_NumeroNew = _CCOT_Numero;
                        Int16 _CCOT_Tipo;
                        if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinCCOT_TipoNew"].Value.ToString(), out _CCOT_Tipo))
                        {
                            CCOT_TipoNew = _CCOT_Tipo;

                            DataAccessEnterpriseSQL.DACommitTransaction(); return true;
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString()))
                            { MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString(); }

                            DataAccessEnterpriseSQL.DARollbackTransaction(); return false;
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString()))
                        { MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString(); }

                        DataAccessEnterpriseSQL.DARollbackTransaction(); return false;
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString()))
                    { MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString(); }

                    DataAccessEnterpriseSQL.DARollbackTransaction(); return false;
                }
            }
            catch (Exception ex)
            { DataAccessEnterpriseSQL.DARollbackTransaction(); throw ex; }
        }
        private bool Copiar(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario, ref Int32 CCOT_NumeroNew, ref Int16 CCOT_TipoNew)
        {
            try
            {
                DataAccessEnterpriseSQL.DABeginTransaction();

                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Cab_Cotizacion_OV_Copiar");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumeroNew", CCOT_NumeroNew, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TipoNew", CCOT_TipoNew, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                {
                    Int32 _CCOT_Numero;
                    if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_NumeroNew"].Value.ToString(), out _CCOT_Numero))
                    { CCOT_NumeroNew = _CCOT_Numero; }
                    Int16 _CCOT_Tipo;
                    if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinCCOT_TipoNew"].Value.ToString(), out _CCOT_Tipo))
                    { CCOT_TipoNew = _CCOT_Tipo; }

                    DataAccessEnterpriseSQL.DACommitTransaction(); return true;
                }
                else
                { DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }

            }
            catch (Exception ex)
            { DataAccessEnterpriseSQL.DARollbackTransaction(); throw ex; }
        }
        private bool Presupuestar(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario, ref Int32 CCOT_NumeroNew, ref Int16 CCOT_TipoNew)
        {
            try
            {
                DataAccessEnterpriseSQL.DABeginTransaction();

                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Cab_Cotizacion_OV_Presupuestar");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumeroNew", CCOT_NumeroNew, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TipoNew", CCOT_TipoNew, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                {
                    Int32 _CCOT_Numero;
                    if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_NumeroNew"].Value.ToString(), out _CCOT_Numero))
                    { CCOT_NumeroNew = _CCOT_Numero; }
                    Int16 _CCOT_Tipo;
                    if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinCCOT_TipoNew"].Value.ToString(), out _CCOT_Tipo))
                    { CCOT_TipoNew = _CCOT_Tipo; }

                    DataAccessEnterpriseSQL.DACommitTransaction(); return true;
                }
                else
                { DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }

            }
            catch (Exception ex)
            { DataAccessEnterpriseSQL.DARollbackTransaction(); throw ex; }
        }
        private bool GenerarOV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 CCOT_TipoNew, String Usuario, ref Int32 CCOT_NumeroNew)
        {
            try
            {
                DataAccessEnterpriseSQL.DABeginTransaction();

                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Cab_Cotizacion_OV_GenerarOV");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TipoNew", CCOT_TipoNew, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumeroNew", CCOT_NumeroNew, SqlDbType.Int, 4, ParameterDirection.InputOutput);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

                if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                {
                    Int32 _CCOT_Numero;
                    if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_NumeroNew"].Value.ToString(), out _CCOT_Numero))
                    { CCOT_NumeroNew = _CCOT_Numero; }

                    DataAccessEnterpriseSQL.DACommitTransaction(); return true;
                }
                else
                { DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }

            }
            catch (Exception ex)
            { DataAccessEnterpriseSQL.DARollbackTransaction(); throw ex; }
        }

        private Boolean UpdateEstado(Int16 CCOT_Tipo, Int32 CCOT_Numero, String CONS_TabEST, String CONS_CodEST, String Usuario, DateTime Fecha)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Cab_Cotizacion_OV_Estado");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUsuario", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmFecha", Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
                if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception)
            { throw; }
        }
        private Boolean ConcluirVerificarEstado(Int16 CCOT_Tipo, Int32 CCOT_Numero, String Usuario, ref String CCOT_MensajeError)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Cab_Cotizacion_OV_VerificarTarifa");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUsuario", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@MsgError", CCOT_MensajeError, SqlDbType.VarChar, 200, ParameterDirection.InputOutput);
                DataAccessEnterpriseSQL.DAExecuteNonQuery();

                if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value.ToString()))
                {
                    CCOT_MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value.ToString();
                    if (String.IsNullOrEmpty(CCOT_MensajeError))
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
        private Boolean GenerarDetalleViaje(Int16 CCOT_Tipo, Int32 CCOT_Numero, String Usuario, ref String CCOT_MensajeError)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Cab_Cotizacion_OV_InsertarDetalleViaje");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUsuario", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@MsgError", CCOT_MensajeError, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
                DataAccessEnterpriseSQL.DAExecuteNonQuery();

                if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value.ToString()))
                {
                    CCOT_MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value.ToString();
                    if (String.IsNullOrEmpty(CCOT_MensajeError))
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

        private Boolean InsertForward(Int16 CCOT_Tipo, Int32 CCOT_Numero, ref String CCOT_MensajeError)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_OV_Forward");
                DataAccessEnterpriseSQL.DAAgregarParametro("@NumOV", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                //DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@MsgError", CCOT_MensajeError, SqlDbType.VarChar, 500, ParameterDirection.InputOutput);
                DataAccessEnterpriseSQL.DAExecuteNonQuery();

                if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value.ToString()))
                { CCOT_MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value.ToString(); }

                if (String.IsNullOrEmpty(CCOT_MensajeError))
                { return true; }
                else
                { return false; }
            }
            catch (Exception)
            { throw; }
        }

        private Boolean InsertDetalleViaje(Int16 CCOT_Tipo, Int32 CCOT_Numero, String Usuario, ref String CCOT_MensajeError)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("COM_DVIASI_DesdeOrdenVenta");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUsuario", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

                DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    String _OVs = "";
                    foreach (DataRow _row in ds.Tables[0].Rows)
                    { _OVs += _row["CCOT_NumDoc"].ToString() + ", "; }
                    _OVs = _OVs.Substring(0, _OVs.Length - 2);

                    CCOT_MensajeError = "Existe el mismo puerto " + ds.Tables[0].Rows[0]["PUER_Nombre"].ToString() + " en el Viaje pero con la siguiente fecha " + ds.Tables[0].Rows[0]["DDOV_FecEmbarque"].ToString() + ", en la(s) Orden(es) de Venta(s) " + _OVs + ".";
                    return false;
                }
                else
                { return true; }

                //DataAccessEnterpriseSQL.DAAgregarParametro("@MsgError", CCOT_MensajeError, SqlDbType.VarChar, 500, ParameterDirection.InputOutput);
                //DataAccessEnterpriseSQL.DAExecuteNonQuery();

                //if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value.ToString()))
                //{ CCOT_MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@MsgError"].Value.ToString(); }

                //if (String.IsNullOrEmpty(CCOT_MensajeError))
                //{ return true; }
                //else
                //{ return false; }
            }
            catch (Exception)
            { throw; }
        }
        #endregion

        #region [ Reportes ]
        private DataTable SelectKPICotizaciones(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                if (!PorEjecutivo)
                { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPIClienteConCotizacion"); }
                else
                { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPIClienteConCotizacion_PorEjecutivo"); }
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaDesde", GEST_FechaDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaHasta", GEST_FechaHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
                if (PorEjecutivo && ENTC_CodEjecutivo.HasValue) { DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_CodEjecutivo.Value, SqlDbType.Int, 4, ParameterDirection.Input); }
                System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (ds != null && ds.Tables.Count > 0)
                { return ds.Tables[0]; }
                else
                { return null; }

            }
            catch (Exception ex)
            { throw ex; }
        }
        private DataTable SelectKPIOrdenesVenta(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                if (!PorEjecutivo)
                { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPIClientesOVCerradas"); }
                else
                { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPIClientesOVCerradas_PorEjecutivo"); }
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaDesde", GEST_FechaDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaHasta", GEST_FechaHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
                if (PorEjecutivo && ENTC_CodEjecutivo.HasValue) { DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_CodEjecutivo.Value, SqlDbType.Int, 4, ParameterDirection.Input); }
                System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (ds != null && ds.Tables.Count > 0)
                { return ds.Tables[0]; }
                else
                { return null; }

            }
            catch (Exception ex)
            { throw ex; }
        }
        private DataTable SelectKPITEUSVendidos(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                if (!PorEjecutivo)
                { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPITeusVendidos"); }
                else
                { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPITeusVendidos_PorEjecutivo"); }
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaDesde", GEST_FechaDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaHasta", GEST_FechaHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
                if (PorEjecutivo && ENTC_CodEjecutivo.HasValue) { DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_CodEjecutivo.Value, SqlDbType.Int, 4, ParameterDirection.Input); }
                System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (ds != null && ds.Tables.Count > 0)
                { return ds.Tables[0]; }
                else
                { return null; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        private DataTable SelectReporteFletamiento(Nullable<DateTime> CCOT_FechaDesde, Nullable<DateTime> CCOT_FechaHasta, Nullable<Int32> ENTC_CodCliente, Nullable<Int32> ENTC_CodTransportista, String TIPO_TabCDT, String TIPO_CodCDT, String TIPO_TabTRF, String TIPO_CodTRF, Nullable<Int32> PUER_Codigo)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Cab_Cotizacion_OV_Fletamento");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FechaDesde", CCOT_FechaDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FechaHasta", CCOT_FechaHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_TabCDT", TIPO_TabCDT, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_CodCDT", TIPO_CodCDT, SqlDbType.Char, 3, ParameterDirection.Input);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_TabTRF", TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_CodTRF", TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);

                DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_Codigo", PUER_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

                System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (ds != null && ds.Tables.Count > 0)
                { return ds.Tables[0]; }
                else
                { return null; }
            }
            catch (Exception)
            { throw; }
        }
        private DataTable SelectAllByReporteOV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CCOT_FecEmiDesde, DateTime CCOT_FecEmiHasta, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino)
        {
            try
            {
                ObservableCollection<Contrato> items = new ObservableCollection<Contrato>();
                Contrato item = new Contrato();
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Cab_Cotizacion_OV_ReporteOV");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmiDesde", CCOT_FecEmiDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmiHasta", CCOT_FecEmiHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
                DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (ds != null && ds.Tables.Count > 0)
                { return ds.Tables[0]; }
                else
                { return null; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private DataTable SelectReporteRebateHapagHamburg(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref String x_Mensaje)//(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> ENTC_CodCliente, Nullable<DateTime> FEC_IniEmbarque, Nullable<DateTime> FEC_FinEmbarque, Nullable<DateTime> FEC_IniLlegada, Nullable<DateTime> FEC_FinLlegada, String NRO_HBL, String NRO_OV, ref String Mensaje)
        {
           try
           {
              DataSet _dt = new DataSet();
              Boolean _tieneTipo = false;
              if (x_REBA_Tipo == "R")
              { DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_ReporteHapagHamburg"); _tieneTipo = true; }
              else if (x_REBA_Tipo == "G")
              { DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_ReporteGRR"); _tieneTipo = true; }
              if (_tieneTipo)
              {
                 if (x_filters != null && x_filters.Count > 0)
                 {
                    foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
                    { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
                 }
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarqueIni", FEC_IniEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarqueFin", FEC_FinEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecLlegadaIni", FEC_IniLlegada, SqlDbType.DateTime, 8, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecLlegadaFin", FEC_FinLlegada, SqlDbType.DateTime, 8, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_HBL", NRO_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                 //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", NRO_OV, SqlDbType.VarChar, 20, ParameterDirection.Input);
                 
                 DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_MensajeError", x_Mensaje, SqlDbType.VarChar, 1000, ParameterDirection.InputOutput);

                 _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();

                 if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value != DBNull.Value)
                 { x_Mensaje = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value.ToString(); }
                 if (String.IsNullOrEmpty(x_Mensaje))
                 {
                    
                    if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
                    {
                       return _dt.Tables[0];
                    }
                 }
              }
              return null;
           }
           catch (Exception ex)
           { throw ex; }
        }

        private DataTable SelectReporteTeus(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String NVIA_NroViaje, Nullable<DateTime> FEC_IniETA, Nullable<DateTime> FEC_FinETA, Nullable<DateTime> FEC_IniZarpe, Nullable<DateTime> FEC_FinZarpe, Nullable<DateTime> FEC_IniEmbarque, Nullable<DateTime> FEC_FinEmbarque, Nullable<Int32> ENTC_Transportista, Nullable<Int32> ENTC_Vendedor, Nullable<Int32> ENTC_Deposito, Nullable<Int16> NAVE_Codigo, Boolean Detallado)
        {
            try
            {
                DataSet _dt = new DataSet();
                if (Detallado)
                { DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_ReporteNavesTeus_Detallado"); }
                else
                { DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_ReporteNavesTeus"); }
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_Transportista, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_Vendedor, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepTemporal", ENTC_Deposito, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecEtaIni", FEC_IniETA, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecEtaFin", FEC_FinETA, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecZarpeIni", FEC_IniZarpe, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecZarpeFin", FEC_FinZarpe, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarqueIni", FEC_IniEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarqueFin", FEC_FinEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroViaje", NVIA_NroViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinNAVE_Codigo", NAVE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);

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

        private DataTable SelectProfitNegativo(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<DateTime> FEC_IniConcluye, Nullable<DateTime> FEC_FinConcluye, String DOOV_HBL, String CCOT_NumDoc, Nullable<Int32> ENTC_Transportista, Nullable<Int32> ENTC_Ejecutivo, Nullable<Int32> ENTC_Cliente, ref String Mensaje)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_ReporteProfitNegativo");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_Transportista, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_Ejecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", ENTC_Cliente, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecConcluyeIni", FEC_IniConcluye, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecConcluyeFin", FEC_FinConcluye, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_HBL", DOOV_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_MensajeError", Mensaje, SqlDbType.VarChar, 1000, ParameterDirection.InputOutput);

                DataAccessEnterpriseSQL.DAExecuteNonQuery();
                if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value != DBNull.Value)
                { Mensaje = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value.ToString(); }
                if (String.IsNullOrEmpty(Mensaje))
                {
                    _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                    if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
                    {
                        return _dt.Tables[0];
                    }
                }
                return null;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private DataTable SelectComEjecutivo(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<DateTime> FEC_IniConcluye, Nullable<DateTime> FEC_FinConcluye, String DOOV_HBL, String CCOT_NumDoc, Nullable<Int32> ENTC_Ejecutivo, Nullable<Int32> ENTC_Cliente, ref String Mensaje)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_ReporteComisionEjecutivo");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                //DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_Transportista, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", ENTC_Cliente, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_Ejecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecCanceladoIni", FEC_IniConcluye, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecCanceladoFin", FEC_FinConcluye, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_HBL", DOOV_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_MensajeError", Mensaje, SqlDbType.VarChar, 1000, ParameterDirection.InputOutput);

                DataAccessEnterpriseSQL.DAExecuteNonQuery();
                if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value != DBNull.Value)
                { Mensaje = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value.ToString(); }
                if (String.IsNullOrEmpty(Mensaje))
                {
                    _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                    if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
                    {
                        return _dt.Tables[0];
                    }
                }
                return null;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private DataTable SelectCargoManifest(Nullable<Int32> CCOT_Numero, Nullable<Int16> CCOT_Tipo)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_UnRegCargoManifest");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);

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
        #region[Update PreAlerta]
        private bool UpdatePreAlerta(Int32 LOAD_Codigo, String LOAD_ObserSegundoOk, DateTime LOAD_FecSegundoOK, DateTime LOAD_FecDevolucion, String LOAD_SegundoUsuario, Boolean LOAD_SegundoOK)//Int32 CCOT_Numero,
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("COM_CCOTSU_LOAD");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                //DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_SegundoOK", LOAD_SegundoOK, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_SegundoUsuario", LOAD_SegundoUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecSegundoOK", LOAD_FecSegundoOK, SqlDbType.DateTime, 8, ParameterDirection.Input);
                //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecDevolucion", LOAD_FecDevolucion, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_ObserSegundoOk", LOAD_ObserSegundoOk, SqlDbType.VarChar, 1024, ParameterDirection.Input);


                if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #endregion
    }
}