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
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
   public partial class BLNaveViaje
   {
      #region [ Consultas ]
      private ObservableCollection<NaveViaje> SelectAllByViajeTransportista(String NVIA_NroViaje, Nullable<Int32> ENTC_CodTransportista, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> NVIA_FecETA)
      {
         try
         {
            ObservableCollection<NaveViaje> items = new ObservableCollection<NaveViaje>();
            NaveViaje item = new NaveViaje();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_NaveViaje_Filtro");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroViaje", NVIA_NroViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecETA", NVIA_FecETA, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
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
      /// <summary>
      /// CRISTHIAN JOSE APAZA ARHUATA.
      /// BUSQUEDA POR NUEVOS FILTROS
      /// </summary>
      public ObservableCollection<NaveViaje> SelectAllByFiltros(Boolean AcceptNulls, String NVIA_Estado, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVia, String CONS_CodVia, Nullable<Int32> ENTC_CodTransportista, Nullable<Int16> NAVE_Codigo, Nullable<DateTime> NVIA_FecCreacion, String NVIA_NroViaje)
      {
         try
         {
            ObservableCollection<NaveViaje> items = new ObservableCollection<NaveViaje>();
            NaveViaje item = new NaveViaje();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_Todos");
            //DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrNVIA_Estado", NVIA_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroViaje", NVIA_NroViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNAVE_Codigo", NAVE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecCreacion", NVIA_FecCreacion, SqlDbType.DateTime, 8, ParameterDirection.Input);

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


      private System.Data.DataTable SelectAllByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            DataSet _ds = new DataSet();
            if (!String.IsNullOrEmpty(x_procedure))
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure);
               if (x_filters != null && x_filters.Count > 0)
               {
                  foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
                  { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
               }
               _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
               if (_ds != null && _ds.Tables.Count == 1)
               { _ds.Tables[0].TableName = "Nave"; return _ds.Tables[0]; }
               else
               { return null; }
            }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }

      /// <summary>
      /// Cristhian Jose Apaza
      /// DepTem de las OV pertenecientes  a una Nave Viaje
      /// </summary>
      /// <param name="EMPR_Codigo"></param>
      /// <param name="SUCR_Codigo"></param>
      /// <param name="NVIA_Codigo"></param>
      /// <param name="TIPO_Correo"></param>
      /// <returns></returns>
      public ObservableCollection<Cab_Cotizacion_OV> SelectAllCab_OV_CabByNVIA_Codigo(Int32 NVIA_Codigo)//Int16 EMPR_Codigo, Int16 SUCR_Codigo, 
      {
         try
         {
            ObservableCollection<Cab_Cotizacion_OV> items = new ObservableCollection<Cab_Cotizacion_OV>();
            Cab_Cotizacion_OV item = new Cab_Cotizacion_OV();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_DepTemp");
            //DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            //DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            //DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_Correo", TIPO_Correo, SqlDbType.Int, 4, ParameterDirection.Input);


            //DataSet _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Cab_Cotizacion_OV();
                  Loader_Cab_Cotizacion_OV.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }

      /// <summary>
      /// CRISTHIAN JOSE APAZA ARHUATA.
      /// REPORTE PLANILLA BUQUE
      /// </summary>
      private DataTable SelectReportByFilters(String CONS_TabRGM, String CONS_CodRGM, Nullable<DateTime> NVIA_FecETAIni, Nullable<DateTime> NVIA_FecETAFin, Nullable<DateTime> NVIA_FecZarpeIni, Nullable<DateTime> NVIA_FecZarpeFin, Nullable<Int32> ENTC_CodTransportista, Nullable<Int16> NAVE_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_TodosReportePlanillaBuque");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNAVE_Codigo", NAVE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecETAIni", NVIA_FecETAIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecETAFin", NVIA_FecETAFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecZarpeIni", NVIA_FecZarpeIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecZarpeFin", NVIA_FecZarpeFin, SqlDbType.DateTime, 8, ParameterDirection.Input);

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

      /// <summary>
      /// CRISTHIAN JOSE APAZA ARHUATA.
      /// MB/Ls Por nave viaje para su solicitud de cambio de almacen (direccionamiento )
      /// </summary>
      private DataTable SelectMBLByFilters(Nullable<Int32> NVIA_Codigo, Int32 TIPO_Direccionamiento, Nullable<Int32> CCOT_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_Direccionamiento");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_Direccionamiento", TIPO_Direccionamiento, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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

      /// <summary>
      /// PROCEDURE OF CRISTHIAN JOSE 
      /// </summary>
      /// <param name="NVIA_Codigo"></param>
      /// <param name="TIPO_Embarque"></param>
      /// <param name="TIPO_Correo"></param>
      /// <returns>Carja Tarjada</returns>
      private DataTable SelectCargaTarjadaByNaveViaje(Nullable<Int32> NVIA_Codigo, String TIPO_Embarque, Nullable<Int32> CCOT_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_FCL_LCL");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Embarque", TIPO_Embarque, SqlDbType.VarChar, 50, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Numero", CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            //DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_Correo", TIPO_Correo, SqlDbType.Int, 4, ParameterDirection.Input);

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

      /// <summary>
      /// CRISTHIAN JOSE APAZA ARHUATA.
      /// MB/Ls Por nave viaje para su solicitud de cambio de almacen (direccionamiento )
      /// </summary>
      private DataTable SelectEmisionHBL(Nullable<Int32> NVIA_Codigo,Nullable<Int32> CCOT_Numero)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_EmitirBL");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);

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

      /// <summary>
      /// CRISTHIAN JOSE APAZA ARHUATA.
      /// Avisos nave viaje para su solicitud de cambio de almacen (direccionamiento )
      /// </summary>
      private DataTable SelectAvisos(Nullable<Int32> NVIA_Codigo, Nullable<Int32> CCOT_Numero,String CCOT_NumDoc, Nullable<Int32> ENTC_CodCliente)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_Avisos");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_CodCliente", ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", CCOT_NumDoc, SqlDbType.VarChar, 20, ParameterDirection.Input);

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

      /// <summary>
      /// Reporte de Control de Transmisiones
      /// </summary>
      /// <param name="CONS_TabRGM"></param>
      /// <param name="CONS_CodRGM"></param>
      /// <param name="NVIA_FecLlegadaInicio"></param>
      /// <param name="NVIA_FecLlegadaFin"></param>
      /// <param name="NVIA_FecTermEmbaInicio"></param>
      /// <param name="NVIA_FecTermEmbaFin"></param>
      /// <returns>Cristhian Jose Apaza</returns>
      private DataTable SelectControlTransmisiones(String CONS_TabRGM, String CONS_CodRGM, Nullable<DateTime> NVIA_FecETA_ETDIni, Nullable<DateTime> NVIA_FecETA_ETDFin)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_ReporteControlTransmisiones");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecETA_ETD_Ini", NVIA_FecETA_ETDIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmNVIA_FecETA_ETD_Fin", NVIA_FecETA_ETDFin, SqlDbType.DateTime, 8, ParameterDirection.Input);

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


      private String VerifyExistenceNaveViaje (NaveViaje x_item)
      {
          try
          {
              String _messaggeError = String.Empty;
              DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_Verifica");
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", x_item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", x_item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", x_item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", x_item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@psinNAVE_Codigo", x_item.NAVE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroViaje", x_item.NVIA_NroViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_Codigo", x_item.PUER_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_MensajeError", _messaggeError, SqlDbType.VarChar, 1024, ParameterDirection.InputOutput);

              DataAccessEnterpriseSQL.DAExecuteNonQuery();

              if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value != DBNull.Value)
              { _messaggeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value.ToString(); }

              return _messaggeError;
          }
          catch (Exception ex)
          { throw ex; }
      }

        /// <summary>
        /// Mauricio Bernedo Alvarez.
        /// Envio a Aduana
        /// </summary>
        private System.Data.DataSet SelectEmisionAduana(Int32 NVIA_Codigo, string Formato)
        {
            try
            {
                DataSet _ds = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_EmisionAduana");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@Structure", Formato, SqlDbType.Char, 4, ParameterDirection.Input);
                _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (_ds != null && _ds.Tables.Count == 8)
                {
                    if (Formato != "0471" && Formato != "0171")
                    {
                        //CAB
                        _ds.Tables[0].TableName = "CAB";
                        //MAN
                        _ds.Tables[1].TableName = "MAN";
                        //BLM
                        _ds.Tables[2].TableName = "BLM";
                        //BLH
                        _ds.Tables[3].TableName = "BLH";
                        //ENT
                        _ds.Tables[4].TableName = "ENT";
                        //FLE-- YA NO VA
                        //_ds.Tables[5].TableName = "FLE";
                        //PTR -->NO VA
                        //TRA -->NO VA
                        //DET

                        _ds.Tables[5].TableName = "DET";
                        _ds.Tables[6].TableName = "OVs";
                        _ds.Tables[7].TableName = "MSM";
                    }
                    else
                    {
                        //CAB
                        _ds.Tables[0].TableName = "CAB";
                        //MAN
                        _ds.Tables[1].TableName = "RVC";
                        //BLM
                        _ds.Tables[2].TableName = "PIN";
                        //BLH
                        _ds.Tables[3].TableName = "BLS";
                        //ENT
                        _ds.Tables[4].TableName = "ENT";

                        _ds.Tables[5].TableName = "CNT";
                        _ds.Tables[6].TableName = "TMP";
                        _ds.Tables[7].TableName = "MSM";
                    }

                    return _ds;
                }
                return null;
            }
            catch (Exception ex)
            { throw ex; }
        }

        /// <summary>
        /// Mauricio Bernedo Alvarez.
        /// Envio a Aduana
        /// </summary>
        private System.Data.DataSet SelectEmisionAduanaTeledespacho(Int32 NVIA_Codigo)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_EmisionAduanaTeledespacho");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 7)
            {
               //MAN
               _ds.Tables[0].TableName = "MAN";
               //BLM
               _ds.Tables[1].TableName = "BLM";
               //BLH
               _ds.Tables[2].TableName = "BLH";
               //ENT
               _ds.Tables[3].TableName = "ENT";
               //DET
               _ds.Tables[4].TableName = "DET";
               //Ordenes de Venta 
               _ds.Tables[5].TableName = "OVs";
               //Mensaje de Error
               _ds.Tables[6].TableName = "MSM";

               return _ds;
            }
            return null;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private String OrdenesVentaByNVIA(Nullable<Int32> x_NVIA_Codigo)
      {
          try
          {
              String _OVs = String.Empty;
              DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSS_By_NVIA");
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", x_NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pvchOVs", _OVs, SqlDbType.VarChar, 2000, ParameterDirection.InputOutput);

              DataAccessEnterpriseSQL.DAExecuteNonQuery();

              if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchOVs"].Value != DBNull.Value)
              { _OVs = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchOVs"].Value.ToString(); }

              return _OVs;
          }
          catch (Exception ex)
          { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      private bool UpdateAprobarStatment(Int32 x_NVIA_Codigo, String x_AUDI_Usuario, ref String x_NVIA_MensajeError)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASU_AprobarStatment");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", x_NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_AUDI_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_MensajeError", x_NVIA_MensajeError, SqlDbType.VarChar, 1024, ParameterDirection.InputOutput);

            DataAccessEnterpriseSQL.DAExecuteNonQuery();

            if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value != DBNull.Value)
            { x_NVIA_MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_MensajeError"].Value.ToString(); }
            
            return String.IsNullOrEmpty(x_NVIA_MensajeError);
         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool AbrirStatment_Update(Nullable<Int32> NVIA_Codigo,ref String x_Mensaje)
      {
         try 
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASU_AbrirStatment");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_Mensaje", x_Mensaje, SqlDbType.VarChar, 1024, ParameterDirection.InputOutput);
            DataAccessEnterpriseSQL.DAExecuteNonQuery();
            if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_Mensaje"].Value != DBNull.Value)
            { x_Mensaje = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchNVIA_Mensaje"].Value.ToString(); }
            return String.IsNullOrEmpty(x_Mensaje);
         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool EmitirStatment_Update(Nullable<Int32> NVIA_Codigo, String NVIA_UsrEmiteStatment)
      {
          try
          {
              DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASU_EmitirStatment");
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_UsrEmiteStatment", NVIA_UsrEmiteStatment, SqlDbType.VarChar, 20, ParameterDirection.Input);

              if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
              { return true; }
              else
              { return true; }
          }
          catch (Exception ex)
          { throw ex; }
      }

      private Boolean UpdateTransportistaOVsByNVIA(Nullable<Int32> x_NVIA_Codigo, Nullable<Int32> x_ENTC_CodTransportista)
      {
          try
          {
              DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CCOTSU_Transportista");
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", x_NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", x_ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);

              if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
              { return true; }
              else
              { return false; }
          }
          catch (Exception ex)
          { throw ex; }
      }
      #endregion

   }
}