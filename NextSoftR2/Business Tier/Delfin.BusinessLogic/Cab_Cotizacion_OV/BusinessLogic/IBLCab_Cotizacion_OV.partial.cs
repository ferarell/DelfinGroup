using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCab_Cotizacion_OV
	{
		#region [ Consultas ]
      ObservableCollection<Cab_Cotizacion_OV> GetAllByFiltro(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabFLE, String CONS_CodFLE, String CONS_TabVia, String CONS_CodVia, String CONS_TabEST, String CONS_CodEST, Nullable<Int32> ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodCustomer, Nullable<Int32> ENTC_CodAgente, Nullable<Int32> ENTC_CodBroker, Nullable<Int32> ENTC_CodCliente, Nullable<DateTime> CCOT_FecEmiDesde, Nullable<DateTime> CCOT_FecEmiHasta, String CCOT_NumDoc, String DOOV_HBL, Nullable<Decimal> NoCRM);
      Int32 GetOneNivelAprobacion(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero);

      System.Data.DataTable GetAllCab_OV_Cab_LOADByFiltro(Boolean LOAD_SegundoOk, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVia, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> PUER_codOrigen, String LOAD_HBL, String LOAD_MBL, String CCOT_NumDoc, Nullable<DateTime> LOAD_FecPrimerOkIni, Nullable<DateTime> LOAD_FecPrimerOkFin);
      System.Data.DataTable GetAllOVSinLOAD(String CONS_TabRGM, String CONS_CodRGM);
      System.Data.DataSet OPE_ComparaFleteCosto(System.Data.DataTable x_FleteCostoExcel);

        #endregion
		
		#region [ Metodos ]
      Cab_Cotizacion_OV GetOneNuevaVersion(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario, ref String MensajeError);
      Cab_Cotizacion_OV GetOneNuevaCopia(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario);
      Cab_Cotizacion_OV GetOneNuevoPresupuesto(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, String Usuario);
      Cab_Cotizacion_OV GetOneNuevoOrdenVenta(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 CCOT_TipoNew, String Usuario);

      Boolean SaveEstado(Int16 CCOT_Tipo, Int32 CCOT_Numero, String CONS_TabEST, String CONS_CodEST, String Usuario, DateTime Fecha, ref String CCOT_MensajeError);
      Boolean ConcluirOV(Int16 CCOT_Tipo, Int32 CCOT_Numero, String CONS_TabEST, String CONS_CodEST, String Usuario, DateTime Fecha, ref String CCOT_MensajeError);

      Boolean SavePreAlerta(DataTable _dt);
      #endregion

      #region [ Reportes ]
      System.Data.DataTable GetAllKPICotizaciones(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo);
      System.Data.DataTable GetAllKPIOrdenesVenta(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo);
      System.Data.DataTable GetAllKPITEUSVendidos(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo);

      System.Data.DataTable GetReporteFletamiento(Nullable<DateTime> CCOT_FechaDesde, Nullable<DateTime> CCOT_FechaHasta, Nullable<Int32> ENTC_CodCliente, Nullable<Int32> ENTC_CodTransportista, String TIPO_TabCDT, String TIPO_CodCDT, String TIPO_TabTRF, String TIPO_CodTRF, Nullable<Int32> PUER_Codigo);
      System.Data.DataTable GetAllByReporteOV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CCOT_FecEmiDesde, DateTime CCOT_FecEmiHasta, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino);

      System.Data.DataTable GetAllByReporteRebateHapagHamburg(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref String x_Mensaje);//(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> ENTC_CodCliente, Nullable<DateTime> FEC_IniEmbarque, Nullable<DateTime> FEC_FinEmbarque, Nullable<DateTime> FEC_IniLlegada, Nullable<DateTime> FEC_FinLlegada, String NRO_HBL, String NRO_OV, ref String Mensaje);
      System.Data.DataTable GetAllByReporteTeus(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String NVIA_NroViaje, Nullable<DateTime> FEC_IniETA, Nullable<DateTime> FEC_FinETA, Nullable<DateTime> FEC_IniZarpe, Nullable<DateTime> FEC_FinZarpe, Nullable<DateTime> FEC_IniEmbarque, Nullable<DateTime> FEC_FinEmbarque, Nullable<Int32> ENTC_Transportista, Nullable<Int32> ENTC_Vendedor, Nullable<Int32> ENTC_Deposito,Nullable<Int16> NAVE_Codigo, Boolean Detallado);
      System.Data.DataTable GetAllByProfitNegativo(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<DateTime> FEC_IniConcluye, Nullable<DateTime> FEC_FinConcluye, String DOOV_HBL, String CCOT_NumDoc, Nullable<Int32> ENTC_Transportista, Nullable<Int32> ENTC_Ejecutivo, Nullable<Int32> ENTC_Cliente, ref String Mensaje);
      System.Data.DataTable GetAllByComEjecutivo(Nullable<Int16> EMPR_Codigo, Nullable<Int16> SUCR_Codigo, Nullable<DateTime> FEC_IniConcluye, Nullable<DateTime> FEC_FinConcluye, String DOOV_HBL, String CCOT_NumDoc, Nullable<Int32> ENTC_Ejecutivo, Nullable<Int32> ENTC_Cliente,ref String Mensaje);
      System.Data.DataTable GetAllByCargoManifest(Nullable<Int32> CCOT_Numero, Nullable<Int16> CCOT_Tipo);
      #endregion
   }
}
