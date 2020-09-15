using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLNaveViaje
	{
		#region [ Consultas ]
      ObservableCollection<NaveViaje> GetAllByViajeTransportista(String NVIA_NroViaje, Nullable<Int32> ENTC_CodTransportista, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> NVIA_FecETA);
      ObservableCollection<NaveViaje> GetAllByFiltros(Boolean AcceptNulls, String NVIA_Estado, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVia, String CONS_CodVia, Nullable<Int32> ENTC_CodTransportista, Nullable<Int16> NAVE_Codigo, Nullable<DateTime> NVIA_FecCreacion, String NVIA_NroViaje);

      System.Data.DataTable GetAllByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      ObservableCollection<Cab_Cotizacion_OV> GetAllCab_OV_CabByNVIA_Codigo(Int32 NVIA_Codigo);//Int16 EMPR_Codigo, Int16 SUCR_Codigo,

      System.Data.DataTable ReportByFilters(String CONS_TabRGM, String CONS_CodRGM, Nullable<DateTime> NVIA_FecETAIni, Nullable<DateTime> NVIA_FecETAFin, Nullable<DateTime> NVIA_FecZarpeIni, Nullable<DateTime> NVIA_FecZarpeFin, Nullable<Int32> ENTC_CodTransportista, Nullable<Int16> NAVE_Codigo);

      System.Data.DataTable MBLsByNaveViaje(Nullable<Int32> NVIA_Codigo, Int32 TIPO_Direccionamiento, Nullable<Int32> CCOT_Codigo);

      System.Data.DataTable EmisionHBLByNaveViaje(Nullable<Int32> NVIA_Codigo, Nullable<Int32> CCOT_Numero);

      System.Data.DataTable AvisosByNaveViaje(Nullable<Int32> NVIA_Codigo, Nullable<Int32> CCOT_Numero, String CCOT_NumDoc, Nullable<Int32> ENTC_CodCliente);

      /// <summary>
      /// Data Table
      /// </summary>
      /// <param name="NVIA_Codigo"></param>
      /// <param name="TIPO_Embarque"></param>
      /// <returns>Correo de Carga Tajada</returns>
      System.Data.DataTable CargaTarjadaByNaveViaje(Nullable<Int32> NVIA_Codigo, String TIPO_Embarque, Nullable<Int32> CCOT_Codigo);


      System.Data.DataSet GetEmisionAduana(Int32 NVIA_Codigo, string Formato);
      System.Data.DataSet GetEmisionAduanaTeledespacho(Int32 NVIA_Codigo);

      System.Data.DataTable GetAllByControlTransmisiones(String CONS_TabRGM, String CONS_CodRGM, Nullable<DateTime> NVIA_FecETA_ETDIni, Nullable<DateTime> NVIA_FecETA_ETDFin);

      String CheckAllNaveViaje(NaveViaje Item);
      String OVsByNVIA(Nullable<Int32> x_NVIA_Codigo);
      Boolean UpdateTransportistaOVs(Nullable<Int32> x_NVIA_Codigo, Nullable<Int32> x_ENTC_CodTransportista); 
      #endregion
		
		#region [ Metodos ]
      bool SaveAprobarStatment(Int32 x_NVIA_Codigo, String x_AUDI_Usuario, ref String x_NVIA_MensajeError);
      Boolean AbrirStatment(Nullable<Int32> NVIA_Codigo, ref String x_Mensaje);
      Boolean EmiteStatment(Nullable<Int32> NVIA_Codigo, String NVIA_UsrEmiteStatment);

      Boolean Save(ref ObservableCollection<NaveViaje> Items, Entities.NaveViaje.TInterfazNaveViaje x_opcion);
		#endregion
	}
}
