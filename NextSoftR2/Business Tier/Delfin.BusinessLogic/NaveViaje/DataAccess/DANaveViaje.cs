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
    public partial class BLNaveViaje
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }
        public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<NaveViaje> Loader { get; set; }
        public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Cab_Cotizacion_OV> Loader_Cab_Cotizacion_OV { get; set; }
        #endregion

        #region [ Constructores ]
        public BLNaveViaje(IUnityContainer container)
        {
            this.ContainerService = container;
            Loader = new BusinessEntityLoader<NaveViaje>();
            Loader_Cab_Cotizacion_OV = new BusinessEntityLoader<Cab_Cotizacion_OV>();
            NaveViaje item = new NaveViaje();
            Loader.EntityType = item.GetType();
        }
        #endregion

        #region [ Consultas ]
        private ObservableCollection<NaveViaje> SelectAll()
        {
            try
            {
                ObservableCollection<NaveViaje> items = new ObservableCollection<NaveViaje>();
                NaveViaje item = new NaveViaje();
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_NaveViaje");
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new NaveViaje();
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
        private NaveViaje SelectOne(Int32 NVIA_Codigo)
        {
            try
            {
                NaveViaje item = new NaveViaje();
                //DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_NaveViaje");
                DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_UnReg");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
        private bool Insert(ref NaveViaje item)
        {
            try
            {
                if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                {
                    DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASI_UnReg");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroViaje", item.NVIA_NroViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecETA_IMPO_ETD_EXPO", item.NVIA_FecETA_IMPO_ETD_EXPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgentePort_EXPO", item.ENTC_CodAgentePort_EXPO, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinNAVE_Codigo", item.NAVE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCutOff_EXPO", item.NVIA_FecCutOff_EXPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_Codigo", item.PUER_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTRF", item.TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTRF", item.TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTermPort", item.ENTC_CodTermPort, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCierre", item.NVIA_FecCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecLlega_IMPO_Zarpe_EXPO", item.NVIA_FecLlega_IMPO_Zarpe_EXPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecLlega_Expo_Zarpe_IMPO", item.NVIA_FecLlega_Expo_Zarpe_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecPlazoVistoBueno", item.NVIA_FecPlazoVistoBueno, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrNVIA_Estado", item.NVIA_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCierreDire_IMPO_TermEmba_EXPO", item.NVIA_FecCierreDire_IMPO_TermEmba_EXPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecDescarga_IMPO", item.NVIA_FecDescarga_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgenPortVoBo_IMPO", item.ENTC_CodAgenPortVoBo_IMPO, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgenPortVoBo2_IMPO", item.ENTC_CodAgenPortVoBo2_IMPO, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecRecogerDocs", item.ENTC_FecRecogerDocs, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_UsrPreFactura", item.NVIA_UsrPreFactura, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecPreFactura", item.NVIA_FecPreFactura, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_UsrCierreNave", item.NVIA_UsrCierreNave, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCierreNave", item.NVIA_FecCierreNave, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroManifiesto", item.NVIA_NroManifiesto, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NorManifiestoDescon", item.NVIA_NorManifiestoDescon, SqlDbType.VarChar, 20, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                    {
                        Int32 _NVIA_Codigo;
                        if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintNVIA_Codigo"].Value.ToString(), out _NVIA_Codigo))
                        { item.NVIA_Codigo = _NVIA_Codigo; }
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
        private bool Update(ref NaveViaje item)
        {
            try
            {
                if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                {
                    DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASU_UnReg");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroViaje", item.NVIA_NroViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecETA_IMPO_ETD_EXPO", item.NVIA_FecETA_IMPO_ETD_EXPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgentePort_EXPO", item.ENTC_CodAgentePort_EXPO, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinNAVE_Codigo", item.NAVE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCutOff_EXPO", item.NVIA_FecCutOff_EXPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_Codigo", item.PUER_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTRF", item.TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTRF", item.TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTermPort", item.ENTC_CodTermPort, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCierre", item.NVIA_FecCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecLlega_IMPO_Zarpe_EXPO", item.NVIA_FecLlega_IMPO_Zarpe_EXPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecLlega_Expo_Zarpe_IMPO", item.NVIA_FecLlega_Expo_Zarpe_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecPlazoVistoBueno", item.NVIA_FecPlazoVistoBueno, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrNVIA_Estado", item.NVIA_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCierreDire_IMPO_TermEmba_EXPO", item.NVIA_FecCierreDire_IMPO_TermEmba_EXPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecDescarga_IMPO", item.NVIA_FecDescarga_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgenPortVoBo_IMPO", item.ENTC_CodAgenPortVoBo_IMPO, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgenPortVoBo2_IMPO", item.ENTC_CodAgenPortVoBo2_IMPO, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecRecogerDocs", item.ENTC_FecRecogerDocs, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_UsrPreFactura", item.NVIA_UsrPreFactura, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecPreFactura", item.NVIA_FecPreFactura, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_UsrCierreNave", item.NVIA_UsrCierreNave, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCierreNave", item.NVIA_FecCierreNave, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroManifiesto", item.NVIA_NroManifiesto, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NorManifiestoDescon", item.NVIA_NorManifiestoDescon, SqlDbType.VarChar, 20, ParameterDirection.Input);

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
        private bool Delete(ref NaveViaje item)
        {
            try
            {
                if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
                {
                    DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASD_UnReg");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                    { return true; }
                    else
                    { return false; }
                }
                else
                { return true; }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception
                       (String.Format("# No se puede Eliminar esta NAVE VIAJE por tener relaciones activas. #" + ex.Message, ex));
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
