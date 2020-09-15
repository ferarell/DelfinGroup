using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.ServiceProxy
{
    using Delfin.ServiceContracts;
    using Delfin.BusinessLogic;
    using Delfin.Entities;

    public partial class DelfinServicesProxy : IDelfinServices
    {
        #region [ Consultas ]
        public ObservableCollection<Cab_Cotizacion_OV> GetAllCab_Cotizacion_OVByFiltro(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabFLE, String CONS_CodFLE, String CONS_TabVia, String CONS_CodVia, String CONS_TabEST, String CONS_CodEST, Nullable<Int32> ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodCustomer, Nullable<Int32> ENTC_CodAgente, Nullable<Int32> ENTC_CodBroker, Nullable<Int32> ENTC_CodCliente, Nullable<DateTime> CCOT_FecEmiDesde, Nullable<DateTime> CCOT_FecEmiHasta, String CCOT_NumDoc, String DOOV_HBL, Nullable<Decimal> NoCRM)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllByFiltro(EMPR_Codigo, SUCR_Codigo, CCOT_Tipo, CONS_TabRGM, CONS_CodRGM, CONS_TabFLE, CONS_CodFLE, CONS_TabVia, CONS_CodVia, CONS_TabEST, CONS_CodEST, ENTC_CodEjecutivo, ENTC_CodCustomer, ENTC_CodAgente, ENTC_CodBroker, ENTC_CodCliente, CCOT_FecEmiDesde, CCOT_FecEmiHasta, CCOT_NumDoc, DOOV_HBL, NoCRM);
            }
            catch (Exception)
            { throw; }
        }
        public Int32 GetOneCab_Cotizacion_OVNivelAprobacion(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetOneNivelAprobacion(EMPR_Codigo, SUCR_Codigo, CCOT_Tipo, CCOT_Numero);
            }
            catch (Exception)
            { throw; }
        }

        public System.Data.DataTable GetAllCab_OV_CabLOADByFiltro(Boolean LOAD_SegundoOk, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVia, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> PUER_codOrigen, String LOAD_HBL, String LOAD_MBL, String CCOT_NumDoc, Nullable<DateTime> LOAD_FecPrimerOkIni, Nullable<DateTime> LOAD_FecPrimerOkFin)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllCab_OV_Cab_LOADByFiltro(LOAD_SegundoOk, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVia, ENTC_CodTransportista, PUER_codOrigen, LOAD_HBL, LOAD_MBL, CCOT_NumDoc, LOAD_FecPrimerOkIni, LOAD_FecPrimerOkFin);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public System.Data.DataTable GetAllOVSinLOAD(String CONS_TabRGM, String CONS_CodRGM)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllOVSinLOAD(CONS_TabRGM, CONS_CodRGM);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public System.Data.DataSet OPE_CCOTSS_ComparaFleteCosto(System.Data.DataTable x_FleteCostoExcel)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.OPE_ComparaFleteCosto(x_FleteCostoExcel);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public Cab_Cotizacion_OV GetOneCab_Cotizacion_OVNuevaVersion(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario, ref String MensajeError)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetOneNuevaVersion(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo, Usuario, ref MensajeError);
            }
            catch (Exception)
            { throw; }
        }
        public Cab_Cotizacion_OV GetOneCab_Cotizacion_OVNuevaCopia(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetOneNuevaCopia(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo, Usuario);
            }
            catch (Exception)
            { throw; }
        }
        public Cab_Cotizacion_OV GetOneCab_Cotizacion_OVNuevoPresupuesto(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetOneNuevoPresupuesto(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo, Usuario);
            }
            catch (Exception)
            { throw; }
        }
        public Cab_Cotizacion_OV GetOneCab_Cotizacion_OVNuevoOrdenVenta(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 CCOT_TipoNew, String Usuario)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetOneNuevoOrdenVenta(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo, CCOT_TipoNew, Usuario);
            }
            catch (Exception)
            { throw; }
        }
        public Boolean SaveCab_Cotizacion_OVEstado(Int16 CCOT_Tipo, Int32 CCOT_Numero, String CONS_TabEST, String CONS_CodEST, String Usuario, DateTime Fecha, ref String CCOT_MensajeError)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.SaveEstado(CCOT_Tipo, CCOT_Numero, CONS_TabEST, CONS_CodEST, Usuario, Fecha, ref CCOT_MensajeError);
            }
            catch (Exception)
            { throw; }
        }
        public Boolean SaveCab_Cotizacion_ConcluirOV(Int16 CCOT_Tipo, Int32 CCOT_Numero, String CONS_TabEST, String CONS_CodEST, String Usuario, DateTime Fecha, ref String CCOT_MensajeError)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.ConcluirOV(CCOT_Tipo, CCOT_Numero, CONS_TabEST, CONS_CodEST, Usuario, Fecha, ref CCOT_MensajeError);
            }
            catch (Exception)
            { throw; }
        }

        public Boolean SavePreAlerta(DataTable _dt)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.SavePreAlerta(_dt);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Reportes ]
        public System.Data.DataTable GetAllCab_Cotizacion_OVKPICotizaciones(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllKPICotizaciones(EMPR_Codigo, SUCR_Codigo, GEST_FechaDesde, GEST_FechaHasta, PorEjecutivo, ENTC_CodEjecutivo);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllCab_Cotizacion_OVKPIOrdenesVenta(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllKPIOrdenesVenta(EMPR_Codigo, SUCR_Codigo, GEST_FechaDesde, GEST_FechaHasta, PorEjecutivo, ENTC_CodEjecutivo);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllCab_Cotizacion_OVKPITEUSVendidos(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllKPITEUSVendidos(EMPR_Codigo, SUCR_Codigo, GEST_FechaDesde, GEST_FechaHasta, PorEjecutivo, ENTC_CodEjecutivo);
            }
            catch (Exception)
            { throw; }
        }

        public System.Data.DataTable GetAllCab_Cotizacion_OVReporteFletamiento(Nullable<DateTime> CCOT_FechaDesde, Nullable<DateTime> CCOT_FechaHasta, Nullable<Int32> ENTC_CodCliente, Nullable<Int32> ENTC_CodTransportista, String TIPO_TabCDT, String TIPO_CodCDT, String TIPO_TabTRF, String TIPO_CodTRF, Nullable<Int32> PUER_Codigo)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetReporteFletamiento(CCOT_FechaDesde, CCOT_FechaHasta, ENTC_CodCliente, ENTC_CodTransportista, TIPO_TabCDT, TIPO_CodCDT, TIPO_TabTRF, TIPO_CodTRF, PUER_Codigo);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllCab_Cotizacion_OVByReporteOV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CCOT_FecEmiDesde, DateTime CCOT_FecEmiHasta, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllByReporteOV(EMPR_Codigo, SUCR_Codigo, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, CCOT_FecEmiDesde, CCOT_FecEmiHasta, ENTC_CodTransportista, PUER_CodOrigen, PUER_CodDestino);
            }
            catch (Exception)
            { throw; }
        }

        public System.Data.DataTable GetAllCab_Cotizacion_OVByReporteRebateHapagHamburg(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref String x_Mensaje)//(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> ENTC_CodCliente, Nullable<DateTime> FEC_IniEmbarque, Nullable<DateTime> FEC_FinEmbarque, Nullable<DateTime> FEC_IniLlegada, Nullable<DateTime> FEC_FinLlegada, String NRO_HBL, String NRO_OV,ref String Mensaje)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllByReporteRebateHapagHamburg(x_REBA_Tipo, x_filters, ref x_Mensaje);//(EMPR_Codigo, SUCR_Codigo, ENTC_CodTransportista, ENTC_CodCliente, FEC_IniEmbarque, FEC_FinEmbarque, FEC_IniLlegada, FEC_FinLlegada, NRO_HBL, NRO_OV, ref Mensaje);
            }
            catch (Exception)
            { throw; }
        }

        public System.Data.DataTable GetAllCab_Cotizacion_OVByReporteTeus(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String NVIA_NroViaje, Nullable<DateTime> FEC_IniETA, Nullable<DateTime> FEC_FinETA, Nullable<DateTime> FEC_IniZarpe, Nullable<DateTime> FEC_FinZarpe, Nullable<DateTime> FEC_IniEmbarque, Nullable<DateTime> FEC_FinEmbarque, Nullable<Int32> ENTC_Transportista, Nullable<Int32> ENTC_Vendedor, Nullable<Int32> ENTC_Deposito, Nullable<Int16> NAVE_Codigo,Boolean Detallado)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllByReporteTeus(EMPR_Codigo, SUCR_Codigo, CONS_TabRGM, CONS_CodRGM, NVIA_NroViaje, FEC_IniETA, FEC_FinETA, FEC_IniZarpe, FEC_FinZarpe, FEC_IniEmbarque, FEC_FinEmbarque, ENTC_Transportista, ENTC_Vendedor, ENTC_Deposito, NAVE_Codigo, Detallado);
            }
            catch (Exception)
            { throw; }
        }

        public System.Data.DataTable GetAllCab_Cotizacion_OVByProfitNegativo(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<DateTime> FEC_IniConcluye, Nullable<DateTime> FEC_FinConcluye, String DOOV_HBL, String CCOT_NumDoc, Nullable<Int32> ENTC_Transportista, Nullable<Int32> ENTC_Ejecutivo, Nullable<Int32> ENTC_Cliente,ref String Mensaje)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllByProfitNegativo(EMPR_Codigo, SUCR_Codigo, FEC_IniConcluye, FEC_FinConcluye, DOOV_HBL, CCOT_NumDoc, ENTC_Transportista, ENTC_Ejecutivo, ENTC_Cliente, ref Mensaje);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public System.Data.DataTable GetAllCab_Cotizacion_OVByComEjecutivo(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<DateTime> FEC_IniConcluye, Nullable<DateTime> FEC_FinConcluye, String DOOV_HBL, String CCOT_NumDoc, Nullable<Int32> ENTC_Ejecutivo, Nullable<Int32> ENTC_Cliente, ref String Mensaje)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllByComEjecutivo(EMPR_Codigo, SUCR_Codigo, FEC_IniConcluye, FEC_FinConcluye, DOOV_HBL, CCOT_NumDoc, ENTC_Ejecutivo, ENTC_Cliente, ref Mensaje);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public System.Data.DataTable GetAllCab_Cotizacion_OVByCargoManifest(Nullable<Int32> CCOT_Numero, Nullable<Int16> CCOT_Tipo)
        {
            try
            {
                return BL_Cab_Cotizacion_OV.GetAllByCargoManifest(CCOT_Numero, CCOT_Tipo);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
