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
	public partial class BLContrato
	{
		#region [ Consultas ]
      private ObservableCollection<Contrato> SelectAllByFiltro(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta, Boolean CONT_Activo)
      {
         try
         {
            ObservableCollection<Contrato> items = new ObservableCollection<Contrato>();
            Contrato item = new Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecDesde", CONT_FecDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecHasta", CONT_FecHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCONT_Activo", CONT_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
            
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Contrato();
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
      private ObservableCollection<Contrato> SelectAllByAyuda(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta)
      {
         try
         {
            ObservableCollection<Contrato> items = new ObservableCollection<Contrato>();
            Contrato item = new Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_Ayuda");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecDesde", CONT_FecDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecHasta", CONT_FecHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Contrato();
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
      private DataTable SelectAllByAyudaPivot(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CCOT_Versionada = false)
      {
         try
         {
            ObservableCollection<Contrato> items = new ObservableCollection<Contrato>();
            Contrato item = new Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_AyudaPivot");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecDesde", CONT_FecDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecHasta", CONT_FecHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCOT_Versionada", CCOT_Versionada, SqlDbType.Bit, 1, ParameterDirection.Input);
            DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds != null && ds.Tables.Count > 0)
            { return ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      private DataTable SelectAllByAyudaPivotOV(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino)
      {
         try
         {
            ObservableCollection<Contrato> items = new ObservableCollection<Contrato>();
            Contrato item = new Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_AyudaPivotOV");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecDesde", CONT_FecDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecHasta", CONT_FecHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
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

      private DataTable SelectAllByReporte(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo)
      {
         try
         {
            ObservableCollection<Contrato> items = new ObservableCollection<Contrato>();
            Contrato item = new Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_Reporte");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_Fecha", CONT_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCONT_Activo", CONT_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
            DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds != null && ds.Tables.Count > 0)
            { return ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      private DataTable SelectAllByReporteCosto(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo)
      {
         try
         {
            ObservableCollection<Contrato> items = new ObservableCollection<Contrato>();
            Contrato item = new Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_ReporteCosto");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_Fecha", CONT_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCONT_Activo", CONT_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
            DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds != null && ds.Tables.Count > 0)
            { return ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion

		#region [ Metodos ]
      private Boolean SelectOneCopy(Int16 EMPR_Codigo, ref Int32 CONT_CodigoNew, Int32 CONT_Codigo, String AUDI_Usuario)
      {
         try
         {
            Contrato item = new Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_Copia");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_CodigoNew", CONT_CodigoNew, SqlDbType.Int, 4, ParameterDirection.Output);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", AUDI_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            {
               if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCONT_CodigoNew"].Value.ToString(), out CONT_CodigoNew))
               { return true; }
               else
               { return false; }
            }
            else
            { return false; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      private Boolean SelectValidacion(Int32 CONT_Codigo, String CONT_Numero, DateTime CONT_FecIni, DateTime CONT_FecFin)
      {
         try
         {
            Contrato item = new Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_Validar");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_Numero", CONT_Numero, SqlDbType.VarChar, 50, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecIni", CONT_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecFin", CONT_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               { return false; }
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      private Boolean Copiar(Boolean CopiarContrato, Contrato Item, Contrato ItemNew, String AUDI_Usuario,Int32 PUER_Codigo)
      {
         try
         {
            if (CopiarContrato)
            { 
               DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_CopiarContrato");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_CodigoNew", ItemNew.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);

               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", Item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_Numero", ItemNew.CONT_Numero, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_Descrip", ItemNew.CONT_Descrip, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecEmi", ItemNew.CONT_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecIni", ItemNew.CONT_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCONT_FecFin", ItemNew.CONT_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCONT_Activo", ItemNew.CONT_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", Item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", Item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TapRGM", Item.CONS_TapRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TapVia", Item.CONS_TapVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", Item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPAIOrigen", Item.TIPO_TabPaisOrigen, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPAIOrigen", Item.TIPO_CodPaisOrigen, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodigoOrigen", Item.PUER_CodigoOrigen, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPAIDestino", Item.TIPO_TabPaisDestino, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPAIDestino", Item.TIPO_CodPaisDestino, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodigoDestino", Item.PUER_CodigoDestino, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", AUDI_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int32 _CONT_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCONT_CodigoNew"].Value.ToString(), out _CONT_Codigo))
                  { ItemNew.CONT_Codigo = _CONT_Codigo; }
                  return true;
               }
               else
               { return false; }

            }
            else
            { 
               DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_CopiarTarifa");

               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", Item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TapRGM", Item.CONS_TapRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPAIOrigen", Item.TIPO_TabPaisOrigen, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPAIOrigen", Item.TIPO_CodPaisOrigen, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodigoOrigen", Item.PUER_CodigoOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPAIDestino", Item.TIPO_TabPaisDestino, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPAIDestino", Item.TIPO_CodPaisDestino, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodigoDestino", Item.PUER_CodigoDestino, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_Codigo", PUER_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", AUDI_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  ItemNew.EMPR_Codigo = Item.EMPR_Codigo;
                  ItemNew.CONT_Codigo = Item.CONT_Codigo;
                  return true; 
               }
               else
               { return false; }
            }
         }
         catch (Exception)
         { throw; }
      }
      #endregion
	}
}
