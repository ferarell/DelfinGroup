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
    public partial class BLCab_Cotizacion_OV
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }
        public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Cab_Cotizacion_OV> Loader { get; set; }
        #endregion

        #region [ Constructores ]
        public BLCab_Cotizacion_OV(IUnityContainer container)
        {
            this.ContainerService = container;
            Loader = new BusinessEntityLoader<Cab_Cotizacion_OV>();
            Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
            Loader.EntityType = item.GetType();
        }
        #endregion

        #region [ Consultas ]
        private ObservableCollection<Cab_Cotizacion_OV> SelectAll(Int16 EMPR_Codigo, Int16 SUCR_Codigo)
        {
            try
            {
                ObservableCollection<Cab_Cotizacion_OV> items = new ObservableCollection<Cab_Cotizacion_OV>();
                Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Cab_Cotizacion_OV");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
        private Cab_Cotizacion_OV SelectOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
        {
            try
            {
                Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Cab_Cotizacion_OV");
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
        private bool Insert(ref Cab_Cotizacion_OV item)
        {
            try
            {
                if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                {
                    DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Cab_Cotizacion_OV");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", item.CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPadre", item.CCOT_NumPadre, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TipoPadre", item.CCOT_TipoPadre, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Version", item.CCOT_Version, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Propia", item.CCOT_Propia, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodBroker", item.ENTC_CodBroker, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgente", item.ENTC_CodAgente, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCustomer", item.ENTC_CodCustomer, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", item.ENTC_CodEjecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPresupuesto", item.CCOT_NumPresupuesto, SqlDbType.Decimal, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmi", item.CCOT_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecVcto", item.CCOT_FecVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ServicioLogistico", item.CCOT_ServicioLogistico, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_VoBoGateIn", item.CCOT_VoBoGateIn, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_CargaRefrigerada", item.CCOT_CargaRefrigerada, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pnumCCOT_Temperatura", item.CCOT_Temperatura, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_CargaPeligrosa", item.CCOT_CargaPeligrosa, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Roundtrip", item.CCOT_Roundtrip, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_Observaciones", item.CCOT_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecCierre", item.CCOT_FecCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Almacenaje", item.CCOT_Almacenaje, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_SobreEstadia", item.CCOT_SobreEstadia, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TiempoViaje", item.CCOT_TiempoViaje, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_ValidezOferta", item.CCOT_ValidezOferta, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabINC", item.TIPO_TabINC, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodINC", item.TIPO_CodINC, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabImo", item.TIPO_TabImo, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodImo", item.TIPO_CodImo, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_ImoUN", item.CCOT_ImoUN, SqlDbType.VarChar, 20, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE", item.CONS_TabFLE, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE", item.CONS_CodFLE, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", item.PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodTrasbordo", item.PUER_CodTrasbordo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", item.PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrAprueba", item.CCOT_UsrAprueba, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecAprueba", item.CCOT_FecAprueba, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrAceptaRechaza", item.CCOT_UsrAceptaRechaza, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecAceptaRechaza", item.CCOT_FecAceptaRechaza, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMOT", item.TIPO_TabMOT, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMOT", item.TIPO_CodMOT, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodShipper", item.ENTC_CodShipper, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodConsignee", item.ENTC_CodConsignee, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodNotify", item.ENTC_CodNotify, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTFT", item.CONS_TabTFT, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTFT", item.CONS_CodTFT, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecTarifa", item.CCOT_FecTarifa, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_PagoMBL", item.CCOT_PagoMBL, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_PagoHBL", item.CCOT_PagoHBL, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);

                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDTM", item.TIPO_TabDTM, SqlDbType.Char, 3, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDTM", item.TIPO_CodDTM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_Cntr", item.DOOV_Cntr, SqlDbType.VarChar, 250, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_HBL", item.DOOV_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_MBL", item.DOOV_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_NroBooking", item.DDOV_NroBooking, SqlDbType.VarChar, 50, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecRecBooking", item.DDOV_FecRecBooking, SqlDbType.DateTime, 8, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarque", item.DDOV_FecEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepTemporal", item.ENTC_CodDepTemporal, SqlDbType.Int, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_CodReferencia", item.DOOV_CodReferencia, SqlDbType.Char, 50, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_Feeder_IMPO", item.DOOV_Feeder_IMPO, SqlDbType.VarChar, 100, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOOV_FecETDFeeder_IMPO", item.DOOV_FecETDFeeder_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDDOV_HBLNieto", item.DDOV_HBLNieto, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ServicioTransmision", item.CCOT_ServicioTransmision, SqlDbType.Bit, 1, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTRF", item.TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTRF", item.TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_EnviaAvisoLlegada", item.CCOT_EnviaAvisoLlegada, SqlDbType.Bit, 1, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                    {
                        Int32 _CCOT_Numero;
                        if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_Numero"].Value.ToString(), out _CCOT_Numero))
                        { item.CCOT_Numero = _CCOT_Numero; }
                        Int16 _CCOT_Tipo;
                        if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinCCOT_Tipo"].Value.ToString(), out _CCOT_Tipo))
                        { item.CCOT_Tipo = _CCOT_Tipo; }
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
        private bool Update(ref Cab_Cotizacion_OV item)
        {
            try
            {
                if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                {
                    DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Cab_Cotizacion_OV");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", item.CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPadre", item.CCOT_NumPadre, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TipoPadre", item.CCOT_TipoPadre, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Version", item.CCOT_Version, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Propia", item.CCOT_Propia, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodBroker", item.ENTC_CodBroker, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgente", item.ENTC_CodAgente, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCustomer", item.ENTC_CodCustomer, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", item.ENTC_CodEjecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_NumPresupuesto", item.CCOT_NumPresupuesto, SqlDbType.Decimal, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmi", item.CCOT_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecVcto", item.CCOT_FecVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ServicioLogistico", item.CCOT_ServicioLogistico, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_VoBoGateIn", item.CCOT_VoBoGateIn, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_CargaRefrigerada", item.CCOT_CargaRefrigerada, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pnumCCOT_Temperatura", item.CCOT_Temperatura, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_CargaPeligrosa", item.CCOT_CargaPeligrosa, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Roundtrip", item.CCOT_Roundtrip, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_Observaciones", item.CCOT_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecCierre", item.CCOT_FecCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Almacenaje", item.CCOT_Almacenaje, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_SobreEstadia", item.CCOT_SobreEstadia, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_TiempoViaje", item.CCOT_TiempoViaje, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_ValidezOferta", item.CCOT_ValidezOferta, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabINC", item.TIPO_TabINC, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodINC", item.TIPO_CodINC, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabImo", item.TIPO_TabImo, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodImo", item.TIPO_CodImo, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_ImoUN", item.CCOT_ImoUN, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabFLE", item.CONS_TabFLE, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodFLE", item.CONS_CodFLE, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", item.PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodTrasbordo", item.PUER_CodTrasbordo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", item.PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrAprueba", item.CCOT_UsrAprueba, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecAprueba", item.CCOT_FecAprueba, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_UsrAceptaRechaza", item.CCOT_UsrAceptaRechaza, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecAceptaRechaza", item.CCOT_FecAceptaRechaza, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMOT", item.TIPO_TabMOT, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMOT", item.TIPO_CodMOT, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodShipper", item.ENTC_CodShipper, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodConsignee", item.ENTC_CodConsignee, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodNotify", item.ENTC_CodNotify, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTFT", item.CONS_TabTFT, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTFT", item.CONS_CodTFT, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecTarifa", item.CCOT_FecTarifa, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_PagoMBL", item.CCOT_PagoMBL, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_PagoHBL", item.CCOT_PagoHBL, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);

                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDTM", item.TIPO_TabDTM, SqlDbType.Char, 3, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDTM", item.TIPO_CodDTM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_Cntr", item.DOOV_Cntr, SqlDbType.VarChar, 250, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_HBL", item.DOOV_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOOV_MBL", item.DOOV_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_NroBooking", item.DDOV_NroBooking, SqlDbType.VarChar, 50, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecRecBooking", item.DDOV_FecRecBooking, SqlDbType.DateTime, 8, ParameterDirection.Input); 

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_CodReferencia", item.DOOV_CodReferencia, SqlDbType.Char, 50, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOOV_Feeder_IMPO", item.DOOV_Feeder_IMPO, SqlDbType.VarChar, 100, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOOV_FecETDFeeder_IMPO", item.DOOV_FecETDFeeder_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDDOV_FecEmbarque", item.DDOV_FecEmbarque, SqlDbType.DateTime, 8, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepTemporal", item.ENTC_CodDepTemporal, SqlDbType.Int, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDDOV_HBLNieto", item.DDOV_HBLNieto, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_ServicioTransmision", item.CCOT_ServicioTransmision, SqlDbType.Bit, 1, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTRF", item.TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTRF", item.TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_EnviaAvisoLlegada", item.CCOT_EnviaAvisoLlegada, SqlDbType.Bit, 1, ParameterDirection.Input);

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
        private bool Delete(ref Cab_Cotizacion_OV item)
        {
            try
            {
                if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
                {
                    DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ELIMINAR_Cab_Cotizacion_OV");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);

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
