using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessLogic;
using Infrastructure.Aspect.Collections;
using Delfin.BusinessLogic;
using Delfin.Entities;

using System.Net;
using System.Xml;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.NetworkInformation;

namespace Delfin.BusinessLogic
{
    public partial class BLCab_Cotizacion_OV
    {
        #region [ Consultas ]
        public ObservableCollection<Cab_Cotizacion_OV> GetAllByFiltro(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabFLE, String CONS_CodFLE, String CONS_TabVia, String CONS_CodVia, String CONS_TabEST, String CONS_CodEST, Nullable<Int32> ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodCustomer, Nullable<Int32> ENTC_CodAgente, Nullable<Int32> ENTC_CodBroker, Nullable<Int32> ENTC_CodCliente, Nullable<DateTime> CCOT_FecEmiDesde, Nullable<DateTime> CCOT_FecEmiHasta, String CCOT_NumDoc, String DOOV_HBL, Nullable<Decimal> NoCRM)
        {
            try
            {
                return SelectAllByFiltro(EMPR_Codigo, SUCR_Codigo, CCOT_Tipo, CONS_TabRGM, CONS_CodRGM, CONS_TabFLE, CONS_CodFLE, CONS_TabVia, CONS_CodVia, CONS_TabEST, CONS_CodEST, ENTC_CodEjecutivo, ENTC_CodCustomer, ENTC_CodAgente, ENTC_CodBroker, ENTC_CodCliente, CCOT_FecEmiDesde, CCOT_FecEmiHasta, CCOT_NumDoc, DOOV_HBL, NoCRM);
            }
            catch (Exception)
            { throw; }
        }
        public Int32 GetOneNivelAprobacion(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero)
        {
            try
            {
                return SelectOneNivelAprobacion(EMPR_Codigo, SUCR_Codigo, CCOT_Tipo, CCOT_Numero);
            }
            catch (Exception)
            { throw; }
        }

        public System.Data.DataTable GetAllCab_OV_Cab_LOADByFiltro(Boolean LOAD_SegundoOk, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVia, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> PUER_codOrigen, String LOAD_HBL, String LOAD_MBL, String CCOT_NumDoc, Nullable<DateTime> LOAD_FecPrimerOkIni, Nullable<DateTime> LOAD_FecPrimerOkFin)
        {
            try
            {
                return SelectAllCab_OV_Cab_LOADByFiltro(LOAD_SegundoOk, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVia, ENTC_CodTransportista, PUER_codOrigen, LOAD_HBL, LOAD_MBL, CCOT_NumDoc, LOAD_FecPrimerOkIni, LOAD_FecPrimerOkFin);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public System.Data.DataTable GetAllOVSinLOAD(String CONS_TabRGM, String CONS_CodRGM)
        {
            try
            {
                return SelectAllOVSinLOAD(CONS_TabRGM, CONS_CodRGM);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public System.Data.DataSet OPE_ComparaFleteCosto(System.Data.DataTable x_FleteCostoExcel)
        {
            try
            {
                return ComparaFleteCosto(x_FleteCostoExcel);
            }
            catch (Exception ex)
            {throw ex;}
        }

        #endregion

        #region [ Metodos ]
        public Cab_Cotizacion_OV GetOneNuevaVersion(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario, ref String MensajeError)
        {
            try
            {
                Int32 CCOT_NumeroNew = 0;
                Int16 CCOT_TipoNew = 0;

                if (Versionar(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo, Usuario, ref CCOT_NumeroNew, ref CCOT_TipoNew, ref MensajeError))
                {
                    if (CCOT_NumeroNew > 0)
                    { return GetOne(EMPR_Codigo, SUCR_Codigo, CCOT_NumeroNew, CCOT_TipoNew); }
                    else
                    { return null; }
                }
                else
                { return null; }
            }
            catch (Exception)
            { throw; }
        }
        public Cab_Cotizacion_OV GetOneNuevaCopia(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario)
        {
            try
            {
                Int32 CCOT_NumeroNew = 0;
                Int16 CCOT_TipoNew = 0;

                if (Copiar(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo, Usuario, ref CCOT_NumeroNew, ref CCOT_TipoNew))
                {
                    if (CCOT_NumeroNew > 0)
                    { return GetOne(EMPR_Codigo, SUCR_Codigo, CCOT_NumeroNew, CCOT_TipoNew); }
                    else
                    { return null; }
                }
                else
                { return null; }
            }
            catch (Exception)
            { throw; }
        }
        public Cab_Cotizacion_OV GetOneNuevoPresupuesto(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario)
        {
            try
            {
                Int32 CCOT_NumeroNew = 0;
                Int16 CCOT_TipoNew = 0;

                if (Presupuestar(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo, Usuario, ref CCOT_NumeroNew, ref CCOT_TipoNew))
                {
                    if (CCOT_NumeroNew > 0)
                    { return GetOne(EMPR_Codigo, SUCR_Codigo, CCOT_NumeroNew, CCOT_TipoNew); }
                    else
                    { return null; }
                }
                else
                { return null; }
            }
            catch (Exception)
            { throw; }
        }
        public Cab_Cotizacion_OV GetOneNuevoOrdenVenta(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 CCOT_TipoNew, String Usuario)
        {
            try
            {
                Int32 CCOT_NumeroNew = 0;

                if (GenerarOV(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo, CCOT_TipoNew, Usuario, ref CCOT_NumeroNew))
                {
                    if (CCOT_NumeroNew > 0)
                    { return GetOne(EMPR_Codigo, SUCR_Codigo, CCOT_NumeroNew, CCOT_TipoNew); }
                    else
                    { return null; }
                }
                else
                { return null; }
            }
            catch (Exception)
            { throw; }
        }

        public Boolean SaveEstado(Int16 CCOT_Tipo, Int32 CCOT_Numero, String CONS_TabEST, String CONS_CodEST, String Usuario, DateTime Fecha, ref String CCOT_MensajeError)
        {
            try
            {
                Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
                if (UpdateEstado(CCOT_Tipo, CCOT_Numero, CONS_TabEST, CONS_CodEST, Usuario, Fecha))
                {
                    if (CONS_TabEST == "OVE" && CONS_CodEST == "004")
                    {
                        //if (InsertForward(CCOT_Tipo, CCOT_Numero, ref CCOT_MensajeError))
                        //{ 
                        Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); return true;
                        //}
                        //else
                        //{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }
                    }
                    else
                    { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); return true; }
                }
                else
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }
            }
            catch (Exception)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
        }
        public Boolean ConcluirOV(Int16 CCOT_Tipo, Int32 CCOT_Numero, String CONS_TabEST, String CONS_CodEST, String Usuario, DateTime Fecha, ref String CCOT_MensajeError)
        {
            try
            {
                Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
                if (UpdateEstado(CCOT_Tipo, CCOT_Numero, CONS_TabEST, CONS_CodEST, Usuario, Fecha))
                {
                    if (ConcluirVerificarEstado(CCOT_Tipo, CCOT_Numero, Usuario, ref CCOT_MensajeError))
                    {

                        if (CONS_TabEST == "OVE" && CONS_CodEST == "004")
                        {
                            if (InsertDetalleViaje(CCOT_Tipo, CCOT_Numero, Usuario, ref CCOT_MensajeError))
                            {

                                //if (InsertForward(CCOT_Tipo, CCOT_Numero, ref CCOT_MensajeError))
                                //{ 
                                Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); return true;
                                //}
                                //else
                                //{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }

                            }
                            else
                            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }
                        }
                        else
                        { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); return true; }
                    }
                    else
                    { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }
                }
                else
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }
            }
            catch (Exception)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
        }
        
        public Boolean SavePreAlerta(DataTable _dt)
        {
            try
            {
                Boolean m_isCorrect = true;
                Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();

                foreach (DataRow dtRow in _dt.Rows)
                {
                    UpdatePreAlerta(Convert.ToInt32(dtRow[0].ToString()), dtRow[1].ToString(), Convert.ToDateTime(dtRow[2].ToString()), Convert.ToDateTime(dtRow[3].ToString()), dtRow[4].ToString(), Convert.ToBoolean(dtRow[5].ToString()));//Convert.ToInt32(dtRow[0].ToString()), 
                }
                if (m_isCorrect)
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                else
                { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
                return m_isCorrect;
            }
            catch (Exception)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
        }
        #endregion

        #region [ Reportes ]
        public System.Data.DataTable GetAllKPICotizaciones(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                return SelectKPICotizaciones(EMPR_Codigo, SUCR_Codigo, GEST_FechaDesde, GEST_FechaHasta, PorEjecutivo, ENTC_CodEjecutivo);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllKPIOrdenesVenta(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                return SelectKPIOrdenesVenta(EMPR_Codigo, SUCR_Codigo, GEST_FechaDesde, GEST_FechaHasta, PorEjecutivo, ENTC_CodEjecutivo);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllKPITEUSVendidos(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
        {
            try
            {
                return SelectKPITEUSVendidos(EMPR_Codigo, SUCR_Codigo, GEST_FechaDesde, GEST_FechaHasta, PorEjecutivo, ENTC_CodEjecutivo);
            }
            catch (Exception)
            { throw; }
        }

        public System.Data.DataTable GetReporteFletamiento(Nullable<DateTime> CCOT_FechaDesde, Nullable<DateTime> CCOT_FechaHasta, Nullable<Int32> ENTC_CodCliente, Nullable<Int32> ENTC_CodTransportista, String TIPO_TabCDT, String TIPO_CodCDT, String TIPO_TabTRF, String TIPO_CodTRF, Nullable<Int32> PUER_Codigo)
        {
            try
            {
                return SelectReporteFletamiento(CCOT_FechaDesde, CCOT_FechaHasta, ENTC_CodCliente, ENTC_CodTransportista, TIPO_TabCDT, TIPO_CodCDT, TIPO_TabTRF, TIPO_CodTRF, PUER_Codigo);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllByReporteOV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CCOT_FecEmiDesde, DateTime CCOT_FecEmiHasta, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino)
        {
            try
            {
                return SelectAllByReporteOV(EMPR_Codigo, SUCR_Codigo, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, CCOT_FecEmiDesde, CCOT_FecEmiHasta, ENTC_CodTransportista, PUER_CodOrigen, PUER_CodDestino);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllByReporteRebateHapagHamburg(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref String x_Mensaje)//(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> ENTC_CodCliente, Nullable<DateTime> FEC_IniEmbarque, Nullable<DateTime> FEC_FinEmbarque, Nullable<DateTime> FEC_IniLlegada, Nullable<DateTime> FEC_FinLlegada, String NRO_HBL, String NRO_OV,ref String Mensaje)
        {
            try
            {
                return SelectReporteRebateHapagHamburg(x_REBA_Tipo, x_filters, ref x_Mensaje);//(EMPR_Codigo, SUCR_Codigo, ENTC_CodTransportista, ENTC_CodCliente, FEC_IniEmbarque, FEC_FinEmbarque, FEC_IniLlegada, FEC_FinLlegada, NRO_HBL, NRO_OV, ref Mensaje);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllByReporteTeus(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String NVIA_NroViaje, Nullable<DateTime> FEC_IniETA, Nullable<DateTime> FEC_FinETA, Nullable<DateTime> FEC_IniZarpe, Nullable<DateTime> FEC_FinZarpe, Nullable<DateTime> FEC_IniEmbarque, Nullable<DateTime> FEC_FinEmbarque, Nullable<Int32> ENTC_Transportista, Nullable<Int32> ENTC_Vendedor, Nullable<Int32> ENTC_Deposito, Nullable<Int16> NAVE_Codigo,Boolean Detallado)
        {
            try
            {
                return SelectReporteTeus(EMPR_Codigo, SUCR_Codigo,CONS_TabRGM,CONS_CodRGM,NVIA_NroViaje, FEC_IniETA, FEC_FinETA, FEC_IniZarpe, FEC_FinZarpe,  FEC_IniEmbarque,FEC_FinEmbarque,ENTC_Transportista,ENTC_Vendedor,ENTC_Deposito, NAVE_Codigo, Detallado);
            }
            catch (Exception)
            { throw; }
        }
        public System.Data.DataTable GetAllByProfitNegativo(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<DateTime> FEC_IniConcluye, Nullable<DateTime> FEC_FinConcluye, String DOOV_HBL, String CCOT_NumDoc, Nullable<Int32> ENTC_Transportista, Nullable<Int32> ENTC_Ejecutivo, Nullable<Int32> ENTC_Cliente, ref String Mensaje)
        {
            try
            {
                return SelectProfitNegativo(EMPR_Codigo, SUCR_Codigo, FEC_IniConcluye, FEC_FinConcluye, DOOV_HBL, CCOT_NumDoc, ENTC_Transportista, ENTC_Ejecutivo, ENTC_Cliente, ref Mensaje);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public System.Data.DataTable GetAllByComEjecutivo(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<DateTime> FEC_IniConcluye, Nullable<DateTime> FEC_FinConcluye, String DOOV_HBL, String CCOT_NumDoc, Nullable<Int32> ENTC_Ejecutivo, Nullable<Int32> ENTC_Cliente,ref String Mensaje)
        {
            try
            {
                return SelectComEjecutivo(EMPR_Codigo, SUCR_Codigo, FEC_IniConcluye, FEC_FinConcluye, DOOV_HBL, CCOT_NumDoc, ENTC_Ejecutivo, ENTC_Cliente, ref Mensaje);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public System.Data.DataTable GetAllByCargoManifest(Nullable<Int32> CCOT_Numero, Nullable<Int16> CCOT_Tipo)
        {
            try
            {
                return SelectCargoManifest(CCOT_Numero,CCOT_Tipo);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}