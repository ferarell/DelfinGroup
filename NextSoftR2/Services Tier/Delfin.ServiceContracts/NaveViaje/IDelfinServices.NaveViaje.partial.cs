using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
    public partial interface IDelfinServices
    {

        ObservableCollection<NaveViaje> GetAllNaveViajeByViajeTransportista(String NVIA_NroViaje, Nullable<Int32> ENTC_CodTransportista, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> NVIA_FecETA);

        ObservableCollection<NaveViaje> GetAllNaveViajeByFiltros(Boolean AcceptNulls, String NVIA_Estado, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVia, String CONS_CodVia, Nullable<Int32> ENTC_CodTransportista, Nullable<Int16> NAVE_Codigo, Nullable<DateTime> NVIA_FecCreacion, String NVIA_NroViaje);


        System.Data.DataTable GetAllNaveViajeByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

        ObservableCollection<Cab_Cotizacion_OV> GetAllCab_OV_CabByNVIA_Codigo(Int32 NVIA_Codigo);//Int16 EMPR_Codigo, Int16 SUCR_Codigo,

        System.Data.DataTable GetAllNaveViajeByReporte(String CONS_TabRGM, String CONS_CodRGM, Nullable<DateTime> NVIA_FecETAIni, Nullable<DateTime> NVIA_FecETAFin, Nullable<DateTime> NVIA_FecZarpeIni, Nullable<DateTime> NVIA_FecZarpeFin, Nullable<Int32> ENTC_CodTransportista, Nullable<Int16> NAVE_Codigo);

        //Solicitud de Direccionamiento
        System.Data.DataTable GetAllMBLsByNaveViaje(Nullable<Int32> NVIA_Codigo, Int32 TIPO_Direccionamiento, Nullable<Int32> CCOT_Codigo);
        //Correo de Carga Tarjada
        System.Data.DataTable GetAllCargaTarjadaByNaveViaje(Nullable<Int32> NVIA_Codigo, String TIPO_Embarque, Nullable<Int32> CCOT_Codigo);
        //Emision de HBL
        System.Data.DataTable GetAllEmisionHBLByNaveViaje(Nullable<Int32> NVIA_Codigo, Nullable<Int32> CCOT_Numero);

        System.Data.DataTable GetAllAvisosByNaveViaje(Nullable<Int32> NVIA_Codigo, Nullable<Int32> CCOT_Numero, String CCOT_NumDoc, Nullable<Int32> ENTC_CodCliente);

        System.Data.DataSet GetAllNaveViajeEmisionAduana(Int32 NVIA_Codigo, string Formato);
        System.Data.DataSet GetAllNaveViajeEmisionAduanaTeledespacho(Int32 NVIA_Codigo);

        /// <summary>
        /// Aprobar el Statment
        /// </summary>
        /// <param name="x_NVIA_Codigo">Código de la Nave Viaje</param>
        /// <param name="x_AUDI_Usuario">Usuario  que realiza la aprobación</param>
        /// <param name="x_NVIA_MensajeError">De encontrarse algún error se devolverá el mensaje</param>
        /// <returns></returns>
        bool SaveAprobarStatment(Int32 x_NVIA_Codigo, String x_AUDI_Usuario, ref String x_NVIA_MensajeError);

        /// <summary>
        /// Apertura del Statement
        /// </summary>
        /// <param name="NVIA_Codigo"></param>
        /// <param name="x_Mensaje"></param>
        /// <returns></returns>
        Boolean AbrirStatment_Update_NaveViaje_OV(Nullable<Int32> NVIA_Codigo,ref String x_Mensaje);
        /// <summary>
        /// Actualiza el usuario que emite el statment 
        /// </summary>
        /// <param name="NVIA_Codigo"></param>
        /// <param name="NVIA_UsrEmiteStatment"></param>
        /// <returns></returns>
        Boolean EmiteStatment_Update_User(Nullable<Int32> NVIA_Codigo, String NVIA_UsrEmiteStatment);

        //Control de Transmisiones
        System.Data.DataTable GetAllNaveViajeByControlTransmisiones(String CONS_TabRGM, String CONS_CodRGM, Nullable<DateTime> NVIA_FecETA_ETDIni, Nullable<DateTime> NVIA_FecETA_ETDFin);

        /// <summary>
        /// Verifica si existe una nave viaje con el mismo transportista, regimen, nave, nroViaje, Puerto
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        String CheckNaveViaje(NaveViaje Item);

        /// <summary>
        /// Trae Las Ordenes de Venta Por NaveViaje
        /// </summary>
        /// <param name="x_NVIA_Codigo"></param>
        /// <returns></returns>
        String OrdenesVentaByNVIA(Nullable<Int32> x_NVIA_Codigo);

        /// <summary>
        /// Actualiza Transportista de la OV(s) por Nave Viaje 
        /// </summary>
        /// <param name="x_NVIA_Codigo"></param>
        /// <param name="x_ENTC_CodTransportista"></param>
        /// <returns></returns>
        Boolean UpdateTransportistaOVsByNVIA(Nullable<Int32> x_NVIA_Codigo, Nullable<Int32> x_ENTC_CodTransportista);


        Boolean SaveNaveViaje(ref ObservableCollection<NaveViaje> Items, Entities.NaveViaje.TInterfazNaveViaje x_opcion);
    }
}
